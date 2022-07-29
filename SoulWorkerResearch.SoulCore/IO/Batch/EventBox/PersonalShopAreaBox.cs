using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record PersonalShopAreaBox : Entity
{
    public PersonalShopAreaBox(XElement x) : base(x)
    {
    }
}
