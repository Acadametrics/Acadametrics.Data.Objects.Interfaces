using System;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface IDay : ITableModel
	{
		DateTime Date { get; set; }
		IPeriodList Periods { get; set; }
	}
}
