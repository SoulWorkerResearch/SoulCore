using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.IO.Network.Permissions;
using SoulWorkerResearch.SoulCore.IO.Network.Types;
using System;

namespace SoulWorkerResearch.SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class HandlerAttribute : Attribute
    {
        internal readonly CategoryCommand Category;
        internal readonly byte Command;
        internal readonly Type ServerType;
        internal readonly HandlerPermission Permission;
        internal readonly SyncServerType Service;

        public HandlerAttribute(CategoryCommand category, SystemCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, LoginCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, CharacterCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MoveCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SkillCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChatCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ShopCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, TradeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MazeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, PartyCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemUpgradeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, DropCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, QuestCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, OptionCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonsterCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemSetupCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, FriendCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, PostCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SoulMetryCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, LeagueCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, GestureCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, DailyMissionCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, VaccumCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MyRoomCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, HelperCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, InfiniteTowerCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, BoosterCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, EventCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ExchangeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, RankingCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SocialItemCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ForceCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldModeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WeeklyMissionCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ModeMazeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, RestartCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ToolCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChannelCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerUserCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerPartyCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerFriendCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerLeagueCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonitorCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, GmAgentCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerForceCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerWorldModeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerModeMazeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        private HandlerAttribute(CategoryCommand category, byte command, Type serverType, SyncServerType service, HandlerPermission permission)
        {
            Category = category;
            Command = command;
            ServerType = serverType;
            Service = service;
            Permission = permission;
        }
    }
}
