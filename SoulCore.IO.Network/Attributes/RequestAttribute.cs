using SoulCore.IO.Network.Commands;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Struct)]
    public sealed class RequestAttribute : Attribute
    {
        public readonly CategoryCommand Category;
        public readonly byte Command;

        internal RequestAttribute(CategoryCommand category, SystemCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, LoginCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, CharacterCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, WorldCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, MoveCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, SkillCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ChatCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ItemCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ShopCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, TradeCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, MazeCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, PartyCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ItemUpgradeCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, DropCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, QuestCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, OptionCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, MonsterCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ItemSetupCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, FriendCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, PostCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, SoulMetryCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, LeagueCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, GestureCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, DailyMissionCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, VaccumCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, MyRoomCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, HelperCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, InfiniteTowerCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, BoosterCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, EventCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ExchangeCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, RankingCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, SocialItemCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ForceCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, WorldModeCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, WeeklyMissionCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ModeMazeCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, RestartCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ToolCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ChannelCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ServerCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ServerUserCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ServerPartyCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ServerFriendCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ServerLeagueCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, MonitorCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, GmAgentCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ServerForceCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ServerWorldModeCommand command) : this(category, (byte)command)
        {
        }

        internal RequestAttribute(CategoryCommand category, ServerModeMazeCommand command) : this(category, (byte)command)
        {
        }

        private RequestAttribute(CategoryCommand category, byte command)
        {
            Category = category;
            Command = command;
        }
    }
}