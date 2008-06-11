using NoeticTools.Docking;


namespace NoeticTools.Docking
{
    public partial class GroupPanel : FlowPanel
    {
        public GroupPanel(string name)
        {
            bannerLabel.Text = name;
        }
    }
}