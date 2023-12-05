using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record PersonalShopAreaBox : BasicEntity
{
    public PersonalShopAreaBox(XElement x) : base(x)
    {
    }
}
