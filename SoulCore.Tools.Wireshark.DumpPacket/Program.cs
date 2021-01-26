using SoulCore.Tools.Wireshark.Reader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SoulCore.Tools.Wireshark.DumpPacket
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            IEnumerable<IEnumerable<RawPacket>> splitteds = await JsonFile.Read(args[0]).ConfigureAwait(false);

            await using FileStream fs = File.Open("packet.bin", FileMode.Create, FileAccess.Write);
            foreach (IEnumerable<RawPacket> packets in splitteds)
            {
                HashSet<ulong> written = new();

                foreach (RawPacket packet in packets)
                {
                    await HierarchyWrite(packet, packets, written, fs).ConfigureAwait(false);
                }
            }

            Console.WriteLine("Hello World!");
        }

        private static async Task HierarchyWrite(RawPacket packet, IEnumerable<RawPacket> packets, HashSet<ulong> written, FileStream fs)
        {
            if (!written.Add(packet.Frame))
            {
                return;
            }

            Console.WriteLine($"[ #{packet.Frame,4} ] streamId: {packet.StreamId,3} | seqId: {packet.StreamSeqId,6} | nxtSeqId: {packet.StreamNextSeqId,6}");

            await fs.WriteAsync(packet.Payload).ConfigureAwait(false);
            await HierarchyWrite(packets.First(s => s.StreamSeqId == packet.StreamNextSeqId), packets, written, fs).ConfigureAwait(false);
        }
    }
}