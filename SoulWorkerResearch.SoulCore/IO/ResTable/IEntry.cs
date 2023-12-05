namespace SoulWorkerResearch.SoulCore.IO.ResTable;

public interface IEntry<TValue> where TValue : class
{
    public static abstract string TableName { get; }

    public static virtual TValue CreateInstance(BinaryReader reader)
    {
        if (Activator.CreateInstance(typeof(TValue), new[] { reader }) is TValue instance)
        {
            return instance;
        }

        throw new ApplicationException();
    }
}
