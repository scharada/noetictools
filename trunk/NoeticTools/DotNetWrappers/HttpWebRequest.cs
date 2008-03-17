using System.Net;
using System.Runtime.Serialization;
using NoeticTools.DotNetWrappers;


namespace DotNetWrappers
{
	public class HttpWebRequest : IHttpWebRequest
	{
		private System.Net.HttpWebRequest httpWebRequest;

		public HttpWebRequest(WebRequest request)
		{
			httpWebRequest = (System.Net.HttpWebRequest)request;
		}

		public IWebResponse GetResponse()
		{
			return new WebResponse(httpWebRequest.GetResponse());
		}

		public int Timeout
		{
			get { return httpWebRequest.Timeout; }
			set { httpWebRequest.Timeout = value; }
		}

		public string UserAgent
		{
			get { return httpWebRequest.UserAgent; }
			set { httpWebRequest.UserAgent = value; }
		}
	}
}
