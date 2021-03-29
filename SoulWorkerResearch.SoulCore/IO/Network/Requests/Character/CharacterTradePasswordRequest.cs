using SoulWorkerResearch.SoulCore.Types;
using System;
using System.Diagnostics;
using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.TradePassword)]
    public readonly struct CharacterTradePasswordRequest
    {
        public readonly PasswordCheckType CheckType;
        public readonly byte[] Password;

        internal CharacterTradePasswordRequest(BinaryReader br)
        {
            CheckType = (PasswordCheckType)br.ReadByte();
            Debug.Assert(Enum.IsDefined(typeof(PasswordCheckType), CheckType));

            Password = br.ReadBytes(5);
        }
    }
}
