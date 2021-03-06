using System.Runtime.Serialization;

namespace LogicMonitor.Api
{
	/// <summary>
	/// A device group event source
	/// </summary>
	[DataContract]
	public class DeviceGroupEventSource
	{
		/// <summary>
		/// The EventSource Id
		/// </summary>
		[DataMember(Name = "eventSourceId")]
		public int EventSourceId { get; set; }

		/// <summary>
		/// The DeviceGroup Id
		/// </summary>
		[DataMember(Name = "deviceGroupId")]
		public int DeviceGroupId { get; set; }

		/// <summary>
		/// Whether to stop monitoring
		/// </summary>
		[DataMember(Name = "stopMonitoring")]
		public bool StopMonitoring { get; set; }

		/// <summary>
		/// Whether to disable alerting
		/// </summary>
		[DataMember(Name = "disableAlerting")]
		public bool DisableAlerting { get; set; }

		/// <summary>
		/// The DataSource unique name
		/// </summary>
		[DataMember(Name = "eventSourceName")]
		public string EventSourceName { get; set; }

		/// <summary>
		/// The DataSourceGroup Name
		/// </summary>
		[DataMember(Name = "eventSourceGroupName")]
		public string EventSourceGroupName { get; set; }
	}
}