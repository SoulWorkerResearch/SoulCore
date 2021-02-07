using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.PacketSharedStructure;
using SoulCore.IO.Network.Permissions;
using SoulCore.IO.Network.Providers;
using SoulCore.IO.Network.Requests;
using SoulCore.IO.Network.Responses;
using SoulCore.IO.Network.Responses.Login;
using SoulCore.IO.Network.Responses.Skill;
using SoulCore.IO.Network.Utils;
using SoulCore.Types;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SoulCore.IO.Network
{
    public interface IBaseSession
    {
        void Disconnect();
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8