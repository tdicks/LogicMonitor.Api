using LogicMonitor.Api.Filters;
using LogicMonitor.Api.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LogicMonitor.Api.Test.Settings
{
	public class LogItemTests : TestWithOutput
	{
		public LogItemTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetAll()
		{
			var accessLogItems = await PortalClient
				.GetAllAsync<LogItem>()
				.ConfigureAwait(false);

			// Make sure that some are returned
			Assert.True(accessLogItems.Count > 0);

			// TODO Make sure that all have Unique Ids
			//Assert.False(accessLogItems.Select(a => a.Id).HasDuplicates());

			Assert.True(accessLogItems.Count > 50);
		}

		[Fact]
		public async void GetLastTwoDays()
		{
			const int skip = 0;
			const int take = 1000;
			var utcNow = DateTimeOffset.UtcNow;
			var accessLogItems = await PortalClient
				.GetAllAsync(new Filter<LogItem>
				{
					Skip = skip,
					Take = take,
					FilterItems = new List<FilterItem<LogItem>>
					{
						new Ge<LogItem>(nameof(LogItem.HappenedOnTimeStampUtc), utcNow.AddDays(-2).ToUnixTimeSeconds()),
						new Lt<LogItem>(nameof(LogItem.HappenedOnTimeStampUtc), utcNow.ToUnixTimeSeconds())
					},
					Order = new Order<LogItem>
					{
						Property = nameof(LogItem.HappenedOnTimeStampUtc),
						Direction = OrderDirection.Asc
					}
				}).ConfigureAwait(false);

			// Make sure that some are returned
			Assert.True(accessLogItems.Count > 0);

			// Make sure that all have Unique Ids
			Assert.False(accessLogItems.Select(a => a.Id).HasDuplicates());
		}
	}
}