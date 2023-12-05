using System.Diagnostics;
using System.Runtime.CompilerServices;
using ICSharpCode.SharpZipLib.Zip;

namespace SoulWorkerResearch.SoulCore.IO.ResTable;

public class ArchiveReader
{
    private readonly ZipFile _zip;

    private async IAsyncEnumerable<BinaryReader> ReadAllAsync(string table, [EnumeratorCancellation] CancellationToken ct)
    {
        var entry = _zip.GetEntry($"../bin/Table/{table}.res");

        Debug.Assert(entry is not null);
        Debug.Assert(entry.IsFile);

        await using var stream = _zip.GetInputStream(entry);
        using var reader = new BinaryReader(stream);

        for (uint q = 0, count = reader.ReadUInt32(); q < count || ct.IsCancellationRequested; ++q)
        {
            yield return reader;
        }
    }

    public async IAsyncEnumerable<TValue> ReadEntriesAsync<TValue>([EnumeratorCancellation] CancellationToken ct)
        where TValue : class, IEntry<TValue>
    {
        await foreach (var reader in ReadAllAsync(TValue.TableName, ct))
        {
            if (ct.IsCancellationRequested)
            {
                yield break;
            }

            yield return TValue.CreateInstance(reader);
        }
    }

    public ArchiveReader(ZipFile zip) => _zip = zip;
}
