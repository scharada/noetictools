namespace NoeticTools.PlugIns
{
	public interface IPlugInHost
	{
		void Register(IPlugin plugin);
		void Register(IPlugin[] plugins);
	}
}