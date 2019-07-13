using LogicMonitor.Api.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LogicMonitor.Api.Reports
{
	/// <summary>
	/// A hosts value type
	/// </summary>
	[JsonConverter(typeof(TolerantStringEnumConverter))]
	public enum HostsValType
	{
		/// <summary>
		/// Group
		/// </summary>
		[EnumMember(Value = "group")]
		Group,

		/// <summary>
		/// Host
		/// </summary>
		[EnumMember(Value = "host")]
		Host
	}
}