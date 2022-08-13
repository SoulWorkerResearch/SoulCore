namespace SoulWorkerResearch.SoulCore.IO.Net.Messages;

public interface IBinaryOutcomingMessage : IBinaryMessage
{
    void ToBinary(BinaryWriter writer);
}
