using System.Net;
using SoulWorkerResearch.SoulCore.DataTypes.Entities;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct MapValue
{
    public int Account { get; init; }
    public int Person { get; init; }
    public int Server { get; init; }
    public int Jump { get; init; }
    public int Portal { get; init; }
    public MapEntity Map { get; init; }
    public MapEntity ParentMap { get; init; }
    public IPEndPoint EndPoint { get; init; }
    public LocationValue Location { get; init; }
    public byte Direction { get; init; }

    public MapValue() => EndPoint = new(IPAddress.None, IPEndPoint.MinPort);

    internal MapValue(BinaryReader reader)
    {
        throw new NotImplementedException();
    }
}
