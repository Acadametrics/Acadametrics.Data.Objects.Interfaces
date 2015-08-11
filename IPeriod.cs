using Academetrics.Data.Enums;
using System;
using System.Collections.Generic;

namespace Academetrics.Data.Objects.Interfaces
{
	public interface IPeriod : ITableModel
	{
		Guid? InstitutionId { get; set; }
		string PeriodCode { get; set; }
		PeriodType PeriodType { get; set; }
		DateTime Start { get; set; }
		DateTime End { get; set; }		
		string Name { get; set; }
		string Description { get; set; }
		string KeyDetails { get; set; }
		IList<IHomeActivity> Homework { get; set; }
		IClassroom Classroom { get; set; }
		IRegister Register { get; set; }
	}
}