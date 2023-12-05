using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record QuestMoveCheckBox : BasicEntity
{
    public QuestMoveCheckBox(XElement x) : base(x)
    {
        EpisodeCondition = x.GetUInt32("m_uiEpisodeCondition");
    }

    /// <summary>
    /// </summary>
    public uint EpisodeCondition { get; }
}
