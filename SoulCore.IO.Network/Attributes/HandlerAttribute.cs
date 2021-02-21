using SoulCore.IO.Network.Commands;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class HandlerAttribute : Attribute
    {
        internal readonly CategoryCommand Category;
        internal readonly byte Command;

        public HandlerAttribute(CategoryCommand category, SystemCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, LoginCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, CharacterCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, MoveCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, SkillCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChatCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ShopCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, TradeCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, MazeCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, PartyCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemUpgradeCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, DropCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, QuestCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, OptionCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonsterCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemSetupCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, FriendCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, PostCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, SoulMetryCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, LeagueCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, GestureCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, DailyMissionCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, VaccumCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, MyRoomCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, HelperCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, InfiniteTowerCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, BoosterCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, EventCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ExchangeCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, RankingCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, SocialItemCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ForceCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldModeCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, WeeklyMissionCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ModeMazeCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, RestartCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ToolCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChannelCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerUserCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerPartyCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerFriendCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerLeagueCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonitorCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, GmAgentCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerForceCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerWorldModeCommand command) : this(category, (byte)command)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerModeMazeCommand command) : this(category, (byte)command)
        {
        }

        private HandlerAttribute(CategoryCommand category, byte command)
        {
            Category = category;
            Command = command;
        }
    }
}