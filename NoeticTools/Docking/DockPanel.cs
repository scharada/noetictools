using System.Windows.Forms;


namespace NoeticTools.Docking
{
    public class DockPanel : WeifenLuo.WinFormsUI.Docking.DockPanel, IDockPanel
    {
        public DockPanel()
        {
            Dock = DockStyle.Fill;
        }
    }
}