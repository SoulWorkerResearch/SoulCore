using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Responses;
using SoulCore.IO.Network.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace SoulCore.IO.Network
{
    public abstract class BaseChannel<TSession>
        where TSession : SessionBase
    {
        public ushort Id { get; }

        public IReadOnlyDictionary<Guid, TSession> Sessions => _internalSessions;

        private readonly ConcurrentDictionary<Guid, TSession> _internalSessions = new();

        protected BaseChannel(ushort id) =>
            Id = id;

        protected bool TryAdd(TSession session) =>
            _internalSessions.TryAdd(session.Id, session);

        protected bool TryRemove(TSession session, out TSession? @out) =>
            _internalSessions.TryRemove(session.Id, out @out);

        #region Broadcast World

        protected void BroadcastDeferred(TSession session, SChannelBroadcastCharacterInResponse value) =>
            BroadcastExceptDeferred(CategoryCommand.World, WorldCommand.InInfoPc, session, (writer) =>
            {
                writer.WriteCharacter(value.Character);
                writer.WritePlace(value.Place);
            });

        protected void BroadcastDeferred(TSession session, SChannelBroadcastCharacterOutResponse value) =>
            BroadcastExceptDeferred(CategoryCommand.World, WorldCommand.OutInfoPc, session, (writer) =>
            {
                writer.Write((byte)1); // count
                writer.Write(value.Id);
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

            BroadcastDeferred(_internalSessions.Where(pair => except.Id != pair.Key), writer);
        }

        private static void BroadcastDeferred(IEnumerable<KeyValuePair<Guid, TSession>> sessions, PacketWriter writer)
        {
            byte[] packet = GetRawPacket(writer);
            foreach ((Guid _, TSession session) in sessions)
                SendDeferred(session, packet, writer);
        }

        private static void SendDeferred(TSession session, byte[] packet, PacketWriter writer) =>
            session.SendAsync(packet, 0, writer.BaseStream.Length);

        private static byte[] GetRawPacket(PacketWriter writer) => PacketUtils.Pack(writer);
    }
}

// https://youtu.be/l74Ot_2kuNs