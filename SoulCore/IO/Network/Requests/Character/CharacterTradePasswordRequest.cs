using SoulCore.Types;
using System;
using System.Diagnostics;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
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
