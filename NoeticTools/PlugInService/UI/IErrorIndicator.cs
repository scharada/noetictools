namespace NoeticTools.PlugIns.UI
{
	public interface IErrorIndicator
	{
		void ShowError(string text);
		void ClearError();
	}
}