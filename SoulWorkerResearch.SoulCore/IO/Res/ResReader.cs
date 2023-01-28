using ICSharpCode.SharpZipLib.Zip;
using SoulWorkerResearch.SoulCore.IO.Res.Entries;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SoulWorkerResearch.SoulCore.IO.Res;

public sealed class ResReader : IDisposable
{
    #region Methods

    public IAsyncEnumerable<ClassSelectInfoEntry> ReadClassSelectInfoTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<ClassSelectInfoKeyType, ClassSelectInfoEntry>(ClassSelectInfoEntry.TableName, ct);

    public IAsyncEnumerable<ChattingCommandEntry> ReadChattingCommandTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<ChattingCommandKeyType, ChattingCommandEntry>(ChattingCommandEntry.TableName, ct);

    public IAsyncEnumerable<ItemCountBoxEntry> ReadItemCountBoxTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<ItemCountBoxKeyType, ItemCountBoxEntry>(ItemCountBoxEntry.TableName, ct);

    public IAsyncEnumerable<CustomizeSkinEntry> ReadCustomizeSkinTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<CustomizeSkinKeyType, CustomizeSkinEntry>(CustomizeSkinEntry.TableName, ct);

    public IAsyncEnumerable<CustomizeEyesEntry> ReadCustomizeEyesTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<CustomizeEyesKeyType, CustomizeEyesEntry>(CustomizeEyesEntry.TableName, ct);

    public IAsyncEnumerable<CustomizeHairEntry> ReadCustomizeHairTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<CustomizeHairKeyType, CustomizeHairEntry>(CustomizeHairEntry.TableName, ct);

    public IAsyncEnumerable<CustomizeInfoEntry> ReadCustomizeInfoTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<CustomizeInfoKeyType, CustomizeInfoEntry>(CustomizeInfoEntry.TableName, ct);

    public IAsyncEnumerable<CharacterBackgroundEntry> ReadCharacterBackgroundTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<CharacterBackgroundKeyType, CharacterBackgroundEntry>(CharacterBackgroundEntry.TableName, ct);

    public IAsyncEnumerable<DistrictEntry> ReadDistrictTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<DistrictKeyType, DistrictEntry>(DistrictEntry.TableName, ct);

    public IAsyncEnumerable<ItemEntry> ReadItemTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<ItemKeyType, ItemEntry>(ItemEntry.TableName, ct);

    public IAsyncEnumerable<ItemClassifyEntry> ReadItemClassifyTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<ItemClassifyKeyType, ItemClassifyEntry>(ItemClassifyEntry.TableName, ct);

    public IAsyncEnumerable<ItemScriptEntry> ReadItemScriptTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<ItemScriptKeyType, ItemScriptEntry>(ItemScriptEntry.TableName, ct);

    public IAsyncEnumerable<CharacterInfoEntry> ReadCharacterInfoTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<CharacterInfoKeyType, CharacterInfoEntry>(CharacterInfoEntry.TableName, ct);

    public IAsyncEnumerable<PhotoItemEntry> ReadPhotoItemTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<PhotoItemKeyType, PhotoItemEntry>(PhotoItemEntry.TableName, ct);

    public IAsyncEnumerable<GestureEntry> ReadGestureTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<GestureKeyType, GestureEntry>(GestureEntry.TableName, ct);

    public IAsyncEnumerable<MazeInfoEntry> ReadMazeInfoTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<MazeInfoKeyType, MazeInfoEntry>(MazeInfoEntry.TableName, ct);

    public IAsyncEnumerable<BoosterEntry> ReadBoosterTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<BoosterKeyType, BoosterEntry>(BoosterEntry.TableName, ct);

    public IAsyncEnumerable<NpcEntry> ReadNpcTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<NpcKeyType, NpcEntry>(NpcEntry.TableName, ct);

    public IAsyncEnumerable<PassInfoEntry> ReadPassInfoTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<PassInfoKeyType, PassInfoEntry>(PassInfoEntry.TableName, ct);

    public IAsyncEnumerable<PassRewardEntry> ReadPassRewardInfoTableAsync(CancellationToken ct = default) =>
        CreateEntriesAsync<PassRewardKeyType, PassRewardEntry>(PassRewardEntry.TableName, ct);

    #endregion Methods

    #region Constructors

    public ResReader(ZipFile zip) => _zip = zip;

    #endregion Constructors

    #region IDisposable

    public void Dispose() => (_zip as IDisposable).Dispose();

    #endregion IDisposable

    #region Private Methods

    private async IAsyncEnumerable<TValue> CreateEntriesAsync<TKey, TValue>(string table, [EnumeratorCancellation] CancellationToken ct) where TKey : struct where TValue : ITableEntry<TKey>
    {
        await foreach (var reader in ReadAllAsync(table, ct))
        {
            if (ct.IsCancellationRequested) yield break;
            yield return CreateEntry<TValue>(reader);
        }
    }

    private async IAsyncEnumerable<BinaryReader> ReadAllAsync(string table, [EnumeratorCancellation] CancellationToken ct)
    {
        var entry = _zip.GetEntry($"../bin/Table/{table}.res");

        await using var stream = _zip.GetInputStream(entry);
        using var reader = new BinaryReader(stream);

        for (uint q = 0, count = reader.ReadUInt32(); q < count && ct.IsCancellationRequested; ++q)
            yield return reader;
    }

    #endregion Private Methods

    #region Private Static Methods

    private static TValue CreateEntry<TValue>(BinaryReader reader)
    {
        Debug.Assert(typeof(TValue).GetConstructor(new Type[] { reader.GetType() }) is not null);
        var instance = Activator.CreateInstance(typeof(TValue), new object[] { reader });

        Debug.Assert(instance is not null);
        Debug.Assert(instance is not TValue);

        return (TValue)instance;
    }

    #endregion Private Static Methods

    #region Private Fields

    private readonly ZipFile _zip;

    #endregion Private Fields
}
