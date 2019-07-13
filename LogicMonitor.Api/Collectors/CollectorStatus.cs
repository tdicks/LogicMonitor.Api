using System.Runtime.Serialization;

namespace LogicMonitor.Api.Collectors
{
	/// <summary>
	/// Collector status
	/// </summary>
	[DataContract]
	public class CollectorStatus
	{
		/// <summary>
		/// The status
		/// </summary>
		[DataMember(Name = "status")]
		public int Status { get; set; }

		/// <summary>
		/// Whether it is down
		/// </summary>
		[DataMember(Name = "isDown")]
		public bool IsDown { get; set; }

		/// <summary>
		/// Whether it is acknowledged
		/// </summary>
		[DataMember(Name = "acked")]
		public bool Acknowledged { get; set; }

		/// <summary>
		/// Whether it is in SDT
		/// </summary>
		[DataMember(Name = "inSDT")]
		public bool InSdt { get; set; }
	}

}