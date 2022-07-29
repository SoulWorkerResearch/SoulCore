using SoulWorkerResearch.SoulCore.Defines;

namespace SoulWorkerResearch.SoulCore.Extensions;

public static class GateStatusExtension
{
    #region Methods

    public static bool IsUnavailable(this GateStatus @this) => _bad.Any(e => e == @this);

    #endregion Methods

    #region Private Field

    private static readonly GateStatus[] _bad = new[] { GateStatus.Offline, GateStatus.Busy };

    #endregion Private Field
}
