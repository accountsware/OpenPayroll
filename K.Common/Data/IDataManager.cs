using System;
using System.Collections.Generic;
using K.Common.Interfaces;
using K.Common.Patterns;

namespace K.Common.Data
{
	public interface IDataManager : IDisposable
	{
		event EventHandler<OnErrorArgs> ErrorEventHandler;

		int Save<T>(T businessModel) where T : IBaseModel;

		int Update<T>(T businessModel) where T : IBaseModel;

		int Delete(int id);
		
		IList<T> Get<T>(params IListParameter[] parameter) where T : IBaseModel;

		IList<T> GetPaging<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter) where T : IBaseModel;

        bool IsSuccess { get; set; }
        string Message { get; set; }
	}
}
