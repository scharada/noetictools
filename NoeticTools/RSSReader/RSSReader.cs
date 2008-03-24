using System.IO;
using System.Xml;
using System.Windows.Forms;


namespace NoeticTools.RSS
{
	public class RSSReader : IRSSReader
	{
		private readonly string url;
		private readonly IRSSReaderListener listener;
		private readonly Timer updateTimer;
		private readonly int updatePeriodInMilliseconds;
		private readonly int firstUpdateDelayInMilliseconds = 500;

		public RSSReader(IRSSReaderListener listener, Timer updateTimer, string url)
		{
			this.listener = listener;
			this.updateTimer = updateTimer;
			this.url = url;

			updatePeriodInMilliseconds = updateTimer.Interval;
			updateTimer.Interval = firstUpdateDelayInMilliseconds;

			updateTimer.Tick += updateTimer_Tick;
		}

		private void updateTimer_Tick(object sender, System.EventArgs e)
		{
			updateTimer.Interval = updatePeriodInMilliseconds;
			((IRSSReader)this).Refresh();
		}

		void IRSSReader.Refresh()
		{
			Extract scraper = new Extract();
			string incidentsXml = scraper.GetPageContents(url);

			if (incidentsXml != string.Empty)
			{
				StringReader reader = new StringReader(incidentsXml);
				XmlDocument document = new XmlDocument();
				try
				{
					document.Load(reader);
				}
				catch(XmlException)
				{
					document.RemoveAll();	// TODO: Better error handling
				}
				listener.OnRefresh(document);
			}
			else
			{
				listener.OnFailure();
			}
		}

		void IRSSReader.Start()
		{
			updateTimer.Start();
		}

		void IRSSReader.Stop()
		{
			updateTimer.Stop();
		}
	}
}