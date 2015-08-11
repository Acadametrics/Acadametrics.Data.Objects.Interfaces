using System;
using System.Collections.Generic;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface ISetCodeUsers : ITableModel
	{
		string SetCode { get; set; }
		IList<Guid> Users { get; set; }
	}
}
