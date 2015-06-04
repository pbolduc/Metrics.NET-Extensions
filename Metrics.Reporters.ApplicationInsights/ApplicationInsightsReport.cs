using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Metrics.MetricData;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace Metrics.Reporters.ApplicationInsights
{
    public class ApplicationInsightsReport : BaseReport
    {
        private TelemetryClient _client;
        private bool _enabled;

        public ApplicationInsightsReport()
        {
            if (!string.IsNullOrWhiteSpace(TelemetryConfiguration.Active.InstrumentationKey))
            {
                _client = LazyInitializer.EnsureInitialized(ref _client, () => new TelemetryClient(TelemetryConfiguration.Active));
                Enable();                
            }
        }

        private bool Enabled { get { return _enabled; } }

        private void Enable()
        {
            _enabled = true;
        }

        private DateTime CurrentTimestamp { get { return DateTime.UtcNow; } }
        private TelemetryAdapter _telemetryAdapter = new TelemetryAdapter();

        private void Track(IEnumerable<MetricTelemetry> telemetry)
        {
            foreach (var item in telemetry)
            {
                _client.Track(item);
            }
        }

        protected override void ReportGauge(string name, double value, Unit unit, MetricTags tags)
        {
            if (Enabled)
            {
                Track(_telemetryAdapter.AsTelemetry(name, value, unit, tags));
            }
        }

        protected override void ReportCounter(string name, CounterValue value, Unit unit, MetricTags tags)
        {
            if (Enabled)
            {
                Track(_telemetryAdapter.AsTelemetry(name, value, unit, tags));
            }
        }

        protected override void ReportMeter(string name, MeterValue value, Unit unit, TimeUnit rateUnit, MetricTags tags)
        {
            if (Enabled)
            {
                Track(_telemetryAdapter.AsTelemetry(name, value, unit, rateUnit, tags));
            }
        }

        protected override void ReportHistogram(string name, HistogramValue value, Unit unit, MetricTags tags)
        {
            if (Enabled)
            {
                Track(_telemetryAdapter.AsTelemetry(name, value, unit, tags));
            }
        }

        protected override void ReportTimer(string name, TimerValue value, Unit unit, TimeUnit rateUnit, TimeUnit durationUnit, MetricTags tags)
        {
            if (Enabled)
            {
                Track(_telemetryAdapter.AsTelemetry(name, value, unit, rateUnit, durationUnit, tags));
            }
        }

        protected override void ReportHealth(HealthStatus status)
        {
            //if (Enabled)
            //{
            //    var telemetry = CustomMetricTelemetry.CreateTelemetry(Context, status);
            //    _client.Track(telemetry);
            //}

            //_client.TrackEvent(status.);
        }
    }

    public class TelemetryAdapter
    {
        public IEnumerable<MetricTelemetry> AsTelemetry(string name, double value, Unit unit, MetricTags tags)
        {
            if (!double.IsNaN(value) && !double.IsInfinity(value))
            {
                yield return new MetricTelemetry(name, value);
            }
        }

        public IEnumerable<MetricTelemetry> AsTelemetry(string name, CounterValue value, Unit unit, MetricTags tags)
        {
            if (value.Items.Length == 0)
            {
                yield return new MetricTelemetry(name, value.Count);
            }
            else
            {
                yield return new MetricTelemetry(name + " " + "Total", value.Count);

                foreach (var item in value.Items)
                {
                    yield return new MetricTelemetry(name + " " + item.Item, value.Count);
                    yield return new MetricTelemetry(name + " " + item.Item + " "+ "Percent", item.Percent);
                }
            }
        }

        public IEnumerable<MetricTelemetry> AsTelemetry(string name, MeterValue value, Unit unit, TimeUnit rateUnit, MetricTags tags)
        {
            return Enumerable.Empty<MetricTelemetry>();
        }

        public IEnumerable<MetricTelemetry> AsTelemetry(string name, HistogramValue value, Unit unit, MetricTags tags)
        {
            return Enumerable.Empty<MetricTelemetry>();
        }

        public IEnumerable<MetricTelemetry> AsTelemetry(string name, TimerValue value, Unit unit, TimeUnit rateUnit, TimeUnit durationUnit, MetricTags tags)
        {
            return Enumerable.Empty<MetricTelemetry>();
        }
    }
}
