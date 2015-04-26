using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Metrics.MetricData;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;

namespace Metrics.Reporters.ApplicationInsights
{
    internal abstract class MetricTelemetry : ITelemetry, IJsonSerializable, ISupportProperties
    {
        private string _name;
        private MetricTags _tags;

        private TelemetryContext _context;
        private IDictionary<string, string> _properties;

        protected MetricTelemetry(TelemetryContext context, string name, MetricTags tags)
        {
            _name = name;
            _tags = tags;
            _context = context;
            _properties = new ConcurrentDictionary<string, string>();
        }

        public DateTimeOffset Timestamp { get; set; }

        public TelemetryContext Context
        {
            get { return _context; }
        }

        public string Sequence { get; set; }

        public string Name { get { return _name; } }

        protected void WriteTags(IJsonWriter writer)
        {
            if (_tags.Tags.Length != 0)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartArray();
                for (int i = 0; i < _tags.Tags.Length; i++)
                {
                    if (i != 0)
                    {
                        writer.WriteComma();
                    }

                    var tag = _tags.Tags[i];
                    writer.WriteRawValue(tag);
                }
                writer.WriteEndArray();
            }
        }

        public IDictionary<string, string> Properties
        {
            get { return _properties; }
        }

        public static ITelemetry CreateTelemetry(TelemetryContext context, string name, double value, Unit unit, MetricTags tags)
        {
            return new GaugeTelemetry(context, name, value, unit, tags);
        }

        public static ITelemetry CreateTelemetry(TelemetryContext context, string name, CounterValue value, Unit unit, MetricTags tags)
        {
            return new CounterTelemetry(context, name, value, unit, tags);
        }

        public static ITelemetry CreateTelemetry(TelemetryContext context, string name, MeterValue value, Unit unit, TimeUnit rateUnit, MetricTags tags)
        {
            return new MeterTelemetry(context, name, value, unit, rateUnit, tags);
        }

        public static ITelemetry CreateTelemetry(TelemetryContext context, string name, HistogramValue value, Unit unit, MetricTags tags)
        {
            return new HistogramTelemetry(context, name, value, unit, tags);
        }

        public static ITelemetry CreateTelemetry(TelemetryContext context, string name, TimerValue value, Unit unit, TimeUnit rateUnit, TimeUnit durationUnit, MetricTags tags)
        {
            return new TimerTelemetry(context, name, value, unit, rateUnit, durationUnit, tags);
        }

        public static ITelemetry CreateTelemetry(TelemetryContext context, HealthStatus status)
        {
            return new HealthStatusTelemetry(context, status);
        }

        public abstract void Serialize(IJsonWriter writer);

        public void Sanitize()
        {
        }
    }
}