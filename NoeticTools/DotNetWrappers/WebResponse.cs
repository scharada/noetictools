using System.IO;


namespace DotNetWrappers
{
	public class WebResponse : IWebResponse
	{
		private readonly System.Net.WebResponse response;

		public WebResponse(System.Net.WebResponse response)
		{
			this.response = response;
		}

		public Stream GetResponseStream()
		{
			return response.GetResponseStream();
		}
	}
}
