using Academetrics.Data.Enums;
using System;

namespace Academetrics.Data.Objects.Interfaces
{
	public interface IHomeActivity : ITableModel
  {
		string Description { get; set; }
    DateTime SetDateTime { get; set; }
    DateTime DueDate { get; set; }
		string Title { get; set; }
		HomeActivityType Type { get; set; }
	}
}
