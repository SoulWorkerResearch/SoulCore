using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Extensions;

internal static class XElementExtension
{
    internal static string GetString(this XElement @this, string xpath) => @this.GetValue(xpath);

    internal static float GetSingle(this XElement @this, string xpath) => float.Parse(@this.GetValue(xpath));

    internal static uint GetUInt32(this XElement @this, string xpath) => uint.Parse(@this.GetValue(xpath));

    internal static ushort GetUInt16(this XElement @this, string xpath) => ushort.Parse(@this.GetValue(xpath));

    internal static byte GetByte(this XElement @this, string xpath) => byte.Parse(@this.GetValue(xpath));

    internal static bool GetBool(this XElement @this, string xpath) => bool.Parse(@this.GetValue(xpath));

    internal static Vector3 GetVector3(this XElement @this, string xpath)
    {
        var values = @this.GetSplitted(xpath, float.Parse);
        Debug.Assert(values.Length == 3);

        return new Vector3(values[0], values[1], values[2]);
    }

    internal static Color GetColor(this XElement @this, string xpath)
    {
        var values = @this.GetSplitted(xpath, byte.Parse);
        Debug.Assert(values.Length == 4);

        return Color.FromArgb(red: values[0], green: values[1], blue: values[2], alpha: values[3]);
    }

    internal static TEnum? GetEnumOriginal<TEnum>(this XElement @this, string xpath) where TEnum : struct
    {
        var name = @this.GetString(xpath);

        if (Enum.TryParse<TEnum>(name, false, out var result))
            return result;

        return null;
    }

    internal static TEnum? GetEnumAlternative<TEnum>(this XElement @this, string xpath) where TEnum : struct
    {
        var original = @this.GetString(xpath);
        var type = typeof(TEnum);

        var alternative = type.GetFields().FirstOrDefault(f => f.GetCustomAttribute<XmlEnumAttribute>()?.Name == original)?.Name;
        if (Enum.TryParse<TEnum>(alternative, false, out var result))
            return result;

        return null;
    }

    internal static TEnum GetEnum<TEnum>(this XElement @this, string xpath) where TEnum : struct => @this
        .GetEnumOriginal<TEnum>(xpath) ?? @this.GetEnumAlternative<TEnum>(xpath) ?? throw new ApplicationException();

    private static T[] GetSplitted<T>(this XElement @this, string xpath, Func<string, T> parser) => @this
        .GetValue(xpath).Split(',').Select(parser).ToArray();

    private static string GetValue(this XElement @this, string xpath) => @this
        .XPathSelectElement(xpath)?.Attributes().First(v => v.Name == "value").Value ?? throw new ApplicationException();
}
