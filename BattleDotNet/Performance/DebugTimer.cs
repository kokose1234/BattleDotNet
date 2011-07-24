using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BattleDotNet.Performance
{
    public class DebugTimer : IDisposable
    {
        private DebugTimer(string name)
        {
            Name = name;
            Stopwatch = Stopwatch.StartNew();
        }

        public Stopwatch Stopwatch { get; private set; }

        public string Name { get; private set; }

        public void Dispose()
        {
            Stopwatch.Stop();
            Debug.WriteLine("{0}: {1}ms", Name, Stopwatch.Elapsed.TotalMilliseconds);
        }

        public static IDisposable Start(string name)
        {
#if DEBUG
            return new DebugTimer(name);
#else
            return (IDisposable)null;
#endif
        }
    }
}
