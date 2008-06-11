using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.Docking
{
    public partial class DockingMdiForm : Form
    {
        private readonly IDockPanel dockPanel;

        public DockingMdiForm(IDockPanel dockPanel, string text)
        {
            this.dockPanel = dockPanel;
            Text = text;
            if (dockPanel as Control != null)
            {
                Controls.Add((Control)dockPanel);
            }
        }

        public void Add(IDockContentPanel contentPanel)
        {
            contentPanel.Show(dockPanel);
        }

        public void DockTo(IDockContentPanel contentPanel, ParentPane parentPane)
        {
            DockState panelDockState = contentPanel.ShowHint;
            if (parentPane.DockState != DockState.Unknown)
            {
                contentPanel.ShowHint = DockState.Float;
            }
            Add(contentPanel);
            if (parentPane.DockState != DockState.Unknown)
            {
                contentPanel.ShowHint = panelDockState;
                contentPanel.DockHandler.FloatPane.DockTo(dockPanel.DockWindows[parentPane.DockState]);
            }
        }

        private void DockingMdiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}