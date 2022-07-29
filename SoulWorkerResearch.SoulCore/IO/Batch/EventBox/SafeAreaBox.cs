using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record SafeAreaBox : Entity
{
    public SafeAreaBox(XElement x) : base(x)
    {
    }
}
