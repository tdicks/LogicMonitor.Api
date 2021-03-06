using LogicMonitor.Api.ScheduledDownTimes;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LogicMonitor.Api

{
	/// <summary>
	///    Scheduled Down Time portal interaction
	/// </summary>
	public partial class PortalClient
	{
		/// <summary>
		///    Get Scheduled Down Times
		/// </summary>
		/// <param name="scheduledDownTimeFilter">The SDT filter</param>
		/// <param name="cancellationToken">The cancellation token</param>
		/// <returns>Existing, future and historic scheduled down times based on the provided filter.</returns>
		[Obsolete("Use GetAsync(Filter<ScheduledDownTime>) instead", true)]
		public async Task<List<ScheduledDownTime>> GetScheduledDownTimesAsync(
			ScheduledDownTimeFilter scheduledDownTimeFilter,
			CancellationToken cancellationToken = default)
			=> (await FilteredGetAsync("sdt/sdts", scheduledDownTimeFilter.GetFilter(), cancellationToken).ConfigureAwait(false)).Items;
	}
}