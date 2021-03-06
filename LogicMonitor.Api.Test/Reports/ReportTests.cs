using LogicMonitor.Api.Filters;
using LogicMonitor.Api.Reports;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace LogicMonitor.Api.Test.Reports
{
	public class ReportTests : TestWithOutput
	{
		public ReportTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetAllReportGroups()
		{
			var reportGroups = await PortalClient.GetAllAsync<ReportGroup>().ConfigureAwait(false);
			Assert.NotNull(reportGroups);
			Assert.NotEmpty(reportGroups);
		}

		[Fact]
		public async void GetAllReports()
		{
			var reports = await PortalClient.GetAllAsync<Report>().ConfigureAwait(false);
			Assert.NotNull(reports);
			Assert.NotEmpty(reports);
		}

		[Fact]
		public async void CrudReportGroups()
		{
			// Delete it if it already exists
			foreach (var existingReportGroup in await PortalClient.GetAllAsync(new Filter<ReportGroup>
			{
				FilterItems = new List<FilterItem<ReportGroup>>
				{
					new Eq<ReportGroup>(nameof(ReportGroup.Name), "Test Name")
				}
			}).ConfigureAwait(false))
			{
				await PortalClient.DeleteAsync(existingReportGroup).ConfigureAwait(false);
			}

			// Create it
			var reportGroup = await PortalClient.CreateAsync(new ReportGroupCreationDto
			{
				Name = "Test Name",
				Description = "Test Description"
			}).ConfigureAwait(false);

			// Delete it again
			await PortalClient.DeleteAsync(reportGroup).ConfigureAwait(false);
		}
	}
}