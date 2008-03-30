using System;
using System.Drawing;
using NoeticTools.DotNetWrappers;


namespace NoeticTools.PlugIns.ToolBar
{
	public interface IToolStripService
	{
		IToolStripButton AddButton(string name, Image image, EventHandler onClick, string toolTipText);
		IToolStripComboBox AddComboBox(string name);
		IToolStripSeparator AddSeparator(string name);
	}
}