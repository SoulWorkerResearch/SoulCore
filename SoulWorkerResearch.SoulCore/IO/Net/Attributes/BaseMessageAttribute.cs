using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Attributes;

public abstract class BaseMessageAttribute : Attribute
{
    public Opcode Opcode { get; }

    public BaseMessageAttribute(byte group, byte command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, SystemOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, LoginOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, CharacterOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, WorldOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, MoveOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, SkillOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ChatOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ItemOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ShopOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, TradeOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, MazeOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, PartyOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ItemUpgradeOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, DropOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, QuestOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, OptionOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, MonsterOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ItemSetupOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, FriendOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, PostOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, SoulMetryOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, LeagueOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, GestureOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, DailyMissionOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, VaccumOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, MyRoomOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, HelperOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, InfiniteTowerOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, BoosterOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, EventOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ExchangeOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, RankingOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, SocialItemOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ForceOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, WorldModeOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, WeeklyMissionOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ModeMazeOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, RestartOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ToolOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ChannelOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ServerOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ServerUserOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ServerPartyOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ServerFriendOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ServerLeagueOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, MonitorOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, GmAgentOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ServerForceOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ServerWorldModeOpcode command) => Opcode = new Opcode(group, command);
    public BaseMessageAttribute(GroupOpcode group, ServerModeMazeOpcode command) => Opcode = new Opcode(group, command);
}
