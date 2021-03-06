using System.Runtime.Serialization;

namespace LogicMonitor.Api.Dashboards
{
	/// <summary>
	///     Complex graph widget
	/// </summary>
	[DataContract]
	public class CustomGraphWidget : GraphWidget
	{
		/// <summary>
		/// The graph info
		/// </summary>
		[DataMember(Name = "graphInfo")]
		public CustomGraphWidgetGraphInfo GraphInfo { get; set; }

		/// <summary>
		///     The display settings
		/// </summary>
		[DataMember(Name = "displaySettings")]
		public object DisplaySettings { get; set; }
	}
}