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
using System.Collections.Generic;


namespace NoeticTools.TimersPerformanceTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testResolutions = new[]
                                      {
                                          TimeSpan.FromMilliseconds(1),
                                          TimeSpan.FromMilliseconds(5),
                                          TimeSpan.FromMilliseconds(10),
                                          TimeSpan.FromMilliseconds(15),
                                      };

            var numberOfSamples = 500;

            var runTests = new List<IPerformanceTester>();

            Console.WriteLine();
            Console.WriteLine("Running tests:");
            Console.WriteLine();

            foreach (var testResolution in testResolutions)
            {
                var testers = new IPerformanceTester[]
                                  {
                                      new SleepPerformanceTester(testResolution, new CountLimiter(numberOfSamples)),
                                      new SystemThreadingTimerPerformanceTester(),
                                      new SystemTimersTimerPerformanceTester(),
                                      new SystemWindowsFormsTimerPerformanceTester(),
                                  };

                foreach (var tester in testers)
                {
                    tester.Run();
                    runTests.Add(tester);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine();

            foreach (var tester in runTests)
            {
                tester.ShowResults();
            }

            Console.ReadKey();
        }
    }
}