using SoulCore.IO.Network;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Utils;
using SoulCore.Tools.Wireshark.Reader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulCore.Tools.Wireshark.JsonDumpDecode
{
    public sealed partial class PacketDecoder
    {
        public static async Task DoIt(string[] args)
        {
            string inputFilePath = args[0];
            string outputFilePath = args[1];
            string clientIp = args[2];

            await using FileStream fs = File.Open(outputFilePath, FileMode.Create, FileAccess.Write);

            List<Packet>? justPackets = await WriteSequenceAsync(inputFilePath).ConfigureAwait(false);
            foreach (var packet in justPackets)
            {
                await using MemoryStream ms = new(packet.Body);
                using BinaryReader br = new(ms);

                byte category = br.ReadByte();
                byte command = br.ReadByte();

                Messages.ExtracteOpcode(command, category);

                await DumpRow(category, command, fs, packet, clientIp).ConfigureAwait(false);

                await fs.WriteAsync(Encoding.ASCII.GetBytes($"{BitConverter.ToString(packet.Body).Replace('-', ' ')}\n\n")).ConfigureAwait(false);
            }
        }

        private static async Task DumpRow(byte category, byte command, FileStream fs, Packet packet, string clientIp)
        {
            (object, object) opcodes = DumpOpcode(category, command);

            if (clientIp == packet.Receiver)
            {
                await fs.WriteAsync(Encoding.ASCII.GetBytes($"{packet.Frame,4}   | [Server -> {opcodes.Item1}::{opcodes.Item2}] {packet.Time}: ")).ConfigureAwait(false);
                await fs.WriteAsync(Encoding.ASCII.GetBytes($"[{packet.Sender}] ---> [{packet.Receiver}]\n")).ConfigureAwait(false);
            }
            else
            {
                await fs.WriteAsync(Encoding.ASCII.GetBytes($"{packet.Frame,4}   | [Client -> {opcodes.Item1}::{opcodes.Item2}] {packet.Time}: ")).ConfigureAwait(false);
                await fs.WriteAsync(Encoding.ASCII.GetBytes($"[{packet.Receiver}] <--- [{packet.Sender}]\n")).ConfigureAwait(false);
            }
        }

        private static (object, object) DumpOpcode(byte category, byte command)
        {
            if (!Enum.IsDefined(typeof(CategoryCommand), category))
            {
                return ("???", "???");
            }

            if (!_commands.TryGetValue(category, out Type? type))
            {
                return ((CategoryCommand)category, "???");
            }

            var name = Enum.GetName(type, command);
            if (name is null)
            {
                return ((CategoryCommand)category, "???");
            }

            return ((CategoryCommand)category, name);
        }

        private static async Task<List<Packet>> WriteSequenceAsync(string inputFilePath)
        {
            IEnumerable<IEnumerable<RawPacket>> splitteds = await JsonFile.Read(inputFilePath).ConfigureAwait(false);

            List<Packet> justPackets = new(splitteds.Select(s => s.Count()).Sum());

            HashSet<ulong> written = new();

            foreach (var rawPackets in splitteds)
            {
                foreach (var rawPacket in rawPackets)
                {
                    await using MemoryStream ms = new(ushort.MaxValue);

                    await HierarchyWrite(rawPacket, rawPackets, written, ms).ConfigureAwait(false);

                    if (ms.Length <= 0)
                    {
                        continue;
                    }

                    ms.Position = 0;
                    using BinaryReader br = new(ms);

                    PacketHeader packet = new(br);

                    byte[] buffer = br.ReadBytes(packet.Size - Defines.PacketHeaderSize);
                    PacketUtils.Exchange(ref buffer);

                    justPackets.Add(new()
                    {
                        Frame = rawPacket.Frame,
                        Receiver = rawPacket.DstIp,
                        Sender = rawPacket.SrcIp,
                        Time = rawPacket.RelativeTime,
                        Body = buffer
                    });
                }
            }

            return justPackets;
        }

        private static async Task HierarchyWrite(RawPacket packet, IEnumerable<RawPacket> packets, HashSet<ulong> written, MemoryStream fs)
        {
            if (!written.Add(packet.Frame))
            {
                return;
            }

            await fs.WriteAsync(packet.Payload).ConfigureAwait(false);
            await HierarchyWrite(packets.First(s => s.StreamSeqId == packet.StreamNextSeqId), packets, written, fs).ConfigureAwait(false);
        }

        private static readonly Dictionary<byte, Type> _commands = new()
        {
            { (byte)CategoryCommand.System, typeof(SystemCommand) },
            { (byte)CategoryCommand.Login, typeof(LoginCommand) },
            { (byte)CategoryCommand.Character, typeof(CharacterCommand) },
            { (byte)CategoryCommand.World, typeof(WorldCommand) },
            { (byte)CategoryCommand.Move, typeof(MoveCommand) },
            { (byte)CategoryCommand.Skill, typeof(SkillCommand) },
            { (byte)CategoryCommand.Chat, typeof(ChatCommand) },
            { (byte)CategoryCommand.Item, typeof(ItemCommand) },
            { (byte)CategoryCommand.Shop, typeof(ShopCommand) },
            { (byte)CategoryCommand.Trade, typeof(TradeCommand) },
            { (byte)CategoryCommand.Maze, typeof(MazeCommand) },
            { (byte)CategoryCommand.Party, typeof(PartyCommand) },
            { (byte)CategoryCommand.ItemUpgrade, typeof(ItemUpgradeCommand) },
            { (byte)CategoryCommand.Drop, typeof(DropCommand) },
            { (byte)CategoryCommand.Quest, typeof(QuestCommand) },
            { (byte)CategoryCommand.Option, typeof(OptionCommand) },
            { (byte)CategoryCommand.Monster, typeof(MonsterCommand) },
            { (byte)CategoryCommand.ItemSetup, typeof(ItemSetupCommand) },
            { (byte)CategoryCommand.Friend, typeof(FriendCommand) },
            { (byte)CategoryCommand.Post, typeof(PostCommand) },
            { (byte)CategoryCommand.SoulMetry, typeof(SoulMetryCommand) },
            { (byte)CategoryCommand.League, typeof(LeagueCommand) },
            { (byte)CategoryCommand.Gesture, typeof(GestureCommand) },
            { (byte)CategoryCommand.DailyMission, typeof(DailyMissionCommand) },
            { (byte)CategoryCommand.Vaccum, typeof(VaccumCommand) },
            { (byte)CategoryCommand.MyRoom, typeof(MyRoomCommand) },
            { (byte)CategoryCommand.Helper, typeof(HelperCommand) },
            { (byte)CategoryCommand.InfiniteTower, typeof(InfiniteTowerCommand) },
            { (byte)CategoryCommand.Booster, typeof(BoosterCommand) },
            { (byte)CategoryCommand.Event, typeof(EventCommand) },
            { (byte)CategoryCommand.Exchange, typeof(ExchangeCommand) },
            { (byte)CategoryCommand.Ranking, typeof(RankingCommand) },
            { (byte)CategoryCommand.SocialItem, typeof(SocialItemCommand) },
            { (byte)CategoryCommand.Force, typeof(ForceCommand) },
            { (byte)CategoryCommand.WorldMode, typeof(WorldModeCommand) },
            { (byte)CategoryCommand.WeeklyMission, typeof(WeeklyMissionCommand) },
            { (byte)CategoryCommand.ModeMaze, typeof(ModeMazeCommand) },
            { (byte)CategoryCommand.Restart, typeof(RestartCommand) },
            { (byte)CategoryCommand.Tool, typeof(ToolCommand) },
            { (byte)CategoryCommand.Channel, typeof(ChannelCommand) },
            { (byte)CategoryCommand.Server, typeof(ServerCommand) },
            { (byte)CategoryCommand.ServerUser, typeof(ServerUserCommand) },
            { (byte)CategoryCommand.ServerParty, typeof(ServerPartyCommand) },
            { (byte)CategoryCommand.ServerFriend, typeof(ServerFriendCommand) },
            { (byte)CategoryCommand.ServerLeague, typeof(ServerLeagueCommand) },
            { (byte)CategoryCommand.Monitor, typeof(MonitorCommand) },
            { (byte)CategoryCommand.GmAgent, typeof(GmAgentCommand) },
            { (byte)CategoryCommand.ServerForce, typeof(ServerForceCommand) },
            { (byte)CategoryCommand.ServerWorldMode, typeof(ServerWorldModeCommand) },
            { (byte)CategoryCommand.ServerModeMaze, typeof(ServerModeMazeCommand) },
        };
    }
}