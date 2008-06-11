using NoeticTools.DotNetWrappers;


namespace NoeticTools.Docking
{
    public interface IContainerPanel : IControl
    {
        void Add(IControl control);
    }
}