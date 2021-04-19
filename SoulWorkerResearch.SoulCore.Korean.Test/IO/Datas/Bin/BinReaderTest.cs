using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table;
using SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table.Entities;
using SoulWorkerResearch.SoulCore.Types;
using SoulWorkerResearch.SoulCore.Vision;
using Xunit;

namespace SoulWorkerResearch.SoulCore.Korean.Test.IO.Datas.Bin
{
    public class BinReaderTest : IClassFixture<Startup>, IDisposable
    {
        [Fact]
        public void ReadClassSelectInfoTableTest() =>
            Read<Class, ClassSelectInfoEntity>(_file);

        [Fact]
        public void ReadCustomizeSkinTableTest() =>
            Read<Class, CustomizeSkinEntity>(_file);

        [Fact]
        public void ReadCustomizeEyesTableTest() =>
            Read<Class, CustomizeEyesEntity>(_file);

        [Fact]
        public void ReadCustomizeHairTableTest() =>
            Read<Class, CustomizeHairEntity>(_file);

        [Fact]
        public void ReadCustomizeInfoTableTest() =>
            Read<Class, CustomizeInfoEntity>(_file);

        [Fact]
        public void ReadCharacterBackgroundTableTest() =>
            Read<uint, CharacterBackgroundEntity>(_file);

        [Fact]
        public void ReadDistrictTableTest() =>
            Read<ushort, DistrictEntity>(_file);

        [Fact]
        public void ReadItemTableTest() =>
            Read<uint, ItemEntity>(_file);

        [Fact]
        public void ReadItemClassifyTableTest() =>
            Read<uint, ItemClassifyEntity>(_file);

        [Fact]
        public void ReadItemScriptTableTest() =>
            Read<uint, ItemScriptEntity>(_file);

        [Fact]
        public void ReadCharacterInfoTableTest() =>
            Read<ushort, CharacterInfoEntity>(_file);

        [Fact]
        public void ReadPhotoItemTableTest() =>
            Read<uint, PhotoItemEntity>(_file);

        [Fact]
        public void ReadGestureTableTest() =>
            Read<ushort, GestureEntity>(_file);

        [Fact]
        public void ReadMazeInfoTableTest() =>
            Read<ushort, MazeInfoEntity>(_file);

        [Fact]
        public void ReadBoosterTableTest() =>
            Read<ushort, BoosterEntity>(_file);

        [Fact]
        public void ReadNpcTableTest() =>
            Read<uint, NpcEntity>(_file);

        [Fact]
        public void ReadPassInfoTableTest() =>
            Read<uint, PassInfoEntity>(_file);

        [Fact]
        public void ReadPassRewardInfoTableTest() =>
            Read<uint, PassRewardInfoEntity>(_file);

        public void Dispose()
        {
            ((IDisposable) _file).Dispose();
        }

        public BinReaderTest(Startup startup)
        {
            var configuration = startup.ServiceProvider.GetRequiredService<IConfiguration>();

            var dir = configuration["Game:Dir"];
            Assert.NotNull(dir);

            var path = Path.Join(dir, "datas", "data12.v");
            
            _file = new ZipArchive(path, configuration["Game:Datas:Password:Data12"]);
        }


        private static void Read<TId, TItem>(ZipFile data)
            where TId : struct
            where TItem : ITableEntity<TId>
        {
            var type = typeof(TItem);
            var name = type.GetCustomAttribute<TableAttribute>()?.Name ?? throw new ApplicationException();

            var entries = GetEntries(data, name);
            _ = entries.Select(br => (TItem) CreateInstance(br, type));
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