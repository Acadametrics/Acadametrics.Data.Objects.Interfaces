using System;
using System.Collections.Generic;
using Academetrics.Data.Enums;

namespace Academetrics.Data.Objects.Interfaces
{
  public interface IUserPeriods : ITableModel
  {
    Guid InstitutionId { get; set; }
    SortedDictionary<long, string> Periods { get; set; }
    Role Role { get; set; }
    long AddPeriod(IPeriod period);
  }
}