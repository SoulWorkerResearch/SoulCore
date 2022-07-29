using System.Runtime.InteropServices;

namespace SoulWorkerResearch.SoulCore.DataTypes;

[StructLayout(LayoutKind.Explicit)]
public readonly struct SerialValue
{
    [FieldOffset(0)]
    public readonly long Value = -1;

    //[FieldOffset(0)]
    //public readonly ulong Seed;

    //[FieldOffset(0)]
    //public readonly ulong Min : 6;
    //public readonly ulong Hour : 5;
    //public readonly ulong Day : 5;
    //public readonly ulong Month : 4;
    //public readonly ulong Years : 4;
    //public readonly ulong GroupId : 4;
    //public readonly ulong ServerId : 4;

    internal SerialValue(BinaryReader reader)
    {
        Value = reader.ReadInt64();
    }
}
