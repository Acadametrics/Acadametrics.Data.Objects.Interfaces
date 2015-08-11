using System;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface IClassroom
	{
		IInstitution Institution { get; set; }
		System.Collections.Generic.List<ILocation> Locations { get; set; }
		System.Collections.Generic.List<ISetCode> SetCodes { get; set; }
		System.Collections.Generic.List<ISubject> Subjects { get; set; }
	}
}
