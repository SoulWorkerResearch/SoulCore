using SoulWorkerResearch.SoulCore.Defines;

namespace SoulWorkerResearch.SoulCore.Extensions;

public static class GateStatusExtension
{
    #region Private Field

    private static readonly GateStatus[] _bad = [GateStatus.Offline, GateStatus.Busy];

    #endregion Private Field

    #region Methods

    public static bool IsUnavailable(this GateStatus @this)
    {
        return _bad.Any(e => e == @this);
    }

    #endregion Methods
}
