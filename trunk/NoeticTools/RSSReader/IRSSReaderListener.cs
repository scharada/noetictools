using System.Xml;


namespace NoeticTools.RSS
{
	public interface IRSSReaderListener
	{
		void OnRefresh(XmlDocument document);
		void OnFailure();
	}
}