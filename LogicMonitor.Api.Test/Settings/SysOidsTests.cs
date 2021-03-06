﻿using LogicMonitor.Api.LogicModules;
using Xunit;
using Xunit.Abstractions;

namespace LogicMonitor.Api.Test.Settings
{
	public class SysOidsTests : TestWithOutput
	{
		public SysOidsTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetAll()
		{
			var snmpSysOidMaps = await PortalClient.GetAllAsync<SnmpSysOidMap>().ConfigureAwait(false);
			Assert.NotNull(snmpSysOidMaps);
			Assert.All(snmpSysOidMaps, snmpSysOidMap => Assert.NotNull(snmpSysOidMap.Oid));
			Assert.All(snmpSysOidMaps, snmpSysOidMap => Assert.NotNull(snmpSysOidMap.Categories));
		}
	}
}