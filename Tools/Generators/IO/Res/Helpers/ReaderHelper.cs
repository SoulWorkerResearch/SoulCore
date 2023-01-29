using System.Text;

namespace SoulWorkerResearch.SoulCore.Tools.Generators.IO.Res.Helpers;

internal static class ReaderHelper
{
    internal static async Task GenerateReaders(string path, IEnumerable<string> names, CancellationToken ct = default)
    {
        var builder = new StringBuilder();

        builder.AppendLine("using ICSharpCode.SharpZipLib.Zip;");
        builder.AppendLine("using SoulWorkerResearch.SoulCore.IO.Res.Entries;");
        builder.AppendLine("");
        builder.AppendLine("namespace SoulWorkerResearch.SoulCore.IO.Res;");
        builder.AppendLine("");
        builder.AppendLine("public sealed class TableReader : ArchiveReader");
        builder.AppendLine("{");

        foreach (var name in names)
        {
            builder.AppendFormat("    public IAsyncEnumerable<{0}Entry> Read{0}TableAsync(CancellationToken ct = default) =>", name);
            builder.AppendLine();
            builder.AppendFormat("        ReadEntriesAsync<{0}Entry>(ct);", name);
            builder.AppendLine();
            builder.AppendLine("");
        }

        builder.AppendLine("    public TableReader(ZipFile zip) : base(zip) { }");
        builder.AppendLine(" }");

        await File.WriteAllTextAsync(Path.Join(path, "TableReader.cs"), builder.ToString(), ct);
    }
}
