using System.Xml.Linq;
using System.Xml.XPath;

namespace SoulWorkerResearch.SoulCore.IO.Batch;

public sealed record File
{
    public EventBox.EventBox EventBox { get; }
    public EventPoint.EventPoint EventPoint { get; }

    public static async ValueTask<File> FromStream(Stream stream, CancellationToken cancellationToken = default)
    {
        var x = await XDocument.LoadAsync(stream, LoadOptions.None, cancellationToken);
        return new File(x);
    }

    private File(XDocument x)
    {
        EventBox = new(x.XPathSelectElement("root/Batchs [@eventtype='EventBox']") ?? throw new ApplicationException());
        EventPoint = new(x.XPathSelectElement("root/Batchs [@eventtype='EventPoint']") ?? throw new ApplicationException());
    }
}
