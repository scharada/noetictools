using System;
using System.IO;
using System.Net;
using CFAIncidentsReader.DependencyInjection;
using NoeticTools.DotNetWrappers;
using DotNetWrappers;


namespace NoeticTools.RSS
{
	public class Extract
	{
		private const int getResponseTimeout = 20000; // 20 second timeout
		private const int maxAttempts = 3;

		public string GetPageContents(string url)
		{
			IHttpWebRequestFactory factory = new HttpWebRequestFactory();

			string content;
			try
			{
				IHttpWebRequest request = factory.Create(url);
				request.Timeout = getResponseTimeout;

				request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; " +
									"Windows NT 5.0; .NET CLR 1.0.3705)";

				string fullPage;

				int attemptsCount = 0;
				do
				{
					try
					{
						IWebResponse response = request.GetResponse();

						Stream responseStream = response.GetResponseStream();
						StreamReader readStream = new StreamReader(responseStream);
						fullPage = readStream.ReadToEnd();
						readStream.Close();
					}
					catch (WebException exception)
					{
						if (exception.Status != WebExceptionStatus.Timeout)
						{
							throw;
						}

						fullPage = string.Empty;
					}
				} while (++attemptsCount < maxAttempts && fullPage == string.Empty);

				content = fullPage;
			}
			catch (Exception)
			{
				content = "";
			}

			return content;
		}
	}
}