using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.IO;
using System.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct SkillQuickSlotsUpdateRequest
    {
        public readonly struct ColumnInfo
        {
            public readonly struct SlotInfo
            {
                public uint Id { get; }

                public SlotInfo(BinaryReader br) => Id = br.ReadUInt32();
            }

            public ushort Id { get; }
            public SlotInfo[] Sequence { get; }
            public uint Unknown1 { get; }

            public ColumnInfo(BinaryReader br)
            {
                Id = br.ReadUInt16();
                Sequence = Enumerable.Range(1, CommonDefines.SkillsInSequenceCount).Select(_ => new SlotInfo(br)).ToArray();
                Unknown1 = br.ReadUInt32();
            }
        }

        public ColumnInfo[] Column { get; }

        public SkillQuickSlotsUpdateRequest(BinaryReader br) => Column = Enumerable
            .Range(1, br.ReadByte())
            .Select(_ => new ColumnInfo(br))
            .ToArray();
    }
}
