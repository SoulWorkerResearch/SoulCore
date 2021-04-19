using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ICSharpCode.SharpZipLib.Zip;
using SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table;
using SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table.Entities;
using SoulWorkerResearch.SoulCore.Types;
using SoulWorkerResearch.SoulCore.Vision;

namespace SoulWorkerResearch.SoulCore.Korean.IO.Datas.Bin
{
    public sealed class BinReader : IDisposable
    {
        public IDictionary<Class, ClassSelectInfoEntity> ReadClassSelectInfoTable() =>
            Read<Class, ClassSelectInfoEntity>(_file);

        public IDictionary<Class, CustomizeSkinEntity> ReadCustomizeSkinTable() =>
            Read<Class, CustomizeSkinEntity>(_file);

        public IDictionary<Class, CustomizeEyesEntity> ReadCustomizeEyesTable() =>
            Read<Class, CustomizeEyesEntity>(_file);

        public IDictionary<Class, CustomizeHairEntity> ReadCustomizeHairTable() =>
            Read<Class, CustomizeHairEntity>(_file);

        public IDictionary<Class, CustomizeInfoEntity> ReadCustomizeInfoTable() =>
            Read<Class, CustomizeInfoEntity>(_file);

        public IDictionary<uint, CharacterBackgroundEntity> ReadCharacterBackgroundTable() =>
            Read<uint, CharacterBackgroundEntity>(_file);

        public IDictionary<ushort, DistrictEntity> ReadDistrictTable() =>
            Read<ushort, DistrictEntity>(_file);

        public IDictionary<uint, ItemEntity> ReadItemTable() =>
            Read<uint, ItemEntity>(_file);

        public IDictionary<uint, ItemClassifyEntity> ReadItemClassifyTable() =>
            Read<uint, ItemClassifyEntity>(_file);

        public IDictionary<uint, ItemScriptEntity> ReadItemScriptTable() =>
            Read<uint, ItemScriptEntity>(_file);

        public IDictionary<ushort, CharacterInfoEntity> ReadCharacterInfoTable() =>
            Read<ushort, CharacterInfoEntity>(_file);

        public IDictionary<uint, PhotoItemEntity> ReadPhotoItemTable() =>
            Read<uint, PhotoItemEntity>(_file);

        public IDictionary<ushort, GestureEntity> ReadGestureTable() =>
            Read<ushort, GestureEntity>(_file);

        public IDictionary<ushort, MazeInfoEntity> ReadMazeInfoTable() =>
            Read<ushort, MazeInfoEntity>(_file);

        public IDictionary<ushort, BoosterEntity> ReadBoosterTable() =>
            Read<ushort, BoosterEntity>(_file);

        public IDictionary<uint, NpcEntity> ReadNpcTable() =>
            Read<uint, NpcEntity>(_file);

        public IDictionary<uint, PassInfoEntity> ReadPassInfoTable() =>
            Read<uint, PassInfoEntity>(_file);

        public IDictionary<uint, PassRewardInfoEntity> ReadPassRewardInfoTable() =>
            Read<uint, PassRewardInfoEntity>(_file);

        public void Dispose()
        {
            ((IDisposable) _file).Dispose();
        }

        public BinReader(string path, string password, byte xor = 0x55)
        {
            _file = new ZipArchive(path, password, xor);
        }

        public BinReader(ZipArchive file)
        {
            _file = file;
        }

        private static IDictionary<TId, TItem> Read<TId, TItem>(ZipFile data)
            where TId : struct
            where TItem : ITableEntity<TId>
        {
            var type = typeof(TItem);
            var name = type.GetCustomAttribute<TableAttribute>()?.Name ?? throw new ApplicationException();

            var entries = GetEntries(data, name);
            var instances = entries.Select(br => (TItem) CreateInstance(br, type));
            
            return instances.ToDictionary(key => key.Id, value => value);
        }

        private static object CreateInstance(BinaryReader br, Type type) =>
            Activator.CreateInstance(type, br) ?? throw new ApplicationException();

        private static IEnumerable<BinaryReader> GetEntries(ZipFile data, string file)
        {
            using BinaryReader br = new(data.GetInputStream(data.GetEntry($"../bin/Table/{file}.res")));

            for (uint q = 0, count = br.ReadUInt32(); q < count; ++q)
            {
                yield return br;
            }
        }

        private readonly ZipArchive _file;
    }
}