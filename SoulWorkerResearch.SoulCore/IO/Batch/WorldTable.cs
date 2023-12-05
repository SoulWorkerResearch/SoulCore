//using System.Xml.Linq;
//using Microsoft.Extensions.OptionList;
//using OpenWorker.Domain.Configuration;
//using OpenWorker.IO.FS.VBatch;

//namespace OpenWorker.IO.FS.World;

//public sealed class WorldTable : IDisposable
//{
//    public Root ReadBatch(string file)
//    {
//        using Stream stream = _data.GetInputStream(_data.GetEntry($"World/Table/{file}.vbatch"));

//        XmlDocument x = new();
//        x.Load(stream);

//        return new Root(x.DocumentElement ?? throw new ApplicationException());
//    }

//    public void Dispose() => ((IDisposable)_data).Dispose();

//    public WorldTable(IOptions<InfrastructureConfiguration> configuration) => _data = new WorldFile(configuration);

//    private readonly WorldFile _data;
//}



