﻿using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes;

[StructLayout(LayoutKind.Explicit)]
public readonly struct HairValue : IHairValue
{
    public static HairValue Empty { get; } = new();

    [FieldOffset(0)]
    internal readonly uint Value;

    [FieldOffset(0)]
    public readonly ushort Style;

    [FieldOffset(2)]
    public readonly ushort Color;

    #region IHairValue

    ushort IHairValue.Style => Style;
    ushort IHairValue.Color => Color;

    #endregion IHairValue

    internal HairValue(BinaryReader reader)
    {
        Style = 0;
        Color = 0;
        Value = reader.ReadUInt32();
    }
}