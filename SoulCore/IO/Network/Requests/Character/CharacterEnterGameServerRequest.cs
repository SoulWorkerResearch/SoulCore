﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Responses.Shared;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.EnterGameServerReq)]
    public readonly struct CharacterEnterGameServerRequest
    {
        public readonly int AccountId;
        public readonly int CharacterId;
        public readonly MapIdPacketSharedStructure MapId;
        public readonly byte FirstConnect;
        public readonly ulong SessionKey;

        internal CharacterEnterGameServerRequest(BinaryReader br)
        {
            AccountId = br.ReadInt32();
            CharacterId = br.ReadInt32();
            MapId = new(br);
            FirstConnect = br.ReadByte();
            SessionKey = br.ReadUInt64();
        }
    }
}