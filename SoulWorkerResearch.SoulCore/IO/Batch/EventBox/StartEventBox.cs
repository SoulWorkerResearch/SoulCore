using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record StartEventBox : Entity
{
    /// <summary>
    ///
    /// </summary>
    public SpawnType SpawnType { get; }

    public StartEventBox(XElement x) : base(x) =>
        SpawnType = x.GetEnum<SpawnType>("m_eSpawnType");
}
