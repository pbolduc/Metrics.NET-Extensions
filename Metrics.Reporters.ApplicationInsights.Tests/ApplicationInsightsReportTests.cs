using System;
using System.Threading;
using Microsoft.ApplicationInsights.Extensibility;
using Xunit;

namespace Metrics.Reporters.ApplicationInsights.Tests
{
    public class ApplicationInsightsReportTests
    {
        [Fact]
        public void Test()
        {
            TelemetryConfiguration.Active.InstrumentationKey = "9ad01e62-9986-4830-8617-aee6b4dbb590";

            Random random = new Random();
            Metric.Gauge("gauge", () => random.NextDouble() * 100, Unit.None);

            Metric.Config.WithReporting(r => r.WithApplicationInsights(TimeSpan.FromSeconds(1)));


            Thread.Sleep(TimeSpan.FromSeconds(60));
        }

        
    }
}
