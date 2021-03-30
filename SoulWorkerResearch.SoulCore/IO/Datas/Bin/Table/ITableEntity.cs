using System;

namespace SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table
{
    public interface ITableEntity<TId> where TId : IConvertible
    {
        TId Id { get; set; }
    }
}
