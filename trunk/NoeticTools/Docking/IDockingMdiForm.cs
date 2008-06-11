using NoeticTools.Docking;


namespace NoeticTools.Docking
{
    public interface IDockingMdiForm
    {
        void Show();
        void Close();
        void Add(IDockContentPanel contentPanel);
        void DockTo(IDockContentPanel panel, ParentPane parentPane);
    }
}