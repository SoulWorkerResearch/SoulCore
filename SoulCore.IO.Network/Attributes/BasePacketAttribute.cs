using SoulCore.IO.Network.Commands;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = true)]
    public abstract class BasePacketAttribute : Attribute
    {
        public readonly CategoryCommand Category;
        public readonly byte Command;

        protected BasePacketAttribute(CategoryCommand category, SystemCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, LoginCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, CharacterCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, WorldCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, MoveCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, SkillCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ChatCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ItemCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ShopCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, TradeCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, MazeCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, PartyCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ItemUpgradeCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, DropCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, QuestCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, OptionCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, MonsterCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ItemSetupCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, FriendCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, PostCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, SoulMetryCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, LeagueCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, GestureCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, DailyMissionCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, VaccumCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, MyRoomCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, HelperCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, InfiniteTowerCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, BoosterCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, EventCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ExchangeCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, RankingCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, SocialItemCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ForceCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, WorldModeCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, WeeklyMissionCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ModeMazeCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, RestartCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ToolCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ChannelCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ServerCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ServerUserCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ServerPartyCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ServerFriendCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ServerLeagueCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, MonitorCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, GmAgentCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ServerForceCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ServerWorldModeCommand command) : this(category, (byte)command)
        {
        }

        protected BasePacketAttribute(CategoryCommand category, ServerModeMazeCommand command) : this(category, (byte)command)
        {
        }

        private BasePacketAttribute(CategoryCommand category, byte command) => (Category, Command) = (category, command);
    }
}