using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.Docking
{
    public interface IDockContentPanel : IDockContent
    {
        string Name { get; }
        DockState ShowHint { get; set; }

        event FormClosedEventHandler FormClosed;

        void Show(IDockPanel dockPanel);
        void Add(Control control);
        void Activate();
        void UpdateSize();
    }
}