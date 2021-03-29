using SoulWorkerResearch.SoulCore.Extensions;
using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.UpdateCutscene)]
    public readonly struct CharacterUpdateCutsceneRequest
    {
        public readonly int CharacterId;
        public readonly bool OnPlay;
        public readonly string Name;

        internal CharacterUpdateCutsceneRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            OnPlay = br.ReadBoolean();
            Name = br.ReadByteLengthUtf8String();
        }
    }
}
