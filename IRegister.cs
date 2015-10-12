using System;
using System.Collections.Generic;

namespace Academetrics.Data.Objects.Interfaces
{
	public interface IRegister : ITableModel
  {
		IList<Guid> AbsentStudents { get; set; }
		IList<Guid> AbsentSupportWorkers { get; set; }
		IList<Guid> AbsentTeachers { get; set; }
		IList<Guid> AdditionalStudents { get; set; }
		Guid? PrimaryTeacher { get; set; }
		IList<Guid> Students { get; set; }
		IList<Guid> SupportWorkers { get; set; }
		IList<Guid> Teachers { get; set; }
	}
}
