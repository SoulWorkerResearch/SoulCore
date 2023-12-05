using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record CheckSectorBox : BasicEntity
{
    public CheckSectorBox(XElement x) : base(x)
    {
        CheckSector = x.GetUInt32("m_iCheckSector");
        Lua = x.GetString("m_szLua");
        CheckGate = x.GetUInt32("m_iCheckGate");
    }

    /// <summary>
    /// </summary>
    public uint CheckSector { get; }

    /// <summary>
    /// </summary>
    public string Lua { get; }

    /// <summary>
    /// </summary>
    public uint CheckGate { get; }
}
