using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Responses;
using SoulCore.IO.Network.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace SoulCore.IO.Network
{
    public abstract class BaseChannel<TServer, TSession>
        where TServer : ServerBase<TServer, TSession>
        where TSession : SessionBase<TServer, TSession>
    {
        public readonly ushort Id;

        public IReadOnlyDictionary<Guid, TSession> Sessions => _internalSessions;

        private readonly ConcurrentDictionary<Guid, TSession> _internalSessions = new();

        protected BaseChannel(ushort id) => Id = id;

        protected bool TryAdd(TSession session) =>
            _internalSessions.TryAdd(session.InternalSession.Id, session);

        protected bool TryRemove(TSession session, out TSession? @out) => _internalSessions.TryRemove(session.InternalSession.Id, out @out);

        #region Broadcast World

        protected void BroadcastDeferred(TSession session, WorldInInfoPcResponse value) =>
            BroadcastExceptDeferred(CategoryCommand.World, WorldCommand.InInfoPc, session, (writer) =>
            {
                writer.Write(value.Character);
                writer.WritePlace(value.Place);
            });

        protected void BroadcastDeferred(TSession session, WorldOutInfoPcResponse value) =>
            BroadcastExceptDeferred(CategoryCommand.World, WorldCommand.OutInfoPc, session, (writer) =>
            {
                writer.Write((byte)1); // count
                writer.Write(value.CharacterId);
            });

        #endregion Broadcast World

        public void BroadcastDeferred(CategoryCommand category, object command, Action<PacketWriter> func)
        {
            using PacketWriter writer = new(category, command);
            func(writer);

            BroadcastDeferred(_internalSessions, writer);
        }

        public void BroadcastExceptDeferred(CategoryCommand category, object command, TSession except, Action<PacketWriter> func)
        {
            using PacketWriter writer = new(category, command);
            func(writer);

            BroadcastDeferred(_internalSessions.Where(pair => except.InternalSession.Id != pair.Key), writer);
        }

        private static void BroadcastDeferred(IEnumerable<KeyValuePair<Guid, TSession>> sessions, PacketWriter writer)
        {
            byte[] packet = PackPacket(writer);
            foreach ((Guid _, TSession session) in sessions)
            {
                SendDeferred(session, packet, writer);
            }
        }

        private static void SendDeferred(TSession session, byte[] packet, PacketWriter writer) =>
            session.InternalSession.SendAsync(packet, 0, writer.BaseStream.Length);

        private static byte[] PackPacket(PacketWriter writer) => PacketUtils.Pack(writer);
    }
}

// https://youtu.be/l74Ot_2kuNs