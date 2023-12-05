namespace SoulWorkerResearch.SoulCore.IO.ResTable;

public interface ITableEntry<out TId> where TId : struct
{
    TId Id { get; }
}
