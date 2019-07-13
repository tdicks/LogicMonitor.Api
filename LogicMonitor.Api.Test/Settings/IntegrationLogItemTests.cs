using LogicMonitor.Api.Filters;
using LogicMonitor.Api.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LogicMonitor.Api.Test.Settings
{

	public class IntegrationLogItemTests : TestWithOutput
	{
		public IntegrationLogItemTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetAll()
		{
			var accessIntegrationLogItems = await PortalClient
				.GetAllAsync<IntegrationLogItem>()
				.ConfigureAwait(false);

			// Make sure that some are returned
			Assert.True(accessIntegrationLogItems.Count > 0);

			// TODO Make sure that all have Unique Ids
			//Assert.False(accessIntegrationLogItems.Select(a => a.Id).HasDuplicates());

			Assert.True(accessIntegrationLogItems.Count > 50);
		}

		[Fact]
		public async void GetLastTwoDays()
		{
			const int skip = 0;
			const int take = 1000;
			var utcNow = DateTimeOffset.UtcNow;
			var accessIntegrationLogItems = await PortalClient
				.GetAllAsync(new Filter<IntegrationLogItem>
				{
					Skip = skip,
					Take = take,
					FilterItems = new List<FilterItem<IntegrationLogItem>>
					{
						//new Ge<IntegrationLogItem>(nameof(IntegrationLogItem.HappenedOnMsTimeStampUtc), utcNow.AddDays(-2).ToUnixTimeMilliseconds()),
						//new Lt<IntegrationLogItem>(nameof(IntegrationLogItem.HappenedOnMsTimeStampUtc), utcNow.ToUnixTimeMilliseconds())
					},
					Order = new Order<IntegrationLogItem>
					{
						Property = nameof(IntegrationLogItem.HappenedOnMsTimeStampUtc),
						Direction = OrderDirection.Asc
					}
				}).ConfigureAwait(false);

			// Make sure that some are returned
			Assert.True(accessIntegrationLogItems.Count > 0);

			// Make sure that all have Unique Ids
			Assert.False(accessIntegrationLogItems.Select(a => a.Id).HasDuplicates());
		}
	}
}