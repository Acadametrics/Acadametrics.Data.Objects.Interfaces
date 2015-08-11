using System;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface ISetCode : ITableModel
	{
		string ClassCode { get; set; }
		string Code { get; set; }
		string Description { get; set; }
		string Name { get; set; }
		string SubjectCode { get; set; }
		string YearCode { get; set; }
	}
}
