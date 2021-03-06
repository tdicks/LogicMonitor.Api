using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LogicMonitor.Api.Settings
{
	/// <summary>
	/// An external alert destination
	/// </summary>
	[DataContract]
	public class RecipientGroup : DescribedItem, IHasEndpoint
	{
		/// <summary>
		/// The group name
		/// </summary>
		[DataMember(Name = "groupName")]
		public string GroupName { get; set; }

		/// <summary>
		/// The recipients
		/// </summary>
		[DataMember(Name = "recipients")]
		public List<AlertRecipient> Recipients { get; set; }

		/// <summary>
		///    The endpoint
		/// </summary>
		/// <returns></returns>
		public string Endpoint() => "setting/recipientgroups";
	}
}