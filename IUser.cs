using Academetrics.Data.Enums;
using System;
using System.Collections.Generic;

namespace Academetrics.Data.Objects.Interfaces
{
  public interface IUser : ITableModel
	{
		int Age { get; set; }
		IList<Guid> Children { get; set; }
		int DateOfBirth { get; set; }
		int DayOfBirth { get; set; }
		string Email { get; set; }
		string FirstName { get; set; }
		Gender Gender { get; set; }
		string Initials { get; set; }
		IList<Guid> Institutions { get; set; }
		string LastName { get; set; }
		int MonthOfBirth { get; set; }
		IList<Guid> Parents { get; set; }
		string Salutation { get; set; }
		string UserName { get; set; }
		int YearOfBirth { get; set; }
	}
}
