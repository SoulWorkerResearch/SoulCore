using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventBox;

public sealed record LuaFunctionBox : Entity
{
    /// <summary>
    /// Type of Target
    /// </summary>
    public LuaFunctionType Type { get; }

    /// <summary>
    /// LuaFunction
    /// </summary>
    public string Function { get; }

    /// <summary>
    /// ID of Monster or NPC for check.
    /// </summary>
    public uint CheckId { get; }

    public LuaFunctionBox(XElement x) : base(x)
    {
        Type = x.GetEnum<LuaFunctionType>("m_eType");
        Function = x.GetString("m_szFunction");
        CheckId = x.GetUInt32("m_iCheckID");
    }
}
