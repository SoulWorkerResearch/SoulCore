using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SoulCore.Tools.Wireshark.Reader
{
    public static class JsonFile
    {
        public static async Task<IEnumerable<IEnumerable<RawPacket>>> Read(string path)
        {
            await using FileStream inputFile = new(path, FileMode.Open, FileAccess.Read, FileShare.Read);

            using JsonDocument json = JsonDocument.Parse(inputFile);
            using JsonElement.ArrayEnumerator enumerator = json.RootElement.EnumerateArray();

            IEnumerable<RawPacket> rawPackets = enumerator
                .Select(element =>
                {
                    if (!element.TryGetProperty("_source", out JsonElement source))
                        throw new ReaderException();

                    if (!source.TryGetProperty("layers", out JsonElement layers))
                        throw new ReaderException();

                    if (!layers.TryGetProperty("tcp", out JsonElement tcp))
                        throw new ReaderException();

                    if (!layers.TryGetProperty("frame", out JsonElement frame))
                        throw new ReaderException();

                    if (!frame.TryGetProperty("frame.number", out JsonElement frameNumber))
                        throw new ReaderException();

                    if (!layers.TryGetProperty("ip", out JsonElement ip))
                        throw new ReaderException();

                    if (!ip.TryGetProperty("ip.dst_host", out JsonElement dstHost))
                        throw new ReaderException();

                    if (!ip.TryGetProperty("ip.src_host", out JsonElement srcHost))
                        throw new ReaderException();

                    if (!frame.TryGetProperty("frame.time_relative", out JsonElement timeRelativeElement))
                        throw new ReaderException();

                    if (!tcp.TryGetProperty("tcp.payload", out JsonElement payload))
                        return null;

                    return new RawPacket()
                    {
                        Frame = frameNumber.GetString() ?? "",
                        DstIp = dstHost.GetString() ?? "",
                        SrcIp = srcHost.GetString() ?? "",
                        RelativeTime = timeRelativeElement.GetString() ?? "",
                        Payload = Convert.FromHexString(payload.GetString()?.Where(s => s != ':').ToArray() ?? Array.Empty<char>())
                    };
                })
                .Where(s => s is not null)
                .Cast<RawPacket>()
                .ToArray();

            IEnumerable<string> keys = rawPackets.Select(s => $"{s.DstIp}-{s.SrcIp}").Distinct();

            return keys.Select(k =>
            {
                string[] ips = k.Split('-');
                return rawPackets.Where(s => s.DstIp == ips[0] && s.SrcIp == ips[1]);
            });
        }
    }
}