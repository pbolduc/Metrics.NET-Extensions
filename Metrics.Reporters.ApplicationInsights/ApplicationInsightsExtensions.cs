using System;
using Metrics.Reports;

namespace Metrics.Reporters.ApplicationInsights
{
    public static class ApplicationInsightsExtensions
    {
        public static MetricsReports WithApplicationInsights(this MetricsReports reports, TimeSpan interval, MetricsReportFilter filter = null)
        {
            return reports.WithReport(new ApplicationInsightsReport(), interval);
        }

        public static MetricsReports Where(this MetricsReports reports)
        {
            return reports;
        }

        public static MetricsReports WithFilter(this MetricsReports reports, MetricsReportFilter filter)
        {
            return reports;
        }
    }

    public class MetricsReportFilter
    {
        public static MetricsReportFilter None = new MetricsReportFilter();
    }
}
