using SoulWorkerResearch.SoulCore.DataTypes.Enums;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Packet;

namespace SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;

public static class EnumBinaryWriterExtension
{
    //public staticvoid WriteCharacterInfoResult(this BinaryWriter @this, CharacterInfoResult value) => @this.Write((byte)value);

    //public staticvoid WriteSyncUserFlags(this BinaryWriter @this, SyncUserFlags value) => @this.Write((int)value);

    //public staticvoid WriteUserFlags(this BinaryWriter @this, UserFlags value) => @this.Write((int)value);

    public static void Write(this BinaryWriter @this, MapChangeType value) => @this.Write((byte)value);
    
    public static void Write(this BinaryWriter @this, EnterMapResult value) => @this.Write((int)value);

    public static void Write(this BinaryWriter @this, DistrictConnectResult value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, UserOptionStatus value) => @this.Write((ushort)value);

    public static void Write(this BinaryWriter @this, GateEnterResult value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, Advancement value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, ChannelLoadStatus value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, StatType value) => @this.Write((ushort)value);

    public static void Write(this BinaryWriter @this, DistrictLogOutStatus value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, LogOutType value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, NpcVisablity value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, Permisson value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, AuthLoginErrorMessageCode value) => @this.Write((uint)value);

    public static void Write(this BinaryWriter @this, SpecialOption value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, ChatType value) => @this.Write((uint)value);

    public static void Write(this BinaryWriter @this, Character value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, GateStatus value) => @this.Write((uint)value);

    public static void Write(this BinaryWriter @this, ProfileStatus value) => @this.Write((byte)value);

    public static void Write(this BinaryWriter @this, PacketMagick value) => @this.Write(value.Value);

    public static void Write(this BinaryWriter @this, PacketProtocol value) => @this.Write((byte)value);
}
