using System;
using System.Collections.Generic;

namespace Academetrics.Data.Objects.Interfaces
{
	public interface IClassroom : ITableModel
	{
		//IInstitution Institution { get; set; }
		List<ILocation> Locations { get; set; }
		List<ISetCode> SetCodes { get; set; }
		List<ISubject> Subjects { get; set; }
	}
}
