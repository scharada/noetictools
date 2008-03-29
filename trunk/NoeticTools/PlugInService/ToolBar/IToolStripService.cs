using System;
using System.Drawing;
using NoeticTools.DotNetWrappers;


namespace NoeticTools.PlugIns.ToolBar
{
	public interface IToolStripService
	{
		IToolStripButton AddButton(string text, Image image, EventHandler onClick, string toolTipText);
	}
}