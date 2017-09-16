using System;
using System.Diagnostics;
using NUnit.Framework;

namespace GoogleTechDev.CSharp
{
    /// <summary>
    /// Abstract base class to provide execution times.
    /// </summary>
    public abstract class TestClass
    {
        private Stopwatch _stopwatch;

        [SetUp]
        public void Init()
        {
            _stopwatch = Stopwatch.StartNew();
        }

        [TearDown]
        public void Cleanup()
        {
            _stopwatch.Stop();
            Console.WriteLine($"Execution took {_stopwatch.ElapsedMilliseconds} ms");
        }
    }
}