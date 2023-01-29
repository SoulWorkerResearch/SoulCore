using Microsoft.CSharp;
using System.CodeDom;

namespace SoulWorkerResearch.SoulCore.Tools.Generators.IO.Res.Helpers;

internal static class TypeHelper
{
    internal static string NameFrom(string name)
    {
        var type = Type.GetType($"System.{name}");
        ArgumentNullException.ThrowIfNull(type);

        using var provider = new CSharpCodeProvider();

        var @ref = new CodeTypeReference(type);
        return provider.GetTypeOutput(@ref);
    }
}
