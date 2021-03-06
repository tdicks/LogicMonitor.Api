using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LogicMonitor.Api.Topologies
{
	/// <summary>
	/// A Topology
	/// </summary>
	[DataContract]
	public class Topology : NamedItem, IHasEndpoint
	{
		/// <summary>
		///    Whether the item is shareable
		/// </summary>
		[DataMember(Name = "sharable")]
		public bool Shareable { get; set; }

		/// <summary>
		///    The owner
		/// </summary>
		[DataMember(Name = "owner")]
		public string Owner { get; set; }

		/// <summary>
		///    The owner
		/// </summary>
		[DataMember(Name = "views")]
		public List<TopologyView> Views { get; set; }

		/// <summary>
		///    The layout
		/// </summary>
		[DataMember(Name = "layout")]
		public TopologyLayout Layout { get; set; }

		/// <summary>
		/// The REST API endpoint
		/// </summary>
		/// <returns></returns>
		public string Endpoint() => "topology/topologies";
	}
}
