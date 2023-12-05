using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Attributes;

[AttributeUsage(AttributeTargets.Struct)]
public sealed class ClientMessageAttribute : BaseMessageAttribute
{
    public ClientMessageAttribute(byte group, byte command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, SystemOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, LoginOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, CharacterOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, WorldOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, MoveOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, SkillOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ChatOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ItemOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ShopOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, TradeOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, MazeOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, PartyOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ItemUpgradeOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, DropOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, QuestOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, OptionOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, MonsterOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ItemSetupOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, FriendOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, PostOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, SoulMetryOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, LeagueOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, GestureOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, DailyMissionOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, VaccumOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, MyRoomOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, HelperOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, InfiniteTowerOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, BoosterOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, EventOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ExchangeOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, RankingOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, SocialItemOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ForceOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, WorldModeOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, WeeklyMissionOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ModeMazeOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, RestartOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ToolOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ChannelOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ServerOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ServerUserOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ServerPartyOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ServerFriendOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ServerLeagueOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, MonitorOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, GmAgentOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ServerForceOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ServerWorldModeOpcode command) : base(group, command)
    {
    }

    public ClientMessageAttribute(GroupOpcode group, ServerModeMazeOpcode command) : base(group, command)
    {
    }
}
