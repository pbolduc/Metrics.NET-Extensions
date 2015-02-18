using System;

namespace Metrics
{
    public class HistogramGroup<TKey> : MetricGroup<Histogram, TKey>
    {
        public HistogramGroup(
            Func<TKey, string> nameFactory, 
            Unit unit, 
            SamplingType samplingType = SamplingType.FavourRecent,
            MetricTags tags = default(MetricTags))
            : base((name) => Metric.Histogram(name, unit, samplingType, tags), nameFactory)
        {
        }

        public void Update(TKey key, long value, string userValue = null)
        {
            GetOrAdd(key).Update(value, userValue);
        }

        public void Reset(TKey key)
        {
            Histogram histogram;
            if (TryGetValue(key, out histogram))
            {
                histogram.Reset();
            }
        }

        public void Reset()
        {
            foreach (var histogram in Metrics)
            {
                histogram.Reset();
            }
        }
    }
}