using NoeticTools.Html.UI;
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.Html.UI
{
	public partial class HtmlView : DockContent, IHtmlView
	{
		public HtmlView()
		{
			InitializeComponent();
		}

		public void Refresh(string htmlText)
		{
			webBrowser.DocumentText = htmlText;
		}
	}
}