using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record SocialItemExcludeBox : Entity
{
    public SocialItemExcludeBox(XElement x) : base(x)
    {
    }
}
