using System.Runtime.Serialization;

namespace LogicMonitor.Api.Alerts
{
	/// <summary>
	/// The total alert stats for the logged-in user
	/// </summary>
	[DataContract]
	public class AlertStat : IHasSingletonEndpoint
	{
		/// <summary>
		/// The warning count
		/// </summary>
		[DataMember(Name = "warns")]
		public int WarningCount { get; set; }

		/// <summary>
		/// The error count
		/// </summary>
		[DataMember(Name = "errors")]
		public int ErrorCount { get; set; }

		/// <summary>
		/// The critical count
		/// </summary>
		[DataMember(Name = "criticals")]
		public int CriticalCount { get; set; }

		/// <summary>
		/// The Website warning count
		/// </summary>
		[DataMember(Name = "websiteWarns")]
		public int WebsiteWarningCount { get; set; }

		/// <summary>
		/// The Website error count
		/// </summary>
		[DataMember(Name = "websiteErrors")]
		public int WebsiteErrorCount { get; set; }

		/// <summary>
		/// The Website critical count
		/// </summary>
		[DataMember(Name = "websiteCriticals")]
		public int WebsiteCriticalCount { get; set; }

		/// <summary>
		/// The dead host count
		/// </summary>
		[DataMember(Name = "deadhosts")]
		public int DeadDeviceCount { get; set; }

		/// <summary>
		/// The count of alerts in scheduled down time
		/// </summary>
		[DataMember(Name = "sdtAlerts")]
		public int SdtAlertCount { get; set; }

		/// <summary>
		/// The total count of alerts
		/// </summary>
		[DataMember(Name = "totalAlerts")]
		public int TotalAlertCount { get; set; }

		/// <summary>
		/// The total count of alerts, including those in SDT
		/// </summary>
		[DataMember(Name = "alertTotalIncludeInSdt")]
		public bool IsIncludingSdt { get; set; }

		/// <summary>
		/// The total count of alerts, including those in SDT
		/// </summary>
		[DataMember(Name = "alertTotalIncludeInAck")]
		public bool IsIncludingAcknowledged { get; set; }

		/// <summary>
		/// The total count of alerts
		/// </summary>
		[DataMember(Name = "ackAlerts")]
		public int AcknowledgedAlertCount { get; set; }

		/// <summary>
		///    The endpoint
		/// </summary>
		/// <returns></returns>
		public string Endpoint() => "alert/stat";
	}
}