using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ChangeSlot)]
    public readonly struct CharacterChangeSlotRequest
    {
        public readonly struct CharacterInfo
        {
            public readonly int CharacterId;
            public readonly byte SlotId;

            public CharacterInfo(int characterId, byte slotId)
            {
                CharacterId = characterId;
                SlotId = slotId;
            }
        }

        public readonly int AccountId;
        public readonly CharacterInfo Src;
        public readonly CharacterInfo Dst;
        public readonly int ErrorCode;

        internal CharacterChangeSlotRequest(BinaryReader br)
        {
            AccountId = br.ReadInt32();
            var srcCharacterId = br.ReadInt32();
            var dstCharacterId = br.ReadInt32();
            ErrorCode = br.ReadInt32();
            var srcSlotId = br.ReadByte();
            var dstSlotId = br.ReadByte();

            Src = new(srcCharacterId, srcSlotId);
            Dst = new(dstCharacterId, dstSlotId);
        }
    }
}
