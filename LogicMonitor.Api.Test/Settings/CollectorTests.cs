using LogicMonitor.Api.Collectors;
using Microsoft.Extensions.Logging;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LogicMonitor.Api.Test.Settings
{
	public class CollectorTests : TestWithOutput
	{
		public CollectorTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void ExecuteDebugCommand()
		{
			var debugCommandResponse = await PortalClient.ExecuteDebugCommandAsync(18, "!ping 8.8.8.8").ConfigureAwait(false);

			// Check for valid response
			Assert.NotNull(debugCommandResponse);
			Assert.True(debugCommandResponse.SessionId > 0);
		}

		[Fact]
		public async void ExecuteDebugCommandAndWaitForResult()
		{
			var debugCommandResponse = await PortalClient.ExecuteDebugCommandAndWaitForResultAsync(18, "!ping 8.8.8.8", 20000, 100).ConfigureAwait(false);

			// Check for valid response
			Assert.NotNull(debugCommandResponse);
			Assert.NotEmpty(debugCommandResponse.Output);
			Logger.LogInformation(debugCommandResponse.Output);
		}

		[Fact]
		public async void GetCollectors()
		{
			var collectors = await PortalClient.GetAllAsync<Collector>().ConfigureAwait(false);

			// Make sure that some are returned
			Assert.NotEmpty(collectors);

			// Make sure that all have Unique Ids
			Assert.False(collectors.Select(c => c.Id).HasDuplicates());

			// Get each one by id
			foreach (var collector in collectors)
			{
				var refetchedCollector = await PortalClient.GetAsync<Collector>(collector.Id).ConfigureAwait(false);
				// TODO - make sure they match
			}
		}

		[Fact]
		public async void GetCollector()
		{
			var collectors = await PortalClient.GetAllAsync<Collector>().ConfigureAwait(false);
			Assert.NotNull(collectors);
			Assert.NotEmpty(collectors);
			var refetchedCollector = await PortalClient
				.GetAsync<Collector>(collectors[0].Id)
				.ConfigureAwait(false);

			Assert.NotNull(refetchedCollector);
		}
	}
}