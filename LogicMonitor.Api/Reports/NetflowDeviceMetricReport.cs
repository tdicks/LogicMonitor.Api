using System.Runtime.Serialization;

namespace LogicMonitor.Api.Reports
{
	/// <summary>
	/// A NetflowDeviceMetric report
	/// </summary>
	[DataContract]
	public class NetflowDeviceMetricReport : DateRangeReport
	{
		/// <summary>
		/// The hosts value
		/// </summary>
		[DataMember(Name = "hostsVal")]
		public string HostsVal { get; set; }

		/// <summary>
		/// The hosts value type
		/// </summary>
		[DataMember(Name = "hostsValType")]
		public HostsValType HostsValType { get; set; }

		/// <summary>
		/// Whether to include DNS mappings
		/// </summary>
		[DataMember(Name = "includeDNSMappings")]
		public bool IncludeDnsMappings { get; set; }
	}
}