using System;

namespace SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table
{
    public interface ITableEntity<TId> where TId : struct
    {
        TId Id { get; set; }
    }
}
