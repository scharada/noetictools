#region Copyright

// The contents of this file are subject to the Mozilla Public License
//  Version 1.1 (the "License"); you may not use this file except in compliance
//  with the License. You may obtain a copy of the License at
//  
//  http://www.mozilla.org/MPL/
//  
//  Software distributed under the License is distributed on an "AS IS"
//  basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
//  License for the specific language governing rights and limitations under 
//  the License.
//  
//  The Initial Developer of the Original Code is Robert Smyth.
//  Portions created by Robert Smyth are Copyright (C) 2008.
//  
//  All Rights Reserved.

#endregion

using System;
using System.Diagnostics;
using System.Threading;


namespace NoeticTools.TimersPerformanceTester
{
    public class SleepPerformanceTester : IPerformanceTester
    {
        private readonly IRunLimiter limiter;
        private readonly TimeSpan testResolution;
        private TimeSpan maxTime = TimeSpan.MinValue;
        private TimeSpan minTime = TimeSpan.MaxValue;
        private int numberOfEvents;
        private TimeSpan totalTime = TimeSpan.Zero;

        public SleepPerformanceTester(TimeSpan testResolution, IRunLimiter limiter)
        {
            this.testResolution = testResolution;
            this.limiter = limiter;
        }

        public void Run()
        {
            Console.WriteLine("\t\tRunning Thread.Sleep performance tests for a {0,5:#.00}ms sleep over {1}.", testResolution.TotalMilliseconds, limiter.ShowLimit());

            var stopwatch = new Stopwatch();

            while (!limiter.Finished())
            {
                stopwatch.Reset();

                stopwatch.Start();
                while (stopwatch.Elapsed < testResolution)
                {
                    Thread.Sleep(testResolution);
                }
                stopwatch.Stop();

                if (stopwatch.Elapsed != TimeSpan.Zero && stopwatch.Elapsed < minTime)
                {
                    minTime = stopwatch.Elapsed;
                }

                if (stopwatch.Elapsed > maxTime)
                {
                    maxTime = stopwatch.Elapsed;
                }

                totalTime += stopwatch.Elapsed;

                numberOfEvents++;

                limiter.RunDone();
            }
        }

        public void ShowResults()
        {
            var average_ms = totalTime.TotalMilliseconds/numberOfEvents;

            Console.WriteLine(
                "\tThread.Sleep performance for {0,5:#.00} milliseconds: Average = {3,5:#.00}ms ({4,3:###}% latency). Min = {1,5:#.00}ms. Max = {2,5:#.00}ms.",
                testResolution.TotalMilliseconds,
                minTime.TotalMilliseconds, maxTime.TotalMilliseconds, average_ms,
                 Math.Abs((testResolution.TotalMilliseconds - average_ms)/testResolution.TotalMilliseconds)*100);
        }
    }
}