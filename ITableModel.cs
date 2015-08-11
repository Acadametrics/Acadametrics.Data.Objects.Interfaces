using System;

namespace Academetrics.Data.Objects.Interfaces
{
	public interface ITableModel
	{
		Guid Id { get; set; }
		Guid AssigneeId { get; set; }
		string ETag { get; set; }
		string PartitionKey { get; set; }
		string RowKey { get; set; }
		string CacheKey { get; set; }
		string MapKey { get; set; }
		DateTimeOffset Timestamp { get; set; }
		//void AssignEntityKeys(Guid partitionKey, Guid rowKey);
		//void AssignEntityKeys(Guid partitionKey, string rowKey);
		//void AssignEntityKeys(string partitionKey, Guid rowKey);
		//void AssignEntityKeys(string partitionKey, string rowKey);
	}
}
