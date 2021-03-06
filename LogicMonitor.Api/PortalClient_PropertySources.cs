using System.Threading;
using System.Threading.Tasks;

namespace LogicMonitor.Api
{
	/// <summary>
	///    PropertySource portal interaction
	/// </summary>
	public partial class PortalClient
	{
		/// <summary>
		///     Gets the JSON for a PropertySource (it is NOT XML!).
		/// </summary>
		/// <param name="propertySourceId">The PropertySource id</param>
		/// <param name="cancellationToken">The cancellation token</param>
		public async Task<string> GetPropertySourceJsonAsync(
			int propertySourceId,
			CancellationToken cancellationToken = default)
			=> (await GetBySubUrlAsync<XmlResponse>($"setting/propertyrules/{propertySourceId}?format=xml", cancellationToken).ConfigureAwait(false))?.Content;
		// Can probably take off format=xml as this never returns XML anyway!
	}
}