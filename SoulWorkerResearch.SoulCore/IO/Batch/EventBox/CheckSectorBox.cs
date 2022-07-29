using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record CheckSectorBox : Entity
{
    /// <summary>
    ///
    /// </summary>
    public uint CheckSector { get; }

    /// <summary>
    ///
    /// </summary>
    public string Lua { get; }

    /// <summary>
    ///
    /// </summary>
    public uint CheckGate { get; }

    public CheckSectorBox(XElement x) : base(x)
    {
        CheckSector = x.GetUInt32("m_iCheckSector");
        Lua = x.GetString("m_szLua");
        CheckGate = x.GetUInt32("m_iCheckGate");
    }
}
