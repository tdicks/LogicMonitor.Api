using System.Runtime.Serialization;

namespace LogicMonitor.Api.Dashboards
{
	/// <summary>
	/// A Saved Map widget
	/// </summary>
	[DataContract]
	public class SavedMapWidget : Widget
	{
		/// <summary>
		///     The display settings
		/// </summary>
		[DataMember(Name = "displaySettings")]
		public object DisplaySettings { get; set; }

		/// <summary>
		///     The saved map Id
		/// </summary>
		[DataMember(Name = "savedMapId")]
		public int SavedMapId { get; set; }

		/// <summary>
		///     The scale
		/// </summary>
		[DataMember(Name = "scale")]
		public float Scale { get; set; }

		/// <summary>
		///     The saved map name
		/// </summary>
		[DataMember(Name = "savedMapName")]
		public string SavedMapName { get; set; }

		/// <summary>
		///     The saved map group name
		/// </summary>
		[DataMember(Name = "savedMapGroupName")]
		public string SavedMapGroupName { get; set; }
	}

}