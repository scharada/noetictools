using System.Drawing;
using System.Windows.Forms;
using NoeticTools.DotNetWrappers;
using Control=System.Windows.Forms.Control;


namespace NoeticTools.Docking
{
    public partial class FlowPanel : UserControl, IContainerPanel, IResizable
    {
        public FlowPanel()
        {
            InitializeComponent();
        }

        public void Add(IControl control)
        {
            control.Dock = DockStyle.Top;
            if (control is Control)
            {
                Controls.Add(control as Control);
                control.BringToFront();
            }

            ((IResizable)this).FitHeight();
        }

        void IResizable.FitHeight()
        {
            int height = 0;
            foreach (Control control in Controls)
            {
                height += control.Height;
            }
            Size = new Size(Size.Width, height);

            if (Parent is IResizable)
            {
                ((IResizable)Parent).FitHeight();
            }
        }
    }
}