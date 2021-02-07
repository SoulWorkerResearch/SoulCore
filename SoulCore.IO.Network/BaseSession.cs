﻿using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.PacketSharedStructure;
using SoulCore.IO.Network.Permissions;
using SoulCore.IO.Network.Providers;
using SoulCore.IO.Network.Requests;
using SoulCore.IO.Network.Responses;
using SoulCore.IO.Network.Responses.Login;
using SoulCore.IO.Network.Responses.Skill;
using SoulCore.IO.Network.Utils;
using SoulCore.Types;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SoulCore.IO.Network
{
    public abstract class BaseSession<TServer, TSession> : IBaseSession
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        private static readonly HandlerProvider<TServer, TSession> _handlers = new();

        public TServer Server => ((InternalServer<TServer, TSession>)InternalSession.Server).Server;

        internal readonly InternalSession<TServer, TSession> InternalSession;

        public void Disconnect() => InternalSession.Disconnect();

        //public SSessionBase SendAsync(BattlePassLoadResponse value) =>
        //    SendAsync(SCCategory.InfiniteTower, SCInfiniteTower.LoadInfo, (SPacketWriter writer) =>
        //    {
        //        writer.Write(value.Id);
        //        writer.Write(ushort.MinValue);
        //        writer.Write(value.NextReward);
        //        writer.Write(ulong.MinValue);
        //        writer.Write(ulong.MinValue);
        //        writer.Write(value.HavePoint);
        //        writer.Write(byte.MinValue);
        //    });

        #region Send

        public TSession SendDeferred(BattlePassLoadResponse value) =>
            SendDeferred(CategoryCommand.Event, EventCommand.BattlePassLoad, (PacketWriter writer) =>
            {
                writer.Write(value.Id);
                writer.Write(value.NextReward);
                writer.Write(value.StartDate);
                writer.Write(value.EndDate);
                writer.Write(value.HavePoint);
                writer.Write(value.IsPremium);
            });

        public TSession SendDeferred(InfiniteTowerLoadInfoResponse value) =>
            SendDeferred(CategoryCommand.InfiniteTower, InfiniteTowerCommand.LoadInfo, (PacketWriter writer) =>
            {
                writer.Write(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            });

        public TSession SendDeferred(SkillLoadResponse value) =>
            SendDeferred(CategoryCommand.Skill, SkillCommand.SkillLoadInfo, (PacketWriter writer) =>
            {
                writer.Write(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x01, 0x00, 0x08, 0x00, 0x08, 0x00, 0x03, 0x00, 0x0E, 0x00, 0x3B, 0xB9, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0x1C, 0x0D, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0xEF, 0x14, 0xEF, 0x03, 0x00, 0x00, 0x00, 0x00, 0x74, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xB8, 0x0C, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0xCB, 0xA7, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0xFB, 0x1C, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0x53, 0x0C, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x2B, 0x92, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0xAF, 0x3A, 0xA5, 0x03, 0x00, 0x00, 0x00, 0x00, 0xF1, 0x0B, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1B, 0x6B, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0x0B, 0x44, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x3B, 0xB9, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0xB7, 0x0C, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x74, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xCB, 0xA7, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0xFB, 0x1C, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0x53, 0x0C, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x2B, 0x92, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0xAF, 0x3A, 0xA5, 0x03, 0x00, 0x00, 0x00, 0x00, 0xEF, 0x0B, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x1B, 0x6B, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0x0B, 0x44, 0xB3, 0x03, 0x00, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x00, 0xF1, 0x0B, 0xB2, 0x03, 0x53, 0x0C, 0xB2, 0x03, 0xB8, 0x0C, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x53, 0x0C, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0xB8, 0x0C, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x1C, 0x0D, 0xB2, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x21, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x23, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x0B, 0x00, 0x15, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x01, 0x00, 0x0B, 0x00, 0x15, 0x00, 0x00, 0x00 });
            });

        public TSession SendDeferred(ChannelInfoResponse value) =>
            SendDeferred(CategoryCommand.Channel, ChannelCommand.Info, (PacketWriter writer) =>
            {
                writer.Write(value.Location);
                writer.Write((byte)value.Values.Count());
                foreach (ChannelInfoResponse.Entity channel in value.Values)
                {
                    writer.Write(channel.Id);
                    writer.WriteChannelLoadStatus(channel.Status);
                }
            });

        public TSession SendDeferred(PostInfoResponse value) =>
            SendDeferred(CategoryCommand.Post, PostCommand.Info, (PacketWriter writer) =>
            {
                writer.Write(ushort.MinValue);
                writer.Write(value.Count);
            });

        public TSession SendDeferred(SPartyInviteResponse value) =>
            SendDeferred(CategoryCommand.Party, PartyCommand.Invite, (PacketWriter writer) =>
            {
                writer.WriteByteLengthUnicodeString(value.Member.Name);
                writer.WriteByteLengthUnicodeString(value.Master.Name);
                writer.Write(value.Master.Id);
                writer.Write(value.Member.Id);
                writer.Write(byte.MinValue);
                writer.Write(byte.MinValue);
                writer.Write(byte.MinValue);
                writer.Write(uint.MinValue);
                writer.Write(byte.MinValue);
            });

        public TSession SendDeferred(PartyDeleteResponse value) =>
            SendDeferred(CategoryCommand.Party, PartyCommand.Delete, (PacketWriter writer) =>
            {
                writer.Write(value.Id);
            });

        public TSession SendCharacterDbLoadDeferred() =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.DbLoadSync);

        public TSession SendDeferred(NpcOthersInfosResponse value) =>
            SendDeferred(CategoryCommand.World, WorldCommand.OtherInfosNpc, (PacketWriter writer) =>
            {
                writer.Write((ushort)value.Values.Count());
                foreach (NpcOthersInfosResponse.Entity entity in value.Values)
                {
                    writer.Write(entity.Id);
                    writer.Write(entity.Position);
                    writer.Write(entity.Rotation);
                    writer.Write(uint.MinValue);
                    writer.Write(entity.Waypoint);
                    writer.Write(uint.MinValue);
                    writer.WriteNpcVisability(NpcVisablity.Visible);
                    writer.Write(entity.CreatureId);
                }
            });

        public TSession SendDeferred(CharacterInfoResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.InfoRes, (PacketWriter writer) =>
            {
                writer.Write(value.Character);
                writer.Write(value.Exp);
                writer.Write(value.Money);
                writer.Write(value.CommonStep);
                writer.Write(value.ConsumeStep);
                writer.Write(value.CostumeStep);
                writer.Write(value.CardStep);
                writer.WriteUserFlags(value.UserFlags);
                writer.WriteSyncUserFlags(value.SyncUserFlags);
                writer.Write(value.BattlePoint);
                writer.Write(value.Ether);
                writer.Write(value.FriendPoint);
                writer.Write(value.AccountId);
                writer.Write(value.NetCafe);
                writer.Write(value.Recycle);
                writer.Write(value.DyePoint);
                writer.Write(value.RenovatePoint);
                writer.Write(value.RefinePoint);
                writer.Write(value._1);
                writer.Write(value.WorldIdGreaterThan20000);
                writer.Write(value.PvPEnabled);
            });

        public TSession SendDeferred(CharacterStatsUpdateResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.UpdateStatList, (PacketWriter writer) =>
            {
                writer.Write((byte)0);

                writer.Write(value.Character);
                writer.Write((byte)value.Values.Count());

                foreach (CharacterStatsUpdateResponse.CSUREntity stat in value.Values)
                {
                    writer.Write(stat.Value);
                    writer.WriteCharacterStat(stat.Id);
                }
            });

        public TSession SendDeferred(CharacterProfileResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.Community, (PacketWriter writer) =>
            {
                writer.WriteProfileStatus(value.Status);
                writer.WriteByteLengthUnicodeString(value.About);
                writer.WriteByteLengthUnicodeString(value.Note);
            });

        public TSession SendDeferred(CharacterPostInfoResponse value) =>
            SendDeferred(CategoryCommand.Post, PostCommand.Info, (PacketWriter writer) =>
            {
                writer.Write(ushort.MinValue);
                writer.Write((ushort)value.Values.Count());
            });

        public TSession SendDeferred(ChatMessageResponse value) =>
            SendDeferred(CategoryCommand.Chat, ChatCommand.Normal, (PacketWriter writer) =>
            {
                writer.Write(value.Character);
                writer.WriteChatType(value.Chat);
                writer.WriteByteLengthUnicodeString(value.Message);
            });

        public TSession SendDeferred(DayEventBoosterResponse value) =>
            SendDeferred(CategoryCommand.Event, EventCommand.DayEventBoosterList, (PacketWriter writer) =>
            {
                writer.Write((ushort)value.Values.Count);
                foreach (DayEventBoosterResponse.Entity booster in value.Values)
                {
                    writer.Write(booster.Maze);
                    writer.Write(booster.Id);
                }
            });

        public TSession SendDeferred(ServiceHeartbeatRequest value) =>
            SendDeferred(CategoryCommand.System, SystemCommand.Ping, (PacketWriter writer) =>
            {
                writer.Write(value.Tick);
            });

        public TSession SendDeferred(DistrictLogOutResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.GobackLobby, (PacketWriter writer) =>
            {
                writer.Write(value.Account);
                writer.Write(value.Character);
                writer.WriteNumberLengthUtf8String(value.Ip);
                writer.Write(value.Port);
                writer.WriteDistrictLogOutWay(DistrictLogOutWay.GoToGateService);
                writer.WriteDistrictLogOutStatus(DistrictLogOutStatus.Success);
            });

        public TSession SendDeferred(DistrictEnterResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.EnterGameServerRes, (PacketWriter writer) =>
            {
                writer.Write(uint.MinValue);
                writer.WriteDistrictConnectResult(value.Result);
                writer.Write(value.MapId);
                writer.Write(byte.MinValue); // echelon lvl???
                writer.Write(uint.MinValue); // echelon  exp???
            });

        public TSession SendDeferred(WorldVersionResponse value) =>
            SendDeferred(CategoryCommand.World, WorldCommand.Version, (PacketWriter writer) =>
            {
                writer.Write(value.Id);
                writer.Write(value.Main);
                writer.Write(value.Sub);
                writer.Write(value.Data);
            });

        public TSession SendDeferred(BoosterRemoveResponse value) =>
            SendDeferred(CategoryCommand.Booster, BoosterCommand.Remove, (PacketWriter writer) =>
            {
                writer.Write(value.Id);
            });

        public TSession SendDeferred(BoosterAddResponse value) =>
            SendDeferred(CategoryCommand.Booster, BoosterCommand.Add, (PacketWriter writer) =>
            {
                writer.Write(value.Id);
                writer.Write(value.PrototypeId);
                writer.Write(value.Duration);
            });

        public TSession SendDeferred(GestureSlotResponse value) =>
            SendDeferred(CategoryCommand.Gesture, GestureCommand.SlotUpdate, (PacketWriter writer) =>
            {
                foreach (uint gestureId in value.GestureIds)
                {
                    writer.Write(gestureId);
                }
            });

        public TSession SendDeferred(GateEnterResponse value) =>
            SendDeferred(CategoryCommand.Login, LoginCommand.EnterServerRes, (PacketWriter writer) =>
            {
                writer.WriteGateEnterResult(value.Result);
                writer.Write(value.AccountId);
            });

        public TSession SendDeferred(GateCharacterMarkAsFavoriteResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.RepresentativeChange, (PacketWriter writer) =>
            {
                writer.Write(value.AccountId);
                writer.Write(value.CharacterId);
                writer.WriteClass(value.Class);
                writer.Write(value.Level);
                writer.WriteByteLengthUnicodeString(value.CharacterName);
                writer.Write(value.PhotoId);
                writer.Write(value.Date);
                writer.Write(value.Error);
            });

        public TSession SendDeferred(GateCharacterListResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.ListRes, (PacketWriter writer) =>
            {
                writer.Write((byte)value.Characters.Count);
                foreach (CharacterPacketSharedStructure character in value.Characters)
                    writer.Write(character);

                writer.Write(value.LastSelected);
                writer.Write(byte.MinValue);
                writer.Write((byte)1);
                writer.Write(value.InitializeTime);
                writer.Write(uint.MinValue);
                writer.Write((ulong)1262271600); // dec/31/2009 | DOS DATE | IDK what a date
                writer.Write((byte)17);
                writer.Write(byte.MinValue);
                writer.Write(byte.MinValue);
                writer.Write(byte.MinValue);
            });

        public TSession SendDeferred(GateCharacterChangeBackgroundResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.ChangeBackground, (PacketWriter writer) =>
            {
                writer.Write(value.AccountId);
                writer.Write(value.BackgroundId);
                writer.Write(uint.MinValue);
            });

        public TSession SendDeferred(EnterMapResponse value) =>
            SendDeferred(CategoryCommand.Character, CharacterCommand.SelectRes, (PacketWriter writer) =>
            {
                writer.Write(value.CharacterId);
                writer.Write(value.AccountId);

                writer.Write(value.ServerId);
                writer.Write(value.JumpId);
                writer.Write(value.PortalId);
                writer.Write(value.Map.Seq);
                writer.Write(value.ParentMap.Seq);

                writer.WriteNumberLengthUtf8String(value.EndPoint.Ip);
                writer.Write(value.EndPoint.Port);
                writer.Write(value.Pos);
                writer.Write(value.Type);

                writer.Write(value.ChangeServer);
                writer.Write(value.ChangeType);
                writer.Write(value.Result);
                writer.Write(value.PartyInfo.GroupType);
                writer.Write(value.PartyInfo.Id);
            });

        public TSession SendDeferred(AuthGateConnectionEndPointResponse endPoint) =>
            SendDeferred(CategoryCommand.Login, LoginCommand.EnterServer, (PacketWriter writer) =>
            {
                writer.WriteNumberLengthUtf8String(endPoint.Ip);
                writer.Write(endPoint.Port);
            });

        public TSession SendDeferred(UserCharacterForServerResponse gates) =>
            SendDeferred(CategoryCommand.Login, LoginCommand.ServerList, (PacketWriter writer) =>
            {
                writer.Write(gates.LastSelectedId);
                writer.Write((byte)gates.Values.Count());

                foreach (UserCharacterForServerResponse.Entity gate in gates.Values)
                {
                    writer.Write(gate.Id);
                    writer.Write(gate.EndPoint.Port);
                    writer.WriteNumberLengthUtf8String(gate.Name);
                    writer.WriteNumberLengthUtf8String(gate.EndPoint.Ip);
                    writer.WriteGateStatus(gate.Status);
                    writer.Write(gate.PlayersOnlineCount);
                    writer.Write(gate.CharactersCount);
                }
            });

        public TSession SendDeferred(ContentsInfoResponse value) =>
            SendDeferred(CategoryCommand.Login, LoginCommand.OptionLoad, (PacketWriter writer) =>
            {
                writer.Write(value.OptionBit);
                writer.Write(value.Content);
                writer.Write(value.AccountId);
                writer.Write(value.KeyOption);
            });

        public TSession SendDeferred(SAuthLoginResponse value) =>
            SendDeferred(CategoryCommand.Login, LoginCommand.Result, (PacketWriter writer) =>
            {
                writer.Write(value.AccountId);
                writer.Write(value.IsClearTutorial);
                writer.Write(Encoding.ASCII.GetBytes(value.Mac));

                writer.WriteByteLengthUnicodeString(value.ErrorMessage);
                writer.WriteAuthLoginErrorMessageCode(value.ErrorCode);

                writer.Write(byte.MinValue);
                writer.Write(value.LoginType);
                writer.WriteByteLengthUnicodeString(value.AuthId);
                writer.Write(value.SessionKey);

                writer.Write(value.GameMasterPower);
                writer.Write(value.BrithYear);
                writer.Write(value.BrithMonth);
                writer.Write(value.BrithDay);
            });

        public TSession SendDeferred(SWorldCurrentDataResponse value) =>
            SendDeferred(CategoryCommand.World, WorldCommand.CurDate, (PacketWriter writer) =>
            {
                writer.Write(value.UnixTimeSeconds);
                writer.Write(value.Year);
                writer.Write(value.Month);
                writer.Write(value.Day);
                writer.Write(value.Hour);
                writer.Write(value.Minute);
                writer.Write(value.Second);
                writer.Write(value.IsDaylightSavingTime);
            });

        public HandlerPermission Permission { get; set; } = HandlerPermission.Anonymous;

        public TSession SendDeferred(CategoryCommand category, object command, Action<PacketWriter> func)
        {
            using PacketWriter writer = new(category, command);
            func(writer);

            return SendDeferred(writer);
        }

        public TSession SendDeferred(CategoryCommand category, object command)
        {
            using PacketWriter writer = new(category, command);
            return SendDeferred(writer);
        }

        #endregion Send

        internal void ProcessPacket(BinaryReader br)
        {
            HandlerProvider<TServer, TSession>.Handler handler = _handlers[br.ReadUInt16()];
            if (handler.Permission == Permission)
            {
                handler.Method.Invoke((TSession)this, br);
            }
        }

        protected internal virtual void OnDisconnected()
        {
        }

        protected BaseSession(BaseServer<TServer, TSession> server) => InternalSession = new(server.InternalServer, (TSession)this);

        private TSession SendDeferred(PacketWriter writer)
        {
            if (!InternalSession.SendAsync(PacketUtils.Pack(writer), 0, writer.BaseStream.Length))
            {
                NetworkUtils.DropNetwork();
            }

            return (TSession)this;
        }
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8