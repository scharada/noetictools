#region Copyright

/*---------------------------------------------------------------------------
 * The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 * 
 * http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
 * License for the specific language governing rights and limitations under 
 * the License.
 * 
 * The Initial Developer of the Original Code is Robert Smyth.
 * Portions created by Robert Smyth are Copyright (C) 2008.
 * 
 * All Rights Reserved.
 *---------------------------------------------------------------------------*/

#endregion //Copyright

using NoeticTools.PlugIns.Menus;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;


namespace NoeticTools.PlugIns
{
	public interface IPlugInHostServices
	{
		void AddOnOpenListener(IOnOpenListener listener);
		void Show(DockContent view, DockState dockState);
		Form MainForm { get; }

		IToolBar ToolBar { get; }
		IToolStripMenuService MenuBar { get; }
		IStatusBar StatusBar { get; }

		void AddService<T>(T service);
		T GetService<T>() where T : class;
	}
}