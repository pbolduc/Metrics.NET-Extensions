using System;
using Metrics.Reports;

namespace Metrics.Reporters.ApplicationInsights
{
    public static class ApplicationInsightsExtensions
    {
        public static MetricsReports WithApplicationInsights(this MetricsReports reports, TimeSpan interval)
        {
            return reports.WithReport(new ApplicationInsightsReport(), interval);
        }
    }
}
