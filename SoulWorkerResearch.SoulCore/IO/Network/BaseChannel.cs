namespace SoulWorkerResearch.SoulCore.IO.Network
{
    //public abstract class BaseChannel<TServer, TSession>
    //    where TServer : BaseServer<TServer, TSession>
    //    where TSession : BaseSession<TServer, TSession>
    //{
    //    private TServer _server;
    //    public readonly ushort Id;

    //    public IReadOnlyDictionary<Guid, TSession> Sessions => _internalSessions;

    //    private readonly ConcurrentDictionary<Guid, TSession> _internalSessions = new();

    //    protected BaseChannel(ushort id) => Id = id;

    //    protected bool TryAdd(TSession session) =>
    //        _internalSessions.TryAdd(session.InternalSession.Id, session);

    //    protected bool TryRemove(TSession session, out TSession? @out) =>
    //        _internalSessions.TryRemove(session.InternalSession.Id, out @out);

    //    #region Broadcast World

    //    protected ValueTask BroadcastDeferred(TSession session, WorldInInfoPcResponse value) =>
    //        BroadcastExceptDeferred(CategoryCommand.World, WorldCommand.InInfoPc, session, (writer) => writer.Write(value.Character));

    //    protected ValueTask BroadcastDeferred(TSession session, WorldOutInfoPcResponse value) =>
    //        BroadcastExceptDeferred(CategoryCommand.World, WorldCommand.OutInfoPc, session, (writer) =>
    //        {
    //            writer.Write((byte)1); // count
    //            writer.Write(value.CharacterId);
    //        });

    //    #endregion Broadcast World

    //    public async ValueTask BroadcastDeferred(CategoryCommand category, object command, Action<PacketWriter> func)
    //    {
    //        await using PacketWriter writer = new(category, command);
    //        func(writer);

    //        BroadcastDeferred(_internalSessions, writer);
    //    }

    //    public async ValueTask BroadcastExceptDeferred(CategoryCommand category, object command, TSession except, Action<PacketWriter> func)
    //    {
    //        await using PacketWriter writer = new(category, command);
    //        func(writer);

    //        BroadcastDeferred(_internalSessions.Where(pair => except.InternalSession.Id != pair.Key), writer);
    //    }

    //    private void BroadcastDeferred(IEnumerable<KeyValuePair<Guid, TSession>> sessions, PacketWriter writer)
    //    {
    //        byte[] packet = PackPacket(writer);
    //        foreach ((Guid _, TSession session) in sessions)
    //        {
    //            SendDeferred(session, packet, writer);
    //        }
    //    }

    //    private static void SendDeferred(TSession session, byte[] packet, PacketWriter writer) => session.InternalSession
    //        .SendAsync(packet, 0, writer.BaseStream.Length);

    //    private byte[] PackPacket(PacketWriter writer) => _server.GetPackedPacket(writer);
    //}
}

// https://youtu.be/l74Ot_2kuNs