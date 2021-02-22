using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Permissions;
using SoulCore.IO.Network.Types;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class HandlerAttribute : Attribute
    {
        internal readonly HandlerPermission Permission;
        internal readonly SyncServerType Service;
        internal readonly CategoryCommand Category;
        internal readonly byte Command;

        public HandlerAttribute(CategoryCommand category, SystemCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, LoginCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, CharacterCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MoveCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SkillCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChatCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ShopCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, TradeCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MazeCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, PartyCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemUpgradeCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, DropCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, QuestCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, OptionCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonsterCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemSetupCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, FriendCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, PostCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SoulMetryCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, LeagueCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, GestureCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, DailyMissionCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, VaccumCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MyRoomCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, HelperCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, InfiniteTowerCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, BoosterCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, EventCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ExchangeCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, RankingCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SocialItemCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ForceCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldModeCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WeeklyMissionCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ModeMazeCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, RestartCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ToolCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChannelCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerUserCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerPartyCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerFriendCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerLeagueCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonitorCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, GmAgentCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerForceCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerWorldModeCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerModeMazeCommand command, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        private HandlerAttribute(CategoryCommand category, byte command, SyncServerType service, HandlerPermission permission)
        {
            Category = category;
            Command = command;
            Service = service;
            Permission = permission;
        }
    }
}