namespace SoulWorkerResearch.SoulCore.IO.Res;

public interface IEntry<TValue>
    where TValue : class
{
    internal abstract static string TableName { get; }

    internal abstract static TValue CreateInstance(BinaryReader reader);
}
