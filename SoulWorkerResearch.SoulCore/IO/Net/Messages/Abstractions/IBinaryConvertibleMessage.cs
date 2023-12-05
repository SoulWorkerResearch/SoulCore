namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;

public interface IBinaryConvertibleMessage
{
    void ToBinary(BinaryWriter writer);
}
