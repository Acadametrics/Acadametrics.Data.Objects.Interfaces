using System;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface IUserCredentials : ITableModel
	{
		string Password { get; set; }
		string Salt { get; set; }
	}
}
