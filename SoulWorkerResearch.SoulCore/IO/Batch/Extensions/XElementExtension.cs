using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Extensions;

internal static class XElementExtension
{
    internal static string GetString(this XElement x, string xpath) => x.GetValue(xpath);

    internal static float GetSingle(this XElement x, string xpath) => float.Parse(x.GetValue(xpath));

    internal static uint GetUInt32(this XElement x, string xpath) => uint.Parse(x.GetValue(xpath));

    internal static ushort GetUInt16(this XElement x, string xpath) => ushort.Parse(x.GetValue(xpath));

    internal static byte GetByte(this XElement x, string xpath) => byte.Parse(x.GetValue(xpath));

    internal static bool GetBool(this XElement x, string xpath) => bool.Parse(x.GetValue(xpath));

    internal static Vector3 GetVector3(this XElement x, string xpath)
    {
        var values = x.GetSplitted(xpath, float.Parse);
        return new Vector3(values[0], values[1], values[2]);
    }

    internal static Color GetColor(this XElement x, string xpath)
    {
        var values = x.GetSplitted(xpath, byte.Parse);
        return Color.FromArgb(red: values[0], green: values[1], blue: values[2], alpha: values[3]);
    }

    internal static T GetEnum<T>(this XElement x, string xpath)
    {
        var type = typeof(T);
        var name = x.GetString(xpath);

        if (Enum.TryParse(type, name, false, out var result) && result is not null)
            return (T)result;

        name = type.GetFields().First(f => f.GetCustomAttribute<XmlEnumAttribute>()?.Name == name).Name;

        return (T)Enum.Parse(type, name, false);
    }

    private static T[] GetSplitted<T>(this XElement x, string xpath, Func<string, T> parser) =>
        x.GetValue(xpath).Split(',').Select(parser).ToArray();

    private static string GetValue(this XElement x, string xpath) =>
        x.XPathSelectElement(xpath)?.Attributes().FirstOrDefault(v => v.Name == "value")?.Value ?? throw new ApplicationException();
}
