using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
  public readonly partial struct CharacterUpdateTitleRequest
    {

        public readonly Title Battle;
        public readonly Title Preview;

        internal CharacterUpdateTitleRequest(BinaryReader br)
        {
            Battle = new(br);
            Preview = new(br);
        }
    }
}
