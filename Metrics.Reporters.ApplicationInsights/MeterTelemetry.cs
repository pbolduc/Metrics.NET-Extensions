using Metrics.MetricData;
using Microsoft.ApplicationInsights.DataContracts;

namespace Metrics.Reporters.ApplicationInsights
{
    internal class MeterTelemetry : MetricTelemetry
    {
        public override void Serialize(IJsonWriter writer)
        {
        }

        public MeterTelemetry(TelemetryContext context, string name, MeterValue value, Unit unit, TimeUnit rateUnit, MetricTags tags)
            : base(context, name, tags)
        {
        }
    }
}