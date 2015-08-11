using System;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface ISubject : ITableModel
	{
		string Description { get; set; }
		string Name { get; set; }
		string SubjectCode { get; set; }
	}
}
