using System;

namespace SoulCore.Data.Bin.Table.KR
{
    public interface ITableEntity<TId> where TId : IConvertible
    {
        TId Id { get; }
    }
}