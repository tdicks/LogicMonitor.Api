using System.Runtime.Serialization;

namespace LogicMonitor.Api.Flows
{
	/// <summary>
	/// A Flow
	/// </summary>
	[DataContract]
	public class FlowBandwidth
	{
		/// <summary>
		/// The data type
		/// </summary>
		[DataMember(Name = "deviceDisplayName")]
		public string DisplayName { get; set; }

		/// <summary>
		/// The data type
		/// </summary>
		[DataMember(Name = "dataType")]
		public string DataType { get; set; }

		/// <summary>
		/// Send in MBytes
		/// </summary>
		[DataMember(Name = "send")]
		public long SendMb { get; set; }

		/// <summary>
		/// Receive in MBytes
		/// </summary>
		[DataMember(Name = "receive")]
		public long ReceiveMb { get; set; }

		/// <summary>
		/// Usage in MBytes
		/// </summary>
		[DataMember(Name = "usage")]
		public long UsageMb { get; set; }

		/// <summary>
		/// Returns a string that represents the current object
		/// </summary>
		public override string ToString() => $"{DisplayName}. Send: {SendMb} MB. Receive: {ReceiveMb} MB. Usage: {UsageMb} MB]";
	}
}