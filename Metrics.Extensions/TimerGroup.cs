using System;

namespace Metrics
{
    public class TimerGroup<TKey> : MetricGroup<Timer, TKey>
    {
        public TimerGroup(
            Func<TKey, string> nameFactory, 
            Unit unit,
            SamplingType samplingType = SamplingType.FavourRecent,
            TimeUnit rateUnit = TimeUnit.Seconds,
            TimeUnit durationUnit = TimeUnit.Milliseconds,
            MetricTags tags = default(MetricTags))
            : base((name) => Metric.Timer(name, unit, samplingType, rateUnit, durationUnit, tags), nameFactory)
        {
        }

        public IDisposable NewContext(TKey key, string userContext = null)
        {
            var timer = GetOrAdd(key);
            return timer.NewContext(userContext);
        }

        public void Reset(TKey key)
        {
            Timer timer;
            if (TryGetValue(key, out timer))
            {
                timer.Reset();
            }
        }

        public void Time(TKey key, Action action)
        {
            GetOrAdd(key).Time(action);
        }
        public TResult Time<TResult>(TKey key, Func<TResult> func)
        {
            return GetOrAdd(key).Time(func);
        }
    }
}