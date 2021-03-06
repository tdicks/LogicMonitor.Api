using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LogicMonitor.Api.Collectors
{
	/// <summary>
	///     A LogicMonitor Collector Group creation DTO
	/// </summary>
	[DataContract]
	public class CollectorGroupCreationDto : CreationDto<CollectorGroup>
	{
		/// <summary>
		///     The name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }

		/// <summary>
		///     The description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }

		/// <summary>
		///     The custom properties
		/// </summary>
		[DataMember(Name = "customProperties")]
		public List<Property> CustomProperties { get; set; }
	}
}