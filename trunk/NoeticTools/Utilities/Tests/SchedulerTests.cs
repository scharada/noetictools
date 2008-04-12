#region Copyright

/*---------------------------------------------------------------------------
 * The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 * 
 * http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
 * License for the specific language governing rights and limitations under 
 * the License.
 * 
 * The Initial Developer of the Original Code is Robert Smyth.
 * Portions created by Robert Smyth are Copyright (C) 2008.
 * 
 * All Rights Reserved.
 *---------------------------------------------------------------------------*/

#endregion

using System;
using NMock2;
using NoeticTools.DotNetWrappers;
using NoeticTools.Utilities;
using NUnit.Extensions;
using NUnit.Framework;


namespace NoeticTools.Utilities.Tests
{
	[TestFixture]
	public class SchedulerTests : MockingTestFixture
	{
		private Scheduler scheduler;
		private IClock clock;
		private ITimer timer;
		private int tickCount;
		private IScheduledEventFactory eventFactory;

		protected override void SetUp()
		{
			timer = NewMock<ITimer>();
			clock = NewMock<IClock>();
			eventFactory = NewMock<IScheduledEventFactory>();

			scheduler = new Scheduler(clock, timer, eventFactory);
		}

		[Test]
		public void Start_StartsTimerFor10millisecondTicks()
		{
			Stub.On(timer).EventAdd("Tick", Is.Anything);
			Expect.Once.On(timer).SetProperty("Interval").To(10);
			Expect.Once.On(timer).Method("Start");
			scheduler.Start();
		}

		[Test]
		public void Add_AddsScheduledEventThatIsCalledOnTimePeriod()
		{
			DateTime now = DateTime.Now;
			Expect.Once.On(clock).GetProperty("Now").Will(Return.Value(now));
			Expect.Once.On(clock).GetProperty("Now").Will(Return.Value(now));

			scheduler.Add(onScheduledEvent, TimeSpan.FromSeconds(3));
			scheduler.Add(onScheduledEvent, TimeSpan.FromSeconds(3));

			Assert.AreEqual(0, tickCount);

			// TODO
		}

		private void onScheduledEvent()
		{
			tickCount++;
		}
	}
}