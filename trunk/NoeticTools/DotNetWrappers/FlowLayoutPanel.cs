using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
    public class FlowLayoutPanel : Panel
    {
        private readonly System.Windows.Forms.FlowLayoutPanel panel;

        public FlowLayoutPanel(System.Windows.Forms.FlowLayoutPanel panel)
            : base(panel)
        {
            this.panel = panel;
        }

        public FlowDirection FlowDirection
        {
            get { return panel.FlowDirection; }
            set { panel.FlowDirection = value; }
        }

        public bool WrapContents
        {
            get { return panel.WrapContents; }
            set { panel.WrapContents = value; }
        }

        public bool GetFlowBreak(System.Windows.Forms.Control control)
        {
            return panel.GetFlowBreak(control);
        }

        public void SetFlowBreak(System.Windows.Forms.Control control, bool value)
        {
            panel.SetFlowBreak(control, value);
        }
    }
}