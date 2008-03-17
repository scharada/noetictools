using NoeticTools.DotNetWrappers;


namespace CFAIncidentsReader.DependencyInjection
{
	public interface IHttpWebRequestFactory
	{
		IHttpWebRequest Create(string url);
	}
}