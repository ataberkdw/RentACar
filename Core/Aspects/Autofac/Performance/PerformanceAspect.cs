using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Castle.DynamicProxy;

namespace Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect : MethodInterception
    {
        private int _interval;
        private Stopwatch _stopwatch;

        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }

        protected override void OnBefore(IInvocation ınvocation)
        {
            _stopwatch.Start();
        }
        protected override void OnAfter(IInvocation ınvocation)
        {
            if (_stopwatch.Elapsed.TotalSeconds > _interval)
            {
                Debug.WriteLine($"Performance : {ınvocation.Method.DeclaringType.FullName}.{ınvocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}");

            }
            _stopwatch.Restart();
        }
    }
}
