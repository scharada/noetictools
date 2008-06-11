using NoeticTools.Docking;
using NoeticTools.DotNetWrappers;
using Control = System.Windows.Forms.Control;


namespace NoeticTools.Docking
{
    public partial class FlowLayoutDockingForm : DockContentPanel
    {
        public FlowLayoutDockingForm() : this(null, "Name")
        {
        }

        public FlowLayoutDockingForm(IDockContentPanelListener listener, string name, params Control[] controls)
            : base(listener, name, new FlowLayoutPanel(new System.Windows.Forms.FlowLayoutPanel()), controls)
        {
            InitializeComponent();
            Name = name;
        }
    }
}