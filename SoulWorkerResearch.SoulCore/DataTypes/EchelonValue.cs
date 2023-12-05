namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct EchelonValue 
{
    public byte Level { get; init; }
    public int Exp { get; init; }

    internal EchelonValue(BinaryReader reader)
    {
        Level = reader.ReadByte();
        Exp = reader.ReadInt32();
    }
}
