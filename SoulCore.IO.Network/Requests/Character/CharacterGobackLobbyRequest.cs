using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.GobackLobby)]
    public readonly struct CharacterGobackLobbyRequest
    {
        internal CharacterGobackLobbyRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
