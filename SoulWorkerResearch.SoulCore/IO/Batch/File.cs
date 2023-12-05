using SoulWorkerResearch.SoulCore.IO.Batch.Entities;
using System.Xml.Linq;
using System.Xml.XPath;

namespace SoulWorkerResearch.SoulCore.IO.Batch;

public sealed record File
{
    private File(XNode document)
    {
        EventBox = new EventBox(document.XPathSelectElement("root/Batchs [@eventtype='EventBox']") ?? throw new ApplicationException());
        EventPoint = new EventPoint(document.XPathSelectElement("root/Batchs [@eventtype='EventPoint']") ?? throw new ApplicationException());
    }

    public EventBox EventBox { get; }
    public EventPoint EventPoint { get; }

    public static async ValueTask<File> FromStream(Stream stream, CancellationToken ct = default)
    {
        var document = await XDocument.LoadAsync(stream, LoadOptions.None, ct);
        return new File(document);
    }
}
