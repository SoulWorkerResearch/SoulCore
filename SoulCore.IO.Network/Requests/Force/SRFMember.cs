using SoulCore.Types;

namespace SoulCore.IO.Network.Requests.Force
{
    public abstract record SRFMember
    {
        public int Member { get; }
        public string Name { get; } = string.Empty;
        public byte Level { get; }
        public Class Class { get; }
        public byte Awaken { get; }
        public uint Photo { get; }
        public ushort Location { get; }

        //internal protected SRFMember()
        //{
        //}
    }
}
