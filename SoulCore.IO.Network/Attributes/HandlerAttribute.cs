using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Permissions;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class HandlerAttribute : Attribute
    {
        internal readonly HandlerPermission Permission;
        internal readonly CategoryCommand Category;
        internal readonly byte Command;

        public HandlerAttribute(CategoryCommand category, SystemCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, LoginCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, CharacterCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MoveCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SkillCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChatCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ShopCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, TradeCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MazeCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, PartyCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemUpgradeCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, DropCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, QuestCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, OptionCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonsterCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemSetupCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, FriendCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, PostCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SoulMetryCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, LeagueCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, GestureCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, DailyMissionCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, VaccumCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MyRoomCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, HelperCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, InfiniteTowerCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, BoosterCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, EventCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ExchangeCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, RankingCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SocialItemCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ForceCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldModeCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WeeklyMissionCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ModeMazeCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, RestartCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ToolCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChannelCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerUserCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerPartyCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerFriendCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerLeagueCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonitorCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, GmAgentCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerForceCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerWorldModeCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerModeMazeCommand command, HandlerPermission permission = HandlerPermission.Authorized) : this(category, (byte)command, permission)
        {
        }

        private HandlerAttribute(CategoryCommand category, byte command, HandlerPermission permission)
        {
            Category = category;
            Command = command;
            Permission = permission;
        }
    }
}