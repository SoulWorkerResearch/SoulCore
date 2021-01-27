using SoulCore.Types;
using System;
using System.Diagnostics;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
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