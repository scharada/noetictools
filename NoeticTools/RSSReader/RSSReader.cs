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
using System.IO;
using System.Xml;
using NoeticTools.DotNetWrappers;
using Timer=NoeticTools.DotNetWrappers.Timer;


namespace NoeticTools.RSS
{
	public class RSSReader : IRSSReader
	{
		private readonly int firstUpdateDelayInMilliseconds = 500;
		private readonly IRSSReaderListener listener;
		private readonly IHttpWebRequestFactory webRequestFactory;
		private readonly Timer updateTimer;
		private IRSSReaderOptions options;

		public RSSReader(IRSSReaderListener listener, IHttpWebRequestFactory webRequestFactory)
		{
			this.listener = listener;
			this.webRequestFactory = webRequestFactory;

			updateTimer = new Timer(new System.Windows.Forms.Timer());
			updateTimer.Tick += updateTimer_Tick;
		}

		void IRSSReader.Refresh()
		{
			Extract scraper = new Extract(webRequestFactory);
			string incidentsXml = scraper.GetPageContents(options.Url);

			if (incidentsXml != string.Empty)
			{
				StringReader reader = new StringReader(incidentsXml);
				XmlDocument document = new XmlDocument();
				try
				{
					document.Load(reader);
					listener.OnRefresh(document);
				}
				catch (XmlException)
				{
					listener.OnFailure();
				}
			}
			else
			{
				listener.OnFailure();
			}
		}

		void IRSSReader.Start(IRSSReaderOptions readerOptions)
		{
			options = readerOptions;

			updateTimer.Interval = firstUpdateDelayInMilliseconds;
			updateTimer.Start();
		}

		void IRSSReader.Stop()
		{
			updateTimer.Stop();
		}

		private void updateTimer_Tick(object sender, EventArgs e)
		{
			updateTimer.Interval = (int) options.UpdatePeriod.TotalMilliseconds;
			((IRSSReader) this).Refresh();
		}
	}
}