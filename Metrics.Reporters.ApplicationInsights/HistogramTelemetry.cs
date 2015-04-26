using Metrics.MetricData;
using Microsoft.ApplicationInsights.DataContracts;

namespace Metrics.Reporters.ApplicationInsights
{
    internal class HistogramTelemetry : MetricTelemetry
    {
        public override void Serialize(IJsonWriter writer)
        {
        }

        public HistogramTelemetry(TelemetryContext context, string name, HistogramValue value, Unit unit, MetricTags tags)
            : base(context, name, tags)
        {
        }
    }
}