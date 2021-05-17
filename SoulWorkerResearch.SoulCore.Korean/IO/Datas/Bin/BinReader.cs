using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using ICSharpCode.SharpZipLib.Zip;
using SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table;
using SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table.Entities;
using SoulWorkerResearch.SoulCore.Types;
using SoulWorkerResearch.SoulCore.Vision;

namespace SoulWorkerResearch.SoulCore.Korean.IO.Datas.Bin
{
    public sealed class BinReader : IDisposable
    {
        public IEnumerable<ClassSelectInfoEntity> ReadClassSelectInfoTable(CancellationToken cancellationToken = default) =>
            Read<Class, ClassSelectInfoEntity>(_file, cancellationToken);

        public IEnumerable<CustomizeSkinEntity> ReadCustomizeSkinTable(CancellationToken cancellationToken = default) =>
            Read<Class, CustomizeSkinEntity>(_file, cancellationToken);

        public IEnumerable<CustomizeEyesEntity> ReadCustomizeEyesTable(CancellationToken cancellationToken = default) =>
            Read<Class, CustomizeEyesEntity>(_file, cancellationToken);

        public IEnumerable<CustomizeHairEntity> ReadCustomizeHairTable(CancellationToken cancellationToken = default) =>
            Read<Class, CustomizeHairEntity>(_file, cancellationToken);

        public IEnumerable<CustomizeInfoEntity> ReadCustomizeInfoTable(CancellationToken cancellationToken = default) =>
            Read<Class, CustomizeInfoEntity>(_file, cancellationToken);

        public IEnumerable<CharacterBackgroundEntity> ReadCharacterBackgroundTable(CancellationToken cancellationToken = default) =>
            Read<uint, CharacterBackgroundEntity>(_file, cancellationToken);

        public IEnumerable<DistrictEntity> ReadDistrictTable(CancellationToken cancellationToken = default) =>
            Read<ushort, DistrictEntity>(_file, cancellationToken);

        public IEnumerable<ItemEntity> ReadItemTable(CancellationToken cancellationToken = default) =>
            Read<uint, ItemEntity>(_file, cancellationToken);

        public IEnumerable<ItemClassifyEntity> ReadItemClassifyTable(CancellationToken cancellationToken = default) =>
            Read<uint, ItemClassifyEntity>(_file, cancellationToken);

        public IEnumerable<ItemScriptEntity> ReadItemScriptTable(CancellationToken cancellationToken = default) =>
            Read<uint, ItemScriptEntity>(_file, cancellationToken);

        public IEnumerable<CharacterInfoEntity> ReadCharacterInfoTable(CancellationToken cancellationToken = default) =>
            Read<ushort, CharacterInfoEntity>(_file, cancellationToken);

        public IEnumerable<PhotoItemEntity> ReadPhotoItemTable(CancellationToken cancellationToken = default) =>
            Read<uint, PhotoItemEntity>(_file, cancellationToken);

        public IEnumerable<GestureEntity> ReadGestureTable(CancellationToken cancellationToken = default) =>
            Read<ushort, GestureEntity>(_file, cancellationToken);

        public IEnumerable<MazeInfoEntity> ReadMazeInfoTable(CancellationToken cancellationToken = default) =>
            Read<ushort, MazeInfoEntity>(_file, cancellationToken);

        public IEnumerable<BoosterEntity> ReadBoosterTable(CancellationToken cancellationToken = default) =>
            Read<ushort, BoosterEntity>(_file, cancellationToken);

        public IEnumerable<NpcEntity> ReadNpcTable(CancellationToken cancellationToken = default) =>
            Read<uint, NpcEntity>(_file, cancellationToken);

        public IEnumerable<PassInfoEntity> ReadPassInfoTable(CancellationToken cancellationToken = default) =>
            Read<uint, PassInfoEntity>(_file, cancellationToken);

        public IEnumerable<PassRewardInfoEntity> ReadPassRewardInfoTable(CancellationToken cancellationToken = default) =>
            Read<uint, PassRewardInfoEntity>(_file, cancellationToken);

        public void Dispose()
        {
            ((IDisposable) _file).Dispose();
        }

        public BinReader(string path, string password, byte xor = 0x55)
        {
            _file = new ZipArchive(path, password, xor);
        }

        public BinReader(ZipFile file)
        {
            _file = file;
        }

        private static IEnumerable<TItem> Read<TId, TItem>(ZipFile data, CancellationToken cancellationToken = default)
            where TId : struct
            where TItem : ITableEntity<TId>
        {
            var type = typeof(TItem);
            var name = type.GetCustomAttribute<TableAttribute>()?.Name ?? throw new ApplicationException();

            foreach (BinaryReader br in GetEntries(data, name, cancellationToken))
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                yield return (TItem)CreateInstance(br, type);
            }
        }

        private static object CreateInstance(BinaryReader br, Type type) =>
            Activator.CreateInstance(type, br) ?? throw new ApplicationException();

        private static IEnumerable<BinaryReader> GetEntries(ZipFile data, string file, CancellationToken cancellationToken = default)
        {
            using BinaryReader br = new(data.GetInputStream(data.GetEntry($"../bin/Table/{file}.res")));

            for (uint q = 0, count = br.ReadUInt32(); q < count; ++q)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }
                
                yield return br;
            }
        }

        private readonly ZipFile _file;
    }
}