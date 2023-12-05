using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record StartEventBox : BasicEntity
{
    public StartEventBox(XElement x) : base(x)
    {
        SpawnType = x.GetEnum<SpawnType>("m_eSpawnType");
    }

    /// <summary>
    /// </summary>
    public SpawnType SpawnType { get; }
}
