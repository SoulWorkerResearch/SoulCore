using System.Runtime.InteropServices;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net;

[StructLayout(LayoutKind.Explicit)]
public readonly struct Opcode
{
    public static Opcode Empty => new();

    #region Properties

    [field: FieldOffset(0)] 
    public byte Group { get; }

    [field: FieldOffset(1)] 
    public byte Command { get; }

    #endregion Properties

    #region Internal Properties

    [field: FieldOffset(0)] 
    internal ushort Value { get; } = 0;

    #endregion Internal Properties

    #region Operators

    public static implicit operator ushort(Opcode value)
    {
        return value.Value;
    }

    public static implicit operator Index(Opcode value)
    {
        return value.Value;
    }

    public static implicit operator GroupOpcode(Opcode value)
    {
        return (GroupOpcode)value.Group;
    }

    public static implicit operator SystemOpcode(Opcode value)
    {
        return (SystemOpcode)value.Command;
    }

    public static implicit operator LoginOpcode(Opcode value)
    {
        return (LoginOpcode)value.Command;
    }

    public static implicit operator CharacterOpcode(Opcode value)
    {
        return (CharacterOpcode)value.Command;
    }

    public static implicit operator WorldOpcode(Opcode value)
    {
        return (WorldOpcode)value.Command;
    }

    public static implicit operator MoveOpcode(Opcode value)
    {
        return (MoveOpcode)value.Command;
    }

    public static implicit operator SkillOpcode(Opcode value)
    {
        return (SkillOpcode)value.Command;
    }

    public static implicit operator ChatOpcode(Opcode value)
    {
        return (ChatOpcode)value.Command;
    }

    public static implicit operator ItemOpcode(Opcode value)
    {
        return (ItemOpcode)value.Command;
    }

    public static implicit operator ShopOpcode(Opcode value)
    {
        return (ShopOpcode)value.Command;
    }

    public static implicit operator TradeOpcode(Opcode value)
    {
        return (TradeOpcode)value.Command;
    }

    public static implicit operator MazeOpcode(Opcode value)
    {
        return (MazeOpcode)value.Command;
    }

    public static implicit operator PartyOpcode(Opcode value)
    {
        return (PartyOpcode)value.Command;
    }

    public static implicit operator ItemUpgradeOpcode(Opcode value)
    {
        return (ItemUpgradeOpcode)value.Command;
    }

    public static implicit operator DropOpcode(Opcode value)
    {
        return (DropOpcode)value.Command;
    }

    public static implicit operator QuestOpcode(Opcode value)
    {
        return (QuestOpcode)value.Command;
    }

    public static implicit operator OptionOpcode(Opcode value)
    {
        return (OptionOpcode)value.Command;
    }

    public static implicit operator MonsterOpcode(Opcode value)
    {
        return (MonsterOpcode)value.Command;
    }

    public static implicit operator ItemSetupOpcode(Opcode value)
    {
        return (ItemSetupOpcode)value.Command;
    }

    public static implicit operator FriendOpcode(Opcode value)
    {
        return (FriendOpcode)value.Command;
    }

    public static implicit operator PostOpcode(Opcode value)
    {
        return (PostOpcode)value.Command;
    }

    public static implicit operator SoulMetryOpcode(Opcode value)
    {
        return (SoulMetryOpcode)value.Command;
    }

    public static implicit operator LeagueOpcode(Opcode value)
    {
        return (LeagueOpcode)value.Command;
    }

    public static implicit operator GestureOpcode(Opcode value)
    {
        return (GestureOpcode)value.Command;
    }

    public static implicit operator DailyMissionOpcode(Opcode value)
    {
        return (DailyMissionOpcode)value.Command;
    }

    public static implicit operator VaccumOpcode(Opcode value)
    {
        return (VaccumOpcode)value.Command;
    }

    public static implicit operator MyRoomOpcode(Opcode value)
    {
        return (MyRoomOpcode)value.Command;
    }

    public static implicit operator HelperOpcode(Opcode value)
    {
        return (HelperOpcode)value.Command;
    }

    public static implicit operator InfiniteTowerOpcode(Opcode value)
    {
        return (InfiniteTowerOpcode)value.Command;
    }

    public static implicit operator BoosterOpcode(Opcode value)
    {
        return (BoosterOpcode)value.Command;
    }

    public static implicit operator EventOpcode(Opcode value)
    {
        return (EventOpcode)value.Command;
    }

    public static implicit operator ExchangeOpcode(Opcode value)
    {
        return (ExchangeOpcode)value.Command;
    }

    public static implicit operator RankingOpcode(Opcode value)
    {
        return (RankingOpcode)value.Command;
    }

    public static implicit operator SocialItemOpcode(Opcode value)
    {
        return (SocialItemOpcode)value.Command;
    }

    public static implicit operator ForceOpcode(Opcode value)
    {
        return (ForceOpcode)value.Command;
    }

    public static implicit operator WorldModeOpcode(Opcode value)
    {
        return (WorldModeOpcode)value.Command;
    }

    public static implicit operator WeeklyMissionOpcode(Opcode value)
    {
        return (WeeklyMissionOpcode)value.Command;
    }

    public static implicit operator ModeMazeOpcode(Opcode value)
    {
        return (ModeMazeOpcode)value.Command;
    }

    public static implicit operator RestartOpcode(Opcode value)
    {
        return (RestartOpcode)value.Command;
    }

    public static implicit operator ToolOpcode(Opcode value)
    {
        return (ToolOpcode)value.Command;
    }

    public static implicit operator ChannelOpcode(Opcode value)
    {
        return (ChannelOpcode)value.Command;
    }

    public static implicit operator ServerOpcode(Opcode value)
    {
        return (ServerOpcode)value.Command;
    }

    public static implicit operator ServerUserOpcode(Opcode value)
    {
        return (ServerUserOpcode)value.Command;
    }

    public static implicit operator ServerPartyOpcode(Opcode value)
    {
        return (ServerPartyOpcode)value.Command;
    }

    public static implicit operator ServerFriendOpcode(Opcode value)
    {
        return (ServerFriendOpcode)value.Command;
    }

    public static implicit operator ServerLeagueOpcode(Opcode value)
    {
        return (ServerLeagueOpcode)value.Command;
    }

    public static implicit operator MonitorOpcode(Opcode value)
    {
        return (MonitorOpcode)value.Command;
    }

    public static implicit operator GmAgentOpcode(Opcode value)
    {
        return (GmAgentOpcode)value.Command;
    }

    public static implicit operator ServerForceOpcode(Opcode value)
    {
        return (ServerForceOpcode)value.Command;
    }

    public static implicit operator ServerWorldModeOpcode(Opcode value)
    {
        return (ServerWorldModeOpcode)value.Command;
    }

    public static implicit operator ServerModeMazeOpcode(Opcode value)
    {
        return (ServerModeMazeOpcode)value.Command;
    }

    public static bool operator ==(Opcode left, Opcode right)
    {
        return left.Value == right.Value;
    }

    public static bool operator !=(Opcode left, Opcode right)
    {
        return left.Value != right.Value;
    }

    #endregion Operators

    #region Constructors

    public Opcode(BinaryReader reader)
    {
        Value = reader.ReadUInt16();
    }

    public Opcode(byte group, byte command)
    {
        (Group, Command) = (group, command);
    }

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

    public override string ToString() => $"{Group:X2}:{Command:X2}";

    public override bool Equals(object? obj) => obj is Opcode opcode && Value == opcode.Value;

    public override int GetHashCode() => HashCode.Combine(Value);

    #endregion Overrides
}
