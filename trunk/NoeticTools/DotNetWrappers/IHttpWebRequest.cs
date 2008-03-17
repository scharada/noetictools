using DotNetWrappers;


namespace NoeticTools.DotNetWrappers
{
	public interface IHttpWebRequest
	{
		int Timeout { get; set; }
		string UserAgent { get; set; }

		IWebResponse GetResponse();
	}
}