using System;
using System.Collections.Generic;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface IPeriodIdList : IList<Guid>
	{
		void GetCodeFromPeriods(IPeriodList periodList);
	}
}
