using Academetrics.Data.Enums;
using System;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface IInstitution : ITableModel
	{
		InstitutionType Type { get; set; }
		string Description { get; set; }
		string LogoUrl { get; set; }
		string Url { get; set; }
		string Name { get; set; }
		string TownCity { get; set; }
		string[] SetCodes { get; set; }
	}
}
