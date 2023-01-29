using System.Globalization;
using System.Text.RegularExpressions;

namespace SoulWorkerResearch.SoulCore.Tools.Generators.IO.Res.Helpers;

internal static partial class StringHelper
{
    internal static string NormalizeName(string name)
    {
        var v = name.ToLower();
        v = v.Replace("_", " ");
        v = v.Replace("-", " ");
        v = Prefix().Replace(v, string.Empty);

        var culture = CultureInfo.CurrentCulture.TextInfo;
        v = culture.ToTitleCase(v);

        return v.Replace(" ", string.Empty);
    }

    [GeneratedRegex("^tb ")]
    private static partial Regex Prefix();
}
