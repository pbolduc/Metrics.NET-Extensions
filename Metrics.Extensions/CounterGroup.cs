using System;

namespace Metrics
{
    public class CounterGroup<TKey> : MetricGroup<Counter, TKey>
    {
        public CounterGroup(Func<TKey, string> nameFactory, Unit unit)
            : base((name) => Metric.Counter(name, unit), nameFactory)
        {
        }

        public void Reset(TKey key)
        {
            Counter counter;
            if (TryGetValue(key, out counter))
            {
                counter.Reset();
            }
        }

        public void Increment(TKey key)
        {
            GetOrAdd(key).Increment();
        }

        public void Increment(TKey key, long amount)
        {
            GetOrAdd(key).Increment(amount);
        }

        public void Decrement(TKey key)
        {
            GetOrAdd(key).Decrement();
        }

        public void Decrement(TKey key, long amount)
        {
            GetOrAdd(key).Decrement(amount);
        }
    }
}