using System;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
    public class Panel : ScrollableControl
    {
        private readonly System.Windows.Forms.Panel panel;

        public Panel(System.Windows.Forms.Panel panel) : base(panel)
        {
            this.panel = panel;
        }

        public AutoSizeMode AutoSizeMode
        {
            get { return panel.AutoSizeMode; }
            set { panel.AutoSizeMode = value; }
        }

        public BorderStyle BorderStyle
        {
            get { return panel.BorderStyle; }
            set { panel.BorderStyle = value; }
        }
    }
}