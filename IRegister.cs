using System;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface IRegister
	{
		System.Collections.Generic.IList<Guid> AbsentStudents { get; set; }
		System.Collections.Generic.IList<Guid> AbsentSupportWorkers { get; set; }
		System.Collections.Generic.IList<Guid> AbsentTeachers { get; set; }
		System.Collections.Generic.IList<Guid> AdditionalStudents { get; set; }
		Guid? PrimaryTeacher { get; set; }
		System.Collections.Generic.IList<Guid> Students { get; set; }
		System.Collections.Generic.IList<Guid> SupportWorkers { get; set; }
		System.Collections.Generic.IList<Guid> Teachers { get; set; }
	}
}
