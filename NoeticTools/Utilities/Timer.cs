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
	public class Timer : ITimer
	{
		private readonly System.Windows.Forms.Timer timer;

		public Timer(System.Windows.Forms.Timer timer)
		{
			this.timer = timer;
		}

		public void Start()
		{
			timer.Start();
		}

		public void Stop()
		{
			timer.Stop();
		}

		public object Tag
		{
			get { return timer.Tag; }
			set { timer.Tag = value; }
		}

		public bool Enabled
		{
			get { return timer.Enabled; }
			set { timer.Enabled = value; }
		}

		public int Interval
		{
			get { return timer.Interval; }
			set { timer.Interval = value; }
		}

		public event EventHandler Tick
		{
			add { timer.Tick += value; }
			remove { timer.Tick -= value; }
		}
	}
}