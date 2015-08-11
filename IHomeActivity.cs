using Academetrics.Data.Enums;
using System;

namespace Academetrics.Data.Objects.Interfaces
{
	public interface IHomeActivity
	{
		string Description { get; set; }
		DateTime DueDate { get; set; }
		string Title { get; set; }
		HomeActivityType Type { get; set; }
	}
}
