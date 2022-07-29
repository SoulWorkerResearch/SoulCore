using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Booster;

[ServerMessage(Group, Command)]
public readonly struct BoosterListLoadServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Booster;
    public const BoosterOpcode Command = BoosterOpcode.ListLoad;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(BoosterListLoadServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal BoosterListLoadServerMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors
}
