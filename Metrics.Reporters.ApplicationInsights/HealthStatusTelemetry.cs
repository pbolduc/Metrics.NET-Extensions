using Microsoft.ApplicationInsights.DataContracts;

namespace Metrics.Reporters.ApplicationInsights
{
    internal class HealthStatusTelemetry : MetricTelemetry
    {
        public HealthStatusTelemetry(TelemetryContext context, HealthStatus status)
            : base(context, string.Empty, MetricTags.None)
        {
            
        }

        public override void Serialize(IJsonWriter writer)
        {
        }
    }
}