using SoulCore.Tools.Wireshark.Reader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SoulCore.Tools.Wireshark.DumpPacket
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            IEnumerable<IEnumerable<RawPacket>> splitteds = await JsonFile.Read(args[0]).ConfigureAwait(false);

            await using FileStream fs = File.OpenWrite("packet.bin");

            foreach (IEnumerable<RawPacket> packets in splitteds)
            {
                foreach (RawPacket packet in packets)
                {
                    await fs.WriteAsync(packet.Payload).ConfigureAwait(false);
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}