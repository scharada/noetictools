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
using NoeticTools.Utilities;


namespace NoeticTools.Utilities
{
	public class ScheduledEvent : IScheduledEvent
	{
		private readonly IClock clock;
		private readonly OnScheduledTickDelegate onTick;
		private readonly TimeSpan period;
		private DateTime tickTime;

		public ScheduledEvent(IClock clock, OnScheduledTickDelegate onTick, TimeSpan period)
		{
			this.clock = clock;
			this.onTick = onTick;
			this.period = period;
			SetNextTickTime();
		}

		private void SetNextTickTime()
		{
			tickTime = clock.Now + period;
		}

		void IScheduledEvent.OnScheduledEvent()
		{
			onTick();
		}

		int IComparable<IScheduledEvent>.CompareTo(IScheduledEvent otherEvent)
		{
			return tickTime.CompareTo(((ScheduledEvent)otherEvent).tickTime);
		}

		int IComparable<DateTime>.CompareTo(DateTime other)
		{
			return tickTime > other ? 1 : tickTime < other ? -1 : 0;
		}
	}
}