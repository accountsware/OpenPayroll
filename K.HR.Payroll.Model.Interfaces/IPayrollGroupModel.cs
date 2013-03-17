using System;
using K.Common.Patterns;

namespace K.HR.Payroll.Model.Interfaces
{
	public interface IPayrollGroupModel : IBaseModel
	{
		/// <summary>
		/// kode Payroll group
		/// </summary>
		string Code { get; set; }
		/// <summary>
		/// Nama Payroll group
		/// </summary>
		string Name { get; set; }
		/// <summary>
		/// Jenis payroll (Bulanan, harian)
		/// </summary>
		string Type { get; set; }
		/// <summary>
		/// Basic salary
		/// </summary>
		decimal Basic { get; set; }
		/// <summary>
		/// Unit perkalian dari basic salary
		/// </summary>
		byte Unit { get; set; }
		/// <summary>
		/// tgl mulai efektif
		/// </summary>
		DateTime StartDate { get; set; }
		/// <summary>
		/// tgl akhir
		/// </summary>
		DateTime EndDate { get; set; }
		/// <summary>
		/// keterangan
		/// </summary>
		string Description { get; set; }
	}
}
