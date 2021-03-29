using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.Collections.Generic;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Login
{
    [Request(CategoryCommand.Login, LoginCommand.EnterWaitCancel)]
    [Request(CategoryCommand.Login, LoginCommand.OptionUpdate)]
    public readonly struct LoginOptionUpdateRequest
    {
        public readonly IReadOnlyList<byte> Values;

        internal LoginOptionUpdateRequest(BinaryReader br) => Values = br.ReadBytes(CommonDefines.OptionsCount);
    }
}
