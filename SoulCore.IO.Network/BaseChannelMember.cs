using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Requests;
using SoulCore.IO.Network.Responses;
using System.Linq;

namespace SoulCore.IO.Network
{
    public abstract class BaseChannelMember<TChannel, TServer, TSession>
        where TChannel : BaseChannel<TServer, TSession>
        where TServer : ServerBase<TServer, TSession>
        where TSession : SessionBase<TServer, TSession>
    {
        protected readonly TChannel Channel;
        protected readonly TSession Session;

        #region Send Character Packet

        public void SendDeferred(CharacterSpecialOptionListUpdateResponse value) =>
            Session.SendDeferred(CategoryCommand.Character, CharacterCommand.UpdateSpecialOptionList, (PacketWriter writer) =>
            {
                writer.Write(value.Character);
                writer.Write((byte)value.Values.Count());

                foreach (CharacterSpecialOptionListUpdateResponse.Entity option in value.Values)
                {
                    writer.WriteSpecialOption(option.Id);
                    writer.Write(option.Value);
                }
            });

        #endregion Send Character Packet

        #region Broadcast Chat Packet

        public void BroadcastDeferred(ChatMessageResponse value) =>
            Channel.BroadcastDeferred(CategoryCommand.Chat, ChatCommand.Normal, (writer) =>
            {
                writer.Write(value.Character);
                writer.WriteChatType(value.Chat);
                writer.WriteByteLengthUnicodeString(value.Message);
            });

        #endregion Broadcast Chat Packet

        #region Broadcast World Packet

        public void SendDeferred(CharacterOthersResponse value) =>
            Session.SendDeferred(CategoryCommand.World, WorldCommand.OtherInfosPc, (PacketWriter writer) =>
            {
                writer.Write((short)value.Values.Count());
                foreach (CharacterOthersResponse.Entity entity in value.Values)
                {
                    writer.WriteCharacter(entity.Character);
                    writer.WritePlace(entity.Place);
                }
            });

        #endregion Broadcast World Packet

        #region Broadcast Character Packet

        public void BroadcastDeferred(CharacterLevelSet value) =>
            Channel.BroadcastDeferred(CategoryCommand.Character, CharacterCommand.Level, (writer) =>
            {
                writer.Write(value.Character);
                writer.Write(value.Level);
            });

        #endregion Broadcast Character Packet

        #region Broadcast Gesture Packet

        public void BroadcastDeferred(CharacterGestureDo value) =>
            Channel.BroadcastDeferred(CategoryCommand.Gesture, GestureCommand.Show, (writer) =>
            {
                writer.Write(value.Character);
                writer.Write(value.Gesture);
                writer.Write(value.Position);
                writer.Write(uint.MinValue);
                writer.Write(value.Rotation);
            });

        #endregion Broadcast Gesture Packet

        // #region Broadcast Storage Packet

        //public void BroadcastItemUpgradeResponse(BaseItem item)
        //{ }

        //public void BroadcastItemMove(params BaseItem[] slots)
        //{
        //    // var size
        //    //     = sizeof(uint) /* Count */
        //    //     + (SystemDefinition.ItemSize * slots.Length) /* Items */
        //    //     + sizeof(byte) /* Unknown */;
        //    //
        //    // using PacketWriter writer = new(size, ClientOpcode.StorageItemMoveBroadcast);
        //    //
        //    // writer.Write(slots.Length);
        //    // foreach (var item in slots)
        //    // {
        //    //     writer.Write(item);
        //    // }
        //    //
        //    // writer.Write((byte)0);
        //    //
        //    // SendExceptAsync(session, writer);
        //}

        // #endregion Broadcast Storage Packet

        #region Broadcast Movement Packet

        public void BroadcastDeferred(CharacterToggleWeaponRequest request) =>
            Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.BattleBt, (writer) =>
            {
                writer.Write(request.Character);
                writer.Write(request.Position);
                writer.Write(request.Rotation);
                writer.Write(request.Toggle);
                writer.Write(request.Unknown1);
            });

        public void BroadcastDeferred(SRMMoveRequest request) =>
            Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.MoveBt, (writer) =>
            {
                writer.Write(request.Character);
                writer.Write(request.Unknown1);
                writer.Write(request.Position);
                writer.Write(request.Rotation);
                writer.Write(request.InterpolatedPosition);
                writer.Write(request.Unknown5);
                writer.Write(request.Unknown6);
                writer.Write(request.Unknown7);
                writer.Write(request.Unknown8);
            });

        public void BroadcastDeferred(SRMStopRequest request) =>
            Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.StopBt, (writer) =>
            {
                writer.Write(request.Character);
                writer.Write(request.Unknown1);
                writer.Write(request.Position);
                writer.Write(request.Rotation);
                writer.Write(request.Unknown4);
                writer.Write(request.Unknown5);
            });

        public void BroadcastDeferred(SRMJumpRequest request) =>
            Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.JumpBt, (writer) =>
            {
                writer.Write(request.Character);
                writer.Write(request.Unknown1);
                writer.Write(request.Unknown2);
                writer.Write(request.Location);
                writer.Write(request.Unknown3);
                writer.Write(request.Position);
                writer.Write(request.Rotation);
                writer.Write(request.InterpolatedPosition);
                writer.Write(request.Unknown5);
                writer.Write(request.Unknown6);
            });

        public void BroadcastDeferred(CharacterLoopMotionEndResponse value) =>
            Channel.BroadcastDeferred(CategoryCommand.Move, MoveCommand.LoopMotionEndBt, (writer) =>
                writer.Write(value.Character));

        #endregion Broadcast Movement Packet

        protected BaseChannelMember(TSession session, TChannel channel) =>
            (Session, Channel) = (session, channel);
    }
}