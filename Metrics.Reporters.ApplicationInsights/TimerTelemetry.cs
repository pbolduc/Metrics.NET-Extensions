using Metrics.MetricData;
using Microsoft.ApplicationInsights.DataContracts;

namespace Metrics.Reporters.ApplicationInsights
{
    internal class TimerTelemetry : MetricTelemetry
    {
        public override void Serialize(IJsonWriter writer)
        {
        }

        public TimerTelemetry(TelemetryContext context, string name, TimerValue value, Unit unit, TimeUnit rateUnit, TimeUnit durationUnit, MetricTags tags)
            : base(context, name, tags)
        {
        }
    }
}