using System;
using System.Collections.Generic;
using K.Common.Patterns;

namespace K.Common.Interfaces
{
    public interface IDataPaging : IDisposable
    {
        IList<T> GetPaging<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter) where T : IBaseModel;
    }
}
