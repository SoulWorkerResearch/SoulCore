namespace SoulWorkerResearch.SoulCore.IO.ResTable;

internal interface ITableEntry<out TId> where TId : struct
{
    TId Id { get; }
}
