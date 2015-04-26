using Microsoft.ApplicationInsights.DataContracts;

namespace Metrics.Reporters.ApplicationInsights
{
    internal class GaugeTelemetry : MetricTelemetry
    {
        private double _value;

        public override void Serialize(IJsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteProperty("name", Name);
            writer.WriteProperty("value", _value);
            writer.WriteEndObject();
        }

        public GaugeTelemetry(TelemetryContext context, string name, double value, Unit unit, MetricTags tags)
            : base(context, name, tags)
        {
            _value = value;
        }
    }
}
