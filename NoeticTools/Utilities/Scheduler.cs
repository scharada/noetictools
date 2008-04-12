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
using NoeticTools.DotNetWrappers;
using NoeticTools.Utilities;


namespace NoeticTools.Utilities
{
	public class Scheduler : IScheduler
	{
		private readonly IClock clock;
		private readonly ITimer timer;
		private readonly IScheduledEventFactory eventFactory;
		private readonly OrderedList<IScheduledEvent> events = new OrderedList<IScheduledEvent>();

		public Scheduler(IClock clock, ITimer timer, IScheduledEventFactory eventFactory)
		{
			this.clock = clock;
			this.timer = timer;
			this.eventFactory = eventFactory;
		}

		public void Start()
		{
			timer.Tick += timer_Tick;
			timer.Interval = 10;
			timer.Start();
		}

		public void Add(OnScheduledTickDelegate onScheduledEvent, TimeSpan period)
		{
			IScheduledEvent scheduledEvent = eventFactory.Create(period, onScheduledEvent);
			events.Add(scheduledEvent);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (events.Count > 0)
			{
				DateTime now = clock.Now;
				while (events[0].CompareTo(now) <= 0)
				{
					IScheduledEvent pendingEvent = events[0];
					events.RemoveAt(0);
					pendingEvent.OnScheduledEvent();
				}
			}
		}
	}

	public delegate void OnScheduledTickDelegate();
}