namespace SoulWorkerResearch.SoulCore.IO.Network
{
    //public abstract class BaseChannelMember<TChannel, TServer, TSession>
    //    where TChannel : BaseChannel<TServer, TSession>
    //    where TServer : BaseServer<TServer, TSession>
    //    where TSession : BaseSession<TServer, TSession>
    //{
    //    protected readonly TChannel Channel;
    //    protected readonly TSession Session;

    //    #region Send Character Packet

    //    public ValueTask<TSession> SendAsync(CharacterSpecialOptionListUpdateResponse value) =>
    //        Session.SendAsync(CategoryCommand.Character, CharacterCommand.UpdateSpecialOptionList, (PacketWriter writer) =>
    //        {
    //            writer.Write(value.Character);
    //            writer.Write((byte)value.Values.Count());

    //            foreach (CharacterSpecialOptionListUpdateResponse.Entity option in value.Values)
    //            {
    //                writer.WriteSpecialOption(option.Id);
    //                writer.Write(option.Value);
    //            }
    //        });

    //    #endregion Send Character Packet

    //    #region Broadcast Chat Packet

    //    public ValueTask BroadcastDeferred(ChatMessageResponse value) =>
    //        Channel.BroadcastDeferred(CategoryCommand.Chat, ChatCommand.Normal, (writer) =>
    //        {
    //            writer.Write(value.Character);
    //            writer.WriteChatType(value.Chat);
    //            writer.WriteByteLengthUnicodeString(value.Message);
    //        });

    //    #endregion Broadcast Chat Packet

    //    #region Broadcast World Packet

    //    public ValueTask<TSession> SendAsync(CharacterOthersResponse value) =>
    //        Session.SendAsync(CategoryCommand.World, WorldCommand.OtherInfosPc, (PacketWriter writer) =>
    //        {
    //            writer.Write((short)value.Values.Count());
    //            foreach (CharacterExPacketSharedStructure entity in value.Values)
    //            {
    //                writer.Write(entity);
    //            }
    //        });

    //    #endregion Broadcast World Packet

    //    #region Broadcast Character Packet

    //    public ValueTask BroadcastDeferred(CharacterLevelSet value) =>
    //        Channel.BroadcastDeferred(CategoryCommand.Character, CharacterCommand.Level, (writer) =>
    //        {
    //            writer.Write(value.Character);
    //            writer.Write(value.Level);
    //        });

    //    #endregion Broadcast Character Packet

    //    #region Broadcast Gesture Packet

    //    public ValueTask BroadcastDeferred(GestureShowResponse value) =>
    //        Channel.BroadcastDeferred(CategoryCommand.Gesture, GestureCommand.Show, (writer) =>
    //        {
    //            writer.Write(value.CharacterId);
    //            writer.Write(value.GestureId);
    //            writer.Write(value.Position);
    //            writer.Write(value.Yaw);
    //            writer.Write(value.Pitch);
    //        });

    //    #endregion Broadcast Gesture Packet

    //    // #region Broadcast Storage Packet

    //    //public void BroadcastItemUpgradeResponse(BaseItem item)
    //    //{ }

    //    //public void BroadcastItemMove(params BaseItem[] slots)
    //    //{
    //    //    // var size
    //    //    //     = sizeof(uint) /* Count */
    //    //    //     + (SystemDefinition.ItemSize * slots.Length) /* Items */
    //    //    //     + sizeof(byte) /* Unknown */;
    //    //    //
    //    //    // using PacketWriter writer = new(size, ClientOpcode.StorageItemMoveBroadcast);
    //    //    //
    //    //    // writer.Write(slots.Length);
    //    //    // foreach (var item in slots)
    //    //    // {
    //    //    //     writer.Write(item);
    //    //    // }
    //    //    //
    //    //    // writer.Write((byte)0);
    //    //    //
    //    //    // SendExceptAsync(session, writer);
    //    //}

    //    // #endregion Broadcast Storage Packet

    //    #region Broadcast Movement Packet

    //    //public void BroadcastDeferred(CharacterToggleWeaponRequest request) =>
    //    //    Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.BattleBt, (writer) =>
    //    //    {
    //    //        writer.Write(request.Character);
    //    //        writer.Write(request.Position);
    //    //        writer.Write(request.Rotation);
    //    //        writer.Write(request.Toggle);
    //    //        writer.Write(request.Unknown1);
    //    //    });

    //    public ValueTask BroadcastDeferred(MoveMoveRequest request) =>
    //        Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.MoveBt, (writer) =>
    //        {
    //            writer.Write(request.CharacterId);
    //            writer.Write(request.MapId);
    //            writer.Write(request.Position);
    //            writer.Write(request.Yaw);
    //            writer.Write(request.TargetPosition);
    //            writer.Write(request.RunBit);
    //            writer.Write(request.Pitch);
    //            writer.Write(request.ChangeMotion);
    //            writer.Write(request.ShouldUpdatePos);
    //        });

    //    public ValueTask BroadcastDeferred(MoveStopRequest request) =>
    //        Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.StopBt, (writer) =>
    //        {
    //            writer.Write(request.CharacterId);
    //            writer.Write(request.MapId);
    //            writer.Write(request.Position);
    //            writer.Write(request.Yaw);
    //            writer.Write(request.Pitch);
    //            writer.Write(request.CheckCanMove);
    //        });

    //    public ValueTask BroadcastDeferred(MoveJumpRequest request) =>
    //        Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.JumpBt, (writer) =>
    //        {
    //            writer.Write(request.CharacterId);
    //            writer.Write(request.MapId);
    //            writer.Write(request.Position);
    //            writer.Write(request.Yaw);
    //            writer.Write(request.TargetPosition);
    //            writer.Write(request.JumpingMove);
    //            writer.Write(request.JumpDrop);
    //            writer.Write(request.BonusJump);
    //        });

    //    public ValueTask BroadcastDeferred(CharacterLoopMotionEndResponse value) =>
    //        Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.LoopMotionEndBt, (writer) =>
    //            writer.Write(value.Character));

    //    #endregion Broadcast Movement Packet

    //    protected BaseChannelMember(TSession session, TChannel channel) =>
    //        (Session, Channel) = (session, channel);
    //}
}