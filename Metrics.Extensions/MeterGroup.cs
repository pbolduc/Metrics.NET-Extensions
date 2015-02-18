using System;

namespace Metrics
{
    public class MeterGroup<TKey> : MetricGroup<Counter, TKey>
    {
        public MeterGroup(Func<string, Counter> metricFactory, Func<TKey, string> nameFactory) 
            : base(metricFactory, nameFactory)
        {
        }
    }
}