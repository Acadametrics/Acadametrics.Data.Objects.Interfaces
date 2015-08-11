using System;
namespace Academetrics.Data.Objects.Interfaces
{
	public interface ILocation : ITableModel
	{
		string Building { get; set; }
		string Description { get; set; }
		string Floor { get; set; }
		decimal Latitude { get; set; }
		string LocationCode { get; set; }
		decimal Longtitude { get; set; }
		string Name { get; set; }
		string Room { get; set; }
	}
}
