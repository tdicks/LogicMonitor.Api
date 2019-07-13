using System.Runtime.Serialization;

namespace LogicMonitor.Api.Logs
{
	/// <summary>
	/// An integration audit log item
	/// </summary>
	[DataContract]
	public class IntegrationLogItem : IHasEndpoint
	{
		/// <summary>
		///    The Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }

		/// <summary>
		///    The alert Id
		/// </summary>
		[DataMember(Name = "alertId")]
		public string AlertId { get; set; }

		/// <summary>
		///    The alert instance Id
		/// </summary>
		[DataMember(Name = "alertInstanceId")]
		public string AlertInstanceId { get; set; }

		/// <summary>
		///    The alert type
		/// </summary>
		[DataMember(Name = "alertType")]
		public int AlertType { get; set; }

		/// <summary>
		///    The integration name
		/// </summary>
		[DataMember(Name = "integrationName")]
		public string IintegrationName { get; set; }

		/// <summary>
		///    The integration type
		/// </summary>
		[DataMember(Name = "integrationType")]
		public string IntegrationType { get; set; }

		/// <summary>
		///    The retry count
		/// </summary>
		[DataMember(Name = "numRetries")]
		public int RetryCount { get; set; }

		/// <summary>
		///    The HTTP response code
		/// </summary>
		[DataMember(Name = "httpResponseCode")]
		public int HttpResponseCode { get; set; }

		/// <summary>
		///    Happened on in ms since the Epoch
		/// </summary>
		[DataMember(Name = "happenedOnMs")]
		public long HappenedOnMsTimeStampUtc { get; set; }

		/// <summary>
		///    URL
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; }

		/// <summary>
		///    Payload
		/// </summary>
		[DataMember(Name = "payload")]
		public string Payload { get; set; }

		/// <summary>
		///    Headers
		/// </summary>
		[DataMember(Name = "headers")]
		public object Headers { get; set; }

		/// <summary>
		///    HTTP response
		/// </summary>
		[DataMember(Name = "httpResponse")]
		public string HttpResponse { get; set; }

		/// <summary>
		///    Integration alert status
		/// </summary>
		[DataMember(Name = "integrationAlertStatus")]
		public string IntegrationAlertStatus { get; set; }

		/// <summary>
		///    Error message
		/// </summary>
		[DataMember(Name = "errorMessage")]
		public string ErrorMessage { get; set; }

		/// <summary>
		///    External ticket Id
		/// </summary>
		[DataMember(Name = "externalTicketId")]
		public string ExternalTicketId { get; set; }

		/// <summary>
		///    Payload format
		/// </summary>
		[DataMember(Name = "payloadFormat")]
		public string PayloadFormat { get; set; }

		/// <summary>
		/// The endpoint
		/// </summary>
		/// <returns></returns>
		public string Endpoint() => "setting/integrations/auditlogs";
	}
}