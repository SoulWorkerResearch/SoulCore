using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Permissions;
using SoulCore.IO.Network.Types;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class SyncHandlerAttribute : Attribute
    {
        internal readonly CategoryCommand Category;
        internal readonly byte Command;
        internal readonly Type ServerType;
        internal readonly HandlerPermission Permission;
        internal readonly SyncServerType Service;

        public SyncHandlerAttribute(CategoryCommand category, SystemCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, LoginCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, CharacterCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, WorldCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, MoveCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, SkillCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ChatCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ItemCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ShopCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, TradeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, MazeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, PartyCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ItemUpgradeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, DropCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, QuestCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, OptionCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, MonsterCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ItemSetupCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, FriendCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, PostCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, SoulMetryCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, LeagueCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, GestureCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, DailyMissionCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, VaccumCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, MyRoomCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, HelperCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, InfiniteTowerCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, BoosterCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, EventCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ExchangeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, RankingCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, SocialItemCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ForceCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, WorldModeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, WeeklyMissionCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ModeMazeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, RestartCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ToolCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ChannelCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ServerCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ServerUserCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ServerPartyCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ServerFriendCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ServerLeagueCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, MonitorCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, GmAgentCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ServerForceCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ServerWorldModeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        public SyncHandlerAttribute(CategoryCommand category, ServerModeMazeCommand command, Type serverType, SyncServerType service = SyncServerType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, serverType, service, permission)
        {
        }

        private SyncHandlerAttribute(CategoryCommand category, byte command, Type serverType, SyncServerType service, HandlerPermission permission)
        {
            Category = category;
            Command = command;
            ServerType = serverType;
            Service = service;
            Permission = permission;
        }
    }
}