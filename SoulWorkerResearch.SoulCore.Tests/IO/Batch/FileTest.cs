using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulWorkerResearch.SoulCore.IO.Batch.EventBox;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;

using BatchFile = SoulWorkerResearch.SoulCore.IO.Batch.File;
using SysFile = System.IO.File;

namespace SoulWorkerResearch.SoulCore.Tests.IO.Batch;

[TestClass]
public sealed class FileTest
{
    [TestMethod]
    public void VMonsterSpawnBox()
    {
        Assert.AreEqual(_m24ArkShipHero.EventBox.MonsterSpawns.Count, 1);
        var value = _m24ArkShipHero.EventBox.MonsterSpawns[0];

        var monsters = new Monster[]
        {
            new Monster(34401415, MonsterSpawnType.Monster, 10000),
            new Monster(0, MonsterSpawnType.Monster, 10000),
            new Monster(0, MonsterSpawnType.Monster, 10000),
            new Monster(0, MonsterSpawnType.Monster, 0),
            new Monster(0, MonsterSpawnType.Monster, 0),
            new Monster(0, MonsterSpawnType.Monster, 0),
            new Monster(0, MonsterSpawnType.Monster, 10000),
            new Monster(0, MonsterSpawnType.Monster, 0),
            new Monster(0, MonsterSpawnType.Monster, 0),
            new Monster(0, MonsterSpawnType.Monster, 10000)
        };

        Assert.AreEqual(value.Id, 40101u);
        Assert.AreEqual(value.GenerateId, 140101u);
        Assert.AreEqual(value.LayerBitmask, LayerBitmask.Normal);
        Assert.AreEqual(value.PosTopLeft, new Vector3(75660.938f, 51896.379f, 33204.410f));
        Assert.AreEqual(value.PosBottomRight, new Vector3(75760.938f, 51996.379f, 33304.410f));
        Assert.AreEqual(value.Rotation, 0.0000f);
        Assert.AreEqual(value.Size, new Vector3(100.000f, 100.000f, 100.000f));
        Assert.AreEqual(value.ShowCustomEntity, true);
        Assert.AreEqual(value.Color, Color.FromArgb(red: 0, green: 0, blue: 0, alpha: 255));
        Assert.IsTrue(value.Monsters.SequenceEqual(monsters));
        Assert.AreEqual(value.CreationPositionType, CreationPositionType.Center);
        Assert.AreEqual(value.MoveType, MoveType.Static);
        Assert.AreEqual(value.CreationCondition, CreationConditionType.WaitSignal);
        Assert.AreEqual(value.CreationEffectFile, string.Empty);
        Assert.AreEqual(value.WaitCreationDelayTime, 0.0000f);
        Assert.AreEqual(value.WaitCreationSequenceTime, 0.0000f);
        Assert.AreEqual(value.WaitCreationMaxWave, (byte)0);
        Assert.AreEqual(value.MaxEntityCount, (byte)1);
        Assert.AreEqual(value.WaitCreationSequenceType, WaitCreationSequenceType.All);
        Assert.AreEqual(value.Waypoint, 0u);
        Assert.AreEqual(value.AggroGroup, (ushort)0);
        Assert.AreEqual(value.AggroDistance, 0u);
        Assert.AreEqual(value.AggroMaxCount, (ushort)0);
        Assert.AreEqual(value.LookRatio, 20.0000f);
        Assert.AreEqual(value.ShowSight, false);
        Assert.AreEqual(value.ObjectKey, string.Empty);
        Assert.AreEqual(value.ScriptType, ScriptType.None);
        Assert.IsTrue(value.CheckScriptHps.SequenceEqual(Enumerable.Repeat<byte>(0, 5)));
        Assert.AreEqual(value.Sector, (ushort)10001);
        Assert.AreEqual(value.ChangeSpawnAction, ChangeSpawnActionType.N_Stand);
        Assert.AreEqual(value.ProtectionTarget, (ushort)0);
        Assert.AreEqual(value.RespawnTime, 0.0000f);
        Assert.AreEqual(value.Step, (byte)1);
        Assert.AreEqual(value.RespawnType, RespawnType.None);
        Assert.AreEqual(value.RespawnCondition, 0u);
        Assert.AreEqual(value.GroupId, 0u);
    }

    [TestMethod]
    public void VSectorBox()
    {
        Assert.AreEqual(_m24ArkShipHero.EventBox.Sectors.Count, 1);
        var value = _m24ArkShipHero.EventBox.Sectors[0];

        Assert.AreEqual(value.Id, 10001u);
        Assert.AreEqual(value.GenerateId, 10001u);
        Assert.AreEqual(value.LayerBitmask, LayerBitmask.Common);
        Assert.AreEqual(value.PosTopLeft, new Vector3(73364.344f, 48564.090f, 32603.744f));
        Assert.AreEqual(value.PosBottomRight, new Vector3(78364.344f, 53564.090f, 35103.742f));
        Assert.AreEqual(value.Rotation, 0.0000f);
        Assert.AreEqual(value.Size, new Vector3(5000.000f, 5000.000f, 2500.000f));
        Assert.AreEqual(value.ShowCustomEntity, true);
        Assert.AreEqual(value.Color, Color.FromArgb(red: 0, green: 0, blue: 0, alpha: 255));

        Assert.AreEqual(value.Type, SectorType.Boss);
        Assert.AreEqual(value.EnterLua, string.Empty);
        Assert.AreEqual(value.ClearType, ClearType.KillPerpect);
        Assert.AreEqual(value.ClearKillRatio, (byte)100);
        Assert.AreEqual(value.ClearLua, string.Empty);
        Assert.AreEqual(value.SectorTitle, 0u);
        Assert.AreEqual(value.ExitType, SectorExitType.Portal);
        Assert.AreEqual(value.Exit, 30001u);
        Assert.AreEqual(value.RelativeSector, 0u);
        Assert.IsTrue(value.ConditionKillRatioSteps.SequenceEqual(Enumerable.Repeat<byte>(0, 5)));
    }

    [TestMethod]
    public void VSectorStartBoxTest()
    {
        Assert.AreEqual(_m24ArkShipHero.EventBox.SectorStarts.Count, 1);
        var value = _m24ArkShipHero.EventBox.SectorStarts[0];

        Assert.AreEqual(value.Id, 11u);
        Assert.AreEqual(value.GenerateId, 11u);
        Assert.AreEqual(value.LayerBitmask, LayerBitmask.Common);
        Assert.AreEqual(value.PosTopLeft, new Vector3(75846.250f, 50056.199f, 33200.949f));
        Assert.AreEqual(value.PosBottomRight, new Vector3(75946.250f, 50156.199f, 33300.949f));
        Assert.AreEqual(value.Rotation, -180.0000);
        Assert.AreEqual(value.Size, new Vector3(100.000f, 100.000f, 100.000f));
        Assert.AreEqual(value.ShowCustomEntity, true);
        Assert.AreEqual(value.Color, Color.FromArgb(red: 0, green: 0, blue: 0, alpha: 255));

        Assert.AreEqual(value.Sector, 10001u);
    }

    public FileTest()
    {
        using var fs = SysFile.OpenRead(Path.Combine("Datas", "World", "Table", "M24_ARKSHIP_HERO.vbatch"));
        _m24ArkShipHero = BatchFile.FromStream(fs).AsTask().GetAwaiter().GetResult();
    }

    private readonly BatchFile _m24ArkShipHero;
}
