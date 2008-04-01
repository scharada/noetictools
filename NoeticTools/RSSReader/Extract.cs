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
using System.Net;
using NoeticTools.DotNetWrappers;


namespace NoeticTools.RSS
{
	public class Extract
	{
		private readonly IHttpWebRequestFactory webRequestFactory;
		private const int getResponseTimeout = 20000; // 20 second timeout
		private const int maxAttempts = 3;

		public Extract(IHttpWebRequestFactory webRequestFactory)
		{
			this.webRequestFactory = webRequestFactory;
		}

		public string GetPageContents(string url)
		{
			string content;
			try
			{
				IHttpWebRequest request = webRequestFactory.Create(url);
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