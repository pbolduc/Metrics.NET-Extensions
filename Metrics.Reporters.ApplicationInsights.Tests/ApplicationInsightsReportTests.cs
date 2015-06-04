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

            double lastValue = 0;
            Random random = new Random();
            Metric.Gauge("gauge", () =>
            {
                double delta = 10 - random.NextDouble()*20;
                double nextValue = lastValue + delta;
                if (nextValue < 0) nextValue = 0;
                lastValue = nextValue;

                return nextValue;
            }, Unit.None);

            Metric.Config.WithReporting(r => r
                .WithApplicationInsights(TimeSpan.FromSeconds(30))
                .WithFilter(new MetricsReportFilter(/**/)));

            Metric.Config.WithReporting(r => r
                .WithApplicationInsights(TimeSpan.FromSeconds(30), new MetricsReportFilter( /**/)));          


            Thread.Sleep(TimeSpan.FromMinutes(10));
        }

        
    }
}
