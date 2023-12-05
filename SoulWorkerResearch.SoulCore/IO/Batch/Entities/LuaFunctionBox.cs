using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record LuaFunctionBox : BasicEntity
{
    public LuaFunctionBox(XElement x) : base(x)
    {
        Type = x.GetEnum<LuaFunctionType>("m_eType");
        Function = x.GetString("m_szFunction");
        CheckId = x.GetUInt32("m_iCheckID");
    }

    /// <summary>
    ///     Type of Target
    /// </summary>
    public LuaFunctionType Type { get; }

    /// <summary>
    ///     LuaFunction
    /// </summary>
    public string Function { get; }

    /// <summary>
    ///     ID of Monster or NPC for check.
    /// </summary>
    public uint CheckId { get; }
}
