using SoulCore.IO.Network.Commands;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = true)]
    public sealed class ResponseAttribute : Attribute
    {
        public readonly CategoryCommand Category;
        public readonly byte Command;

        internal ResponseAttribute(CategoryCommand category, SystemCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, LoginCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, CharacterCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, WorldCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, MoveCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, SkillCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ChatCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ItemCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ShopCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, TradeCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, MazeCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, PartyCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ItemUpgradeCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, DropCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, QuestCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, OptionCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, MonsterCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ItemSetupCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, FriendCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, PostCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, SoulMetryCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, LeagueCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, GestureCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, DailyMissionCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, VaccumCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, MyRoomCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, HelperCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, InfiniteTowerCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, BoosterCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, EventCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ExchangeCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, RankingCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, SocialItemCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ForceCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, WorldModeCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, WeeklyMissionCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ModeMazeCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, RestartCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ToolCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ChannelCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ServerCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ServerUserCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ServerPartyCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ServerFriendCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ServerLeagueCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, MonitorCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, GmAgentCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ServerForceCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ServerWorldModeCommand command) : this(category, (byte)command)
        {
        }

        internal ResponseAttribute(CategoryCommand category, ServerModeMazeCommand command) : this(category, (byte)command)
        {
        }

        private ResponseAttribute(CategoryCommand category, byte command)
        {
            Category = category;
            Command = command;
        }
    }
}