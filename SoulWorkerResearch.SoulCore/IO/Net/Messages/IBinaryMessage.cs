namespace SoulWorkerResearch.SoulCore.IO.Net.Messages;

public interface IBinaryMessage : IBinarySerializable
{
    Opcode GetOpcode();
}
