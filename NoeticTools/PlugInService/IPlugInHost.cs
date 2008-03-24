namespace NoeticTools.PlugIns
{
	public interface IPluginHost
	{
		void Register(IPlugin plugin);
		void Register(IPlugin[] plugins);
	}
}