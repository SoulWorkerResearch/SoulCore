using System.Text;

namespace SoulWorkerResearch.SoulCore.Tools.Generators.IO.Res.Helpers;

internal static class ClassHelper
{
    internal static async ValueTask<string> BodyFrom(string shortClassName, string fileName, IReadOnlyList<string> types)
    {
        var builder = new StringBuilder();
        var keyName = $"{shortClassName}KeyType";

        builder.AppendFormat("global using {0} = System.{1};", keyName, types[0]);
        builder.AppendLine();
        builder.AppendLine();

        var fullClassName = $"{StringHelper.NormalizeName(fileName)}Entry";

        if (types.Any(v => v == "String"))
            builder.AppendLine("using SoulWorkerResearch.SoulCore.Extensions;");

        builder.AppendLine("using SoulWorkerResearch.SoulCore.IO.Res.Attributes;");
        builder.AppendLine("");
        builder.AppendLine("namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;");
        builder.AppendLine("");
        builder.AppendLine("[Table(TableName)]");
        builder.AppendFormat("public sealed class {0} : IEntry<{0}>", fullClassName);
        builder.AppendLine("");
        builder.AppendLine("{");

        var results = await Task.WhenAll(
            Task.Factory.StartNew(() => DefineTypes(keyName, fileName, types)),
            Task.Factory.StartNew(() => DefineConstructor(fullClassName, types)));

        builder.Append(results[0]);
        builder.AppendLine();
        builder.Append(results[1]);

        builder.AppendLine("}");

        return builder.ToString();
    }

    private static StringBuilder DefineTypes(string keyTypeName, string fileName, IReadOnlyList<string> types)
    {
        var builder = new StringBuilder();

        builder.AppendFormat("    public const string TableName = \"{0}\";", fileName);
        builder.AppendLine();
        builder.AppendLine();

        foreach (var (Id, Type) in types.Select((v, i) => (Id: i, Type: v)))
        {
            var t = TypeHelper.NameFrom(Type);
            builder.AppendFormat("    public {0} {1} {{ get; set; }}", Id == 0 ? keyTypeName : t, Id == 0 ? "Id" : $"Field{Id}");

            if (t == "string") builder.Append(" = string.Empty;");
            builder.AppendLine();
        }

        return builder;
    }

    private static StringBuilder DefineConstructor(string fullClassName, IReadOnlyList<string> types)
    {
        var builder = new StringBuilder();

        builder.AppendFormat("    public {0}(BinaryReader reader)", fullClassName);
        builder.AppendLine("");
        builder.AppendLine("    {");

        foreach (var (Id, Type) in types.Select((v, i) => (Id: i, Type: v)))
        {
            var t = TypeHelper.NameFrom(Type);
            builder.AppendFormat("        {0} = reader.Read{1}();", Id == 0 ? "Id" : $"Field{Id}", Type == "String" ? "UTF16UnicodeString" : Type);
            builder.AppendLine();
        }
        builder.AppendLine("    }");
        builder.AppendLine("");
        builder.AppendFormat("    static string IEntry<{0}>.TableName => TableName;", fullClassName);
        builder.AppendLine("");
        builder.AppendLine("");
        builder.AppendFormat("    static {0} IEntry<{0}>.CreateInstance(BinaryReader reader)", fullClassName);
        builder.AppendLine("");
        builder.AppendLine("    {");
        builder.AppendFormat("        return new {0}(reader);", fullClassName);
        builder.AppendLine("");
        builder.AppendLine("    }");

        return builder;
    }
}
