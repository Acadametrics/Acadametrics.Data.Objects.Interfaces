using System;
using System.Collections.Generic;
using Academetrics.Data.Enums;

namespace Academetrics.Data.Objects.Interfaces
{
	public interface IUserClaims : ITableModel
	{
		List<ClaimType> Claims { get; set; }
		Guid InstitutionId { get; set; }
	}
}
