// CreatedBy	:  kun
// Solution 	:  KYourMovement 
// Projectt		:  K.Common
// FileName		:  BusinessException.cs
// Created Date	:  2013 03 19 6:28 PM

using System;
using System.Text;
using K.Common.Interfaces;

namespace K.Common.Fault
{
	[Serializable]
	public class BusinessException<T> : Exception where T : class, IBaseModel
	{
		public BusinessException(string message)
			: base(message)
		{
		}

		public BusinessException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		public BusinessException(string message, T model)
			: base(message)
		{
			BusinessModel = model;
		}

		public BusinessException(string message, T model, Exception innerException)
			: base(message, innerException)
		{
			BusinessModel = model;
		}

		public override string StackTrace
		{
			get
			{
				var result = new StringBuilder();
				if (BusinessModel != null)
				{
					foreach (var b in BusinessModel.GetType().GetProperties())
					{
						result.AppendLine("\t" + b.Name + ": " + b.GetValue(BusinessModel, null));
					}
				}
				var a = result + base.StackTrace;
				return a;
			}
		}

		public T BusinessModel { get; set; }
	}
}