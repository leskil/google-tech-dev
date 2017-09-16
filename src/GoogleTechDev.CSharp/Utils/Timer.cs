using System;
using System.Diagnostics;

namespace GoogleTechDev.CSharp.Utils
{
    public class Timer : IDisposable
    {
        private readonly Stopwatch _stopWatch;

        private Timer()
        {
            _stopWatch = new Stopwatch();
            _stopWatch.Start();
        }

        public static Timer Start()
        {
            return new Timer();
        }

        public void Dispose()
        {
            _stopWatch.Stop();
            Console.WriteLine($"Execution took {_stopWatch.ElapsedMilliseconds} ms");
        }
    }
}