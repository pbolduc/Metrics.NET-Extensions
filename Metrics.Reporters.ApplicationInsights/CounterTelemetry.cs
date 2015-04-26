using Metrics.MetricData;
using Microsoft.ApplicationInsights.DataContracts;

namespace Metrics.Reporters.ApplicationInsights
{
    internal class CounterTelemetry : MetricTelemetry
    {
        public override void Serialize(IJsonWriter writer)
        {
        }

        public CounterTelemetry(TelemetryContext context, string name, CounterValue value, Unit unit, MetricTags tags)
            : base(context, name, tags)
        {
        }
    }
}