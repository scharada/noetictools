using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.Docking
{
    public class ParentPane
    {
        private readonly DockState parentPane;

        public ParentPane(DockState parentPane)
        {
            this.parentPane = parentPane;
        }

        public DockState DockState
        {
            get { return parentPane; }
        }
    }
}