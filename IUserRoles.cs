using Academetrics.Data.Enums;
using System;
using System.Collections.Generic;

namespace Academetrics.Data.Objects.Interfaces
{
	public interface IUserRoles : ITableModel
	{
		Guid InstitutionId { get; set; }
		List<Role> Roles { get; set; }
	}
}
