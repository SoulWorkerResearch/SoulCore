namespace SoulWorkerResearch.SoulCore.IO.Res;

internal interface ITableEntry<out TId> where TId : struct
{
    TId Id { get; }
}
