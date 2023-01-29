using SoulWorkerResearch.SoulCore.Tools.Generators.IO.Res.Helpers;
using System.Text.Json;

await using var raw = File.OpenRead("structure.json");

var structures = await JsonSerializer.DeserializeAsync<IReadOnlyDictionary<string, IReadOnlyList<string>>>(raw);
ArgumentNullException.ThrowIfNull(structures);

var entriesDir = Path.Join("..", "..", "..", "..", "..", "..", "..", "SoulWorkerResearch.SoulCore", "IO", "Res", "Entries");

if (Directory.Exists(entriesDir)) 
    Directory.Delete(entriesDir, true);

Directory.CreateDirectory(entriesDir);

await Parallel.ForEachAsync(structures, async (table, ct) =>
{
    var (filename, types) = table;

    var shortClassName = StringHelper.NormalizeName(filename);

    await File.WriteAllTextAsync(Path.Join(entriesDir, $"{shortClassName}Entry.cs"), await ClassHelper.BodyFrom(shortClassName, filename, types), ct);
});

await ReaderHelper.GenerateReaders(Path.Join(entriesDir, ".."), structures.Select((table) =>
{
    var (filename, types) = table;

    return StringHelper.NormalizeName(filename);
}));
