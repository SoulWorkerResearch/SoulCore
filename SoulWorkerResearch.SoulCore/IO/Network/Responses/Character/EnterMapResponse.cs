namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record EnterMapResponse : MapInfoShared
    {
        public bool ChangeServer { get; init; }
        public byte ChangeType { get; init; }
        public int Result { get; init; }
        public PartyInfoShared PartyInfo { get; init; } = PartyInfoShared.Empty;
    }
}
