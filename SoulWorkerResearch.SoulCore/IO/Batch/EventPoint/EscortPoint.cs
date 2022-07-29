using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using System.Xml.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Batch.EventPoint;

public sealed record EscortPoint : Point
{
    /// <summary>
    ///
    /// </summary>
    public string Function { get; }

    /// <summary>
    ///
    /// </summary>
    public string EnableEffectPath { get; }

    /// <summary>
    ///
    /// </summary>
    public string DisableEffectPath { get; }

    public EscortPoint(XElement x) : base(x)
    {
        Function = x.GetString("m_szFunction");
        EnableEffectPath = x.GetString("m_sEnableEffectPath");
        DisableEffectPath = x.GetString("m_sDisableEffectPath");
    }
}
