using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.IO.Net;

[StructLayout(LayoutKind.Explicit)]
public readonly struct Opcode
{
    public static readonly Opcode Empty = new();

    #region Properties

    public byte Group => _group;
    public byte Command => _command;

    #endregion Properties

    #region Internal Properties

    internal ushort Value => _value;

    #endregion Internal Properties

    #region Operators

    public static implicit operator ushort(Opcode value) => value._value;

    public static implicit operator GroupOpcode(Opcode value) => (GroupOpcode)value._group;
    public static implicit operator SystemOpcode(Opcode value) => (SystemOpcode)value._command;
    public static implicit operator LoginOpcode(Opcode value) => (LoginOpcode)value._command;
    public static implicit operator CharacterOpcode(Opcode value) => (CharacterOpcode)value._command;
    public static implicit operator WorldOpcode(Opcode value) => (WorldOpcode)value._command;
    public static implicit operator MoveOpcode(Opcode value) => (MoveOpcode)value._command;
    public static implicit operator SkillOpcode(Opcode value) => (SkillOpcode)value._command;
    public static implicit operator ChatOpcode(Opcode value) => (ChatOpcode)value._command;
    public static implicit operator ItemOpcode(Opcode value) => (ItemOpcode)value._command;
    public static implicit operator ShopOpcode(Opcode value) => (ShopOpcode)value._command;
    public static implicit operator TradeOpcode(Opcode value) => (TradeOpcode)value._command;
    public static implicit operator MazeOpcode(Opcode value) => (MazeOpcode)value._command;
    public static implicit operator PartyOpcode(Opcode value) => (PartyOpcode)value._command;
    public static implicit operator ItemUpgradeOpcode(Opcode value) => (ItemUpgradeOpcode)value._command;
    public static implicit operator DropOpcode(Opcode value) => (DropOpcode)value._command;
    public static implicit operator QuestOpcode(Opcode value) => (QuestOpcode)value._command;
    public static implicit operator OptionOpcode(Opcode value) => (OptionOpcode)value._command;
    public static implicit operator MonsterOpcode(Opcode value) => (MonsterOpcode)value._command;
    public static implicit operator ItemSetupOpcode(Opcode value) => (ItemSetupOpcode)value._command;
    public static implicit operator FriendOpcode(Opcode value) => (FriendOpcode)value._command;
    public static implicit operator PostOpcode(Opcode value) => (PostOpcode)value._command;
    public static implicit operator SoulMetryOpcode(Opcode value) => (SoulMetryOpcode)value._command;
    public static implicit operator LeagueOpcode(Opcode value) => (LeagueOpcode)value._command;
    public static implicit operator GestureOpcode(Opcode value) => (GestureOpcode)value._command;
    public static implicit operator DailyMissionOpcode(Opcode value) => (DailyMissionOpcode)value._command;
    public static implicit operator VaccumOpcode(Opcode value) => (VaccumOpcode)value._command;
    public static implicit operator MyRoomOpcode(Opcode value) => (MyRoomOpcode)value._command;
    public static implicit operator HelperOpcode(Opcode value) => (HelperOpcode)value._command;
    public static implicit operator InfiniteTowerOpcode(Opcode value) => (InfiniteTowerOpcode)value._command;
    public static implicit operator BoosterOpcode(Opcode value) => (BoosterOpcode)value._command;
    public static implicit operator EventOpcode(Opcode value) => (EventOpcode)value._command;
    public static implicit operator ExchangeOpcode(Opcode value) => (ExchangeOpcode)value._command;
    public static implicit operator RankingOpcode(Opcode value) => (RankingOpcode)value._command;
    public static implicit operator SocialItemOpcode(Opcode value) => (SocialItemOpcode)value._command;
    public static implicit operator ForceOpcode(Opcode value) => (ForceOpcode)value._command;
    public static implicit operator WorldModeOpcode(Opcode value) => (WorldModeOpcode)value._command;
    public static implicit operator WeeklyMissionOpcode(Opcode value) => (WeeklyMissionOpcode)value._command;
    public static implicit operator ModeMazeOpcode(Opcode value) => (ModeMazeOpcode)value._command;
    public static implicit operator RestartOpcode(Opcode value) => (RestartOpcode)value._command;
    public static implicit operator ToolOpcode(Opcode value) => (ToolOpcode)value._command;
    public static implicit operator ChannelOpcode(Opcode value) => (ChannelOpcode)value._command;
    public static implicit operator ServerOpcode(Opcode value) => (ServerOpcode)value._command;
    public static implicit operator ServerUserOpcode(Opcode value) => (ServerUserOpcode)value._command;
    public static implicit operator ServerPartyOpcode(Opcode value) => (ServerPartyOpcode)value._command;
    public static implicit operator ServerFriendOpcode(Opcode value) => (ServerFriendOpcode)value._command;
    public static implicit operator ServerLeagueOpcode(Opcode value) => (ServerLeagueOpcode)value._command;
    public static implicit operator MonitorOpcode(Opcode value) => (MonitorOpcode)value._command;
    public static implicit operator GmAgentOpcode(Opcode value) => (GmAgentOpcode)value._command;
    public static implicit operator ServerForceOpcode(Opcode value) => (ServerForceOpcode)value._command;
    public static implicit operator ServerWorldModeOpcode(Opcode value) => (ServerWorldModeOpcode)value._command;
    public static implicit operator ServerModeMazeOpcode(Opcode value) => (ServerModeMazeOpcode)value._command;

    public static bool operator ==(Opcode left, Opcode right) => left._value == right._value;
    public static bool operator !=(Opcode left, Opcode right) => left._value != right._value;

    #endregion Operators

    #region Constructors

    public Opcode(BinaryReader reader) => _value = reader.ReadUInt16();

    public Opcode(byte group, byte command) => (_group, _command) = (group, command);

    public Opcode(GroupOpcode group, SystemOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, LoginOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, CharacterOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, WorldOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, MoveOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, SkillOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ChatOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ItemOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ShopOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, TradeOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, MazeOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, PartyOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ItemUpgradeOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, DropOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, QuestOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, OptionOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, MonsterOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ItemSetupOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, FriendOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, PostOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, SoulMetryOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, LeagueOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, GestureOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, DailyMissionOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, VaccumOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, MyRoomOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, HelperOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, InfiniteTowerOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, BoosterOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, EventOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ExchangeOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, RankingOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, SocialItemOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ForceOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, WorldModeOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, WeeklyMissionOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ModeMazeOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, RestartOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ToolOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ChannelOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ServerOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ServerUserOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ServerPartyOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ServerFriendOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ServerLeagueOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, MonitorOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, GmAgentOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ServerForceOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ServerWorldModeOpcode command) : this((byte)group, (byte)command)
    {
    }

    public Opcode(GroupOpcode group, ServerModeMazeOpcode command) : this((byte)group, (byte)command)
    {
    }

    #endregion Constructors

    #region Overrides

    public override bool Equals(object? obj) => obj is Opcode opcode && _value == opcode._value;

    public override int GetHashCode() => HashCode.Combine(_value);

    #endregion Overrides

    #region Private Fields

    [FieldOffset(0)]
    private readonly ushort _value = 0;

    [FieldOffset(0)]
    private readonly byte _group = 0;

    [FieldOffset(1)]
    private readonly byte _command = 0;

    #endregion Private Fields
}
