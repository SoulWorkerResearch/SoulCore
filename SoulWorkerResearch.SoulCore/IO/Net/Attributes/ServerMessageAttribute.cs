using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Attributes;

[AttributeUsage(AttributeTargets.Struct)]
public sealed class ServerMessageAttribute : BaseMessageAttribute
{
    public ServerMessageAttribute(byte group, byte command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, SystemOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, LoginOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, CharacterOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, WorldOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, MoveOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, SkillOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ChatOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ItemOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ShopOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, TradeOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, MazeOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, PartyOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ItemUpgradeOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, DropOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, QuestOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, OptionOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, MonsterOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ItemSetupOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, FriendOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, PostOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, SoulMetryOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, LeagueOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, GestureOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, DailyMissionOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, VaccumOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, MyRoomOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, HelperOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, InfiniteTowerOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, BoosterOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, EventOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ExchangeOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, RankingOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, SocialItemOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ForceOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, WorldModeOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, WeeklyMissionOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ModeMazeOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, RestartOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ToolOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ChannelOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ServerOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ServerUserOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ServerPartyOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ServerFriendOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ServerLeagueOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, MonitorOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, GmAgentOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ServerForceOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ServerWorldModeOpcode command) : base(group, command) { }
    public ServerMessageAttribute(GroupOpcode group, ServerModeMazeOpcode command) : base(group, command) { }
}
