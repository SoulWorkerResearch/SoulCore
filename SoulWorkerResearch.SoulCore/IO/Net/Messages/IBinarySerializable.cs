namespace SoulWorkerResearch.SoulCore.IO.Net.Messages;

public interface IBinarySerializable
{
    void ToBinary(BinaryWriter writer);
}
