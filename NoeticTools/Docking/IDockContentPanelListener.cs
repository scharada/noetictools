using System.Windows.Forms;


namespace NoeticTools.Docking
{
    public interface IDockContentPanelListener
    {
        void OnClosed(FormClosedEventArgs cancel);
    }
}