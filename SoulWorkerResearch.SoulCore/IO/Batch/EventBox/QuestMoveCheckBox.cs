using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record QuestMoveCheckBox : Entity
{
    /// <summary>
    ///
    /// </summary>
    public uint EpisodeCondition { get; }

    public QuestMoveCheckBox(XElement x) : base(x) =>
        EpisodeCondition = x.GetUInt32("m_uiEpisodeCondition");
}
