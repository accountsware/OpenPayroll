using System;
using System.Collections.Generic;
using K.Common.Interfaces;

namespace K.Common.Data
{
	public interface IDataManager : IDisposable
	{
		int Save<T>(T businessModel) where T : IBaseModel;
		int Update<T>(T businessModel) where T : IBaseModel;
		int Delete(int id);
		IEnumerable<T> GetAll<T>() where T : IBaseModel;
		IEnumerable<T> Get<T>(params IListParameter[] parameter) where T : IBaseModel;
		T GetSingle<T>(params IListParameter[] parameter) where T : IBaseModel;
		IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter) where T : IBaseModel;
	}
}
