using System.IO;


namespace DotNetWrappers
{
	public interface IWebResponse
	{
		Stream GetResponseStream();
	}
}