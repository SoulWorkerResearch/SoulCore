using System;

namespace SoulCore.Data.Bin.Table
{
    public interface ITableEntity<TId> where TId : IConvertible
    {
        TId Id { get; }
    }
}