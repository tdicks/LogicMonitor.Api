using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LogicMonitor.Api.Reports
{
	/// <summary>
	/// A host metric trends report
	/// </summary>
	[DataContract]
	public class DeviceMetricTrendsReport : DateRangeReport
	{
		/// <summary>
		/// The hostsVal
		/// </summary>
		[DataMember(Name = "hostsVal")]
		public string HostsVal { get; set; }

		/// <summary>
		/// The hostsValType
		/// </summary>
		[DataMember(Name = "hostsValType")]
		public string HostsValType { get; set; }

		/// <summary>
		/// The columns to sort by
		/// </summary>
		[DataMember(Name = "sortedBy")]
		public string SortedBy { get; set; }

		/// <summary>
		/// The rowFormat
		/// </summary>
		[DataMember(Name = "rowFormat")]
		public int RowFormat { get; set; }

		/// <summary>
		/// Whether to only show the top 10
		/// </summary>
		[DataMember(Name = "top10Only")]
		public bool Top10Only { get; set; }

		/// <summary>
		/// The metrics
		/// </summary>
		[DataMember(Name = "metrics")]
		public List<DeviceMetricTrendsReportMetric> Metrics { get; set; }

		/// <summary>
		/// The columns
		/// </summary>
		[DataMember(Name = "columns")]
		public List<ReportColumn> Columns { get; set; }
	}
}