using System.Net;
using CFAIncidentsReader.DependencyInjection;
using HttpWebRequest=DotNetWrappers.HttpWebRequest;


namespace NoeticTools.DotNetWrappers
{
	public class HttpWebRequestFactory : IHttpWebRequestFactory
	{
		public IHttpWebRequest Create(string url)
		{
			return new HttpWebRequest(WebRequest.Create(url));
		}
	}
}