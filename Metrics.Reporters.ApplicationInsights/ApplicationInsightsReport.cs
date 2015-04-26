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
                this._client = LazyInitializer.EnsureInitialized<TelemetryClient>(ref this._client, () => new TelemetryClient(TelemetryConfiguration.Active));
                //PerformanceCollectorEventSource.Log.ModuleHasBeenInitializedEvent("dummy");
                //this.isFirstRun = false;
                Enable();                
            }
        }

        private bool Enabled { get { return _enabled; } }

        private TelemetryContext Context { get { return _client == null ? null : _client.Context; } }

        private void Enable()
        {
            _enabled = true;
        }

        protected override void ReportGauge(string name, double value, Unit unit, MetricTags tags)
        {
            if (Enabled)
            {
                var telemetry = MetricTelemetry.CreateTelemetry(Context, name, value, unit, tags);
                _client.Track(telemetry);
            }
        }

        protected override void ReportCounter(string name, CounterValue value, Unit unit, MetricTags tags)
        {
            if (Enabled)
            {
                var telemetry = MetricTelemetry.CreateTelemetry(Context, name, value, unit, tags);
                _client.Track(telemetry);
            }
        }

        protected override void ReportMeter(string name, MeterValue value, Unit unit, TimeUnit rateUnit, MetricTags tags)
        {
            if (Enabled)
            {
                var telemetry = MetricTelemetry.CreateTelemetry(Context, name, value, unit, rateUnit, tags);
                _client.Track(telemetry);
            }
        }

        protected override void ReportHistogram(string name, HistogramValue value, Unit unit, MetricTags tags)
        {
            if (Enabled)
            {
                var telemetry = MetricTelemetry.CreateTelemetry(Context, name, value, unit, tags);
                _client.Track(telemetry);
            }
        }

        protected override void ReportTimer(string name, TimerValue value, Unit unit, TimeUnit rateUnit, TimeUnit durationUnit, MetricTags tags)
        {
            if (Enabled)
            {
                var telemetry = MetricTelemetry.CreateTelemetry(Context, name, value, unit, rateUnit, durationUnit, tags);
                _client.Track(telemetry);
            }
        }

        protected override void ReportHealth(HealthStatus status)
        {
            if (Enabled)
            {
                var telemetry = MetricTelemetry.CreateTelemetry(Context, status);
                _client.Track(telemetry);
            }
        }
    }
}
