using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record SocialItemExcludeBox : BasicEntity
{
    public SocialItemExcludeBox(XElement x) : base(x)
    {
    }
}
