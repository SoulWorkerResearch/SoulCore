using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record SafeAreaBox : BasicEntity
{
    public SafeAreaBox(XElement x) : base(x)
    {
    }
}
