namespace SoulWorkerResearch.SoulCore.IO.Net.Messages;

public interface IBinaryConvertibleMessage
{
    void ToBinary(BinaryWriter writer);
}
