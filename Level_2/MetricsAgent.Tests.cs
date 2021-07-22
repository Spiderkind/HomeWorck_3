using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgent.Tests
{
    public class RamMetricsControllerUnitTests
    {
        private RamMetricsController controller;

        public RamMetricsControllerUnitTests()
        {
            controller = new RamMetricsController();
        }
        [Fact]
        public void GetFreeRam_ReturnsOk()
        {
            var result = controller.GetFreeRam();
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
    public class NetworkMetricsControllerUnitTests
    {
        private NetworkMetricsController controller;

        public NetworkMetricsControllerUnitTests()
        {
            controller = new NetworkMetricsController();
        }
        [Fact]
        public void GetNetwork_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            var result = controller.GetNetwork(fromTime, toTime);
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
    public class HddMetricsControllerUnitTests
    {
        private HddMetricsController controller;

        public HddMetricsControllerUnitTests()
        {
            controller = new HddMetricsController();
        }
        [Fact]
        public void GetFreeSapce_ReturnsOk()
        {
            var result = controller.GetFreeSapce();
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
    public class DotNetMetricsControllerUnitTests
    {
        private DotNetMetricsController controller;

        public DotNetMetricsControllerUnitTests()
        {
            controller = new DotNetMetricsController();
        }
        [Fact]
        public void GetErrors_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            var result = controller.GetErrors(fromTime, toTime);
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
