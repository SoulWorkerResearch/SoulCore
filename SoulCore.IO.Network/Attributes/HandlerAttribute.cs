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
        internal readonly ServiceType Service;
        internal readonly CategoryCommand Category;
        internal readonly byte Command;

        public HandlerAttribute(CategoryCommand category, SystemCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, LoginCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, CharacterCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MoveCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SkillCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChatCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ShopCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, TradeCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MazeCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, PartyCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemUpgradeCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, DropCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, QuestCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, OptionCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonsterCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ItemSetupCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, FriendCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, PostCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SoulMetryCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, LeagueCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, GestureCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, DailyMissionCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, VaccumCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MyRoomCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, HelperCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, InfiniteTowerCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, BoosterCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, EventCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ExchangeCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, RankingCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, SocialItemCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ForceCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WorldModeCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, WeeklyMissionCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ModeMazeCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, RestartCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ToolCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ChannelCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerUserCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerPartyCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerFriendCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerLeagueCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, MonitorCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, GmAgentCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerForceCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerWorldModeCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        public HandlerAttribute(CategoryCommand category, ServerModeMazeCommand command, ServiceType service = ServiceType.None, HandlerPermission permission = HandlerPermission.Authorized) :
            this(category, (byte)command, service, permission)
        {
        }

        private HandlerAttribute(CategoryCommand category, byte command, ServiceType service, HandlerPermission permission)
        {
            Category = category;
            Command = command;
            Service = service;
            Permission = permission;
        }
    }
}