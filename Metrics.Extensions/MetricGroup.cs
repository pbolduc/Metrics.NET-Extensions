using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Metrics
{
    public abstract class MetricGroup<TMetric, TKey>
    {
        private readonly ConcurrentDictionary<string, TMetric> _metrics;
        private readonly Func<string, TMetric> _metricFactory;
        private readonly Func<TKey, string> _nameFactory;

        protected MetricGroup(Func<string, TMetric> metricFactory, Func<TKey, string> nameFactory)
        {
            if (metricFactory == null) throw new ArgumentNullException("metricFactory");
            if (nameFactory == null) throw new ArgumentNullException("nameFactory");

            _metrics = new ConcurrentDictionary<string, TMetric>();
            _metricFactory = metricFactory;
            _nameFactory = nameFactory;
        }

        protected TMetric GetOrAdd(TKey key)
        {
            string name = _nameFactory(key);
            return _metrics.GetOrAdd(name, _metricFactory);
        }

        protected bool TryGetValue(TKey key, out TMetric metric)
        {
            string name = _nameFactory(key);
            return _metrics.TryGetValue(name, out metric);
        }

        protected ICollection<TMetric> Metrics
        {
            get { return _metrics.Values; }
        }
    }
}
