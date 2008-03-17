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

using System.Windows.Forms;


namespace NoeticTools.PlugIns.Menus
{
	public class ToolStripMenuService : IToolStripMenuService
	{
		private readonly MenuStrip menuStrip;

		public ToolStripMenuService(MenuStrip menuStrip)
		{
			this.menuStrip = menuStrip;

			AddSharedMenus();
		}

		private void AddSharedMenus()
		{
			AddMenuItem("", "&View", "viewMenu");
		}

		public ToolStripMenuItem AddMenuItem(string parentMenuItemPath, string newItemText, string newItemName)
		{
			string[] menuItemNames = parentMenuItemPath == string.Empty ? new string[0] : parentMenuItemPath.Split('|');

			ToolStripMenuItem parentMenuItem = null;
			foreach (string name in menuItemNames)
			{
				ToolStripMenuItem menuItem;

				if (menuStrip.Items.ContainsKey(menuItemNames[0]))
				{
					menuItem = (ToolStripMenuItem) menuStrip.Items[menuItemNames[0]];
				}
				else
				{
					menuItem = AddMenuItem(parentMenuItem, name, name);
				}

				parentMenuItem = menuItem;
			}

			return AddMenuItem(parentMenuItem, newItemText, newItemName);
		}

		private ToolStripMenuItem AddMenuItem(ToolStripDropDownItem parentMenuItem, string newItemText, string newItemName)
		{
			ToolStripMenuItem newMenuItem = new ToolStripMenuItem(newItemText);
			newMenuItem.Name = newItemName;

			if (parentMenuItem == null)
			{
				AddTopLevelMenu(newMenuItem);
			}
			else
			{
				parentMenuItem.DropDownItems.Add(newMenuItem);
			}

			return newMenuItem;
		}

		private void AddTopLevelMenu(ToolStripItem newMenuItem)
		{
			int insertIndex = menuStrip.Items.IndexOfKey("windowsMenu");
			if (insertIndex == -1)
			{
				insertIndex = menuStrip.Items.IndexOfKey("Help");
			}
			if (insertIndex == -1)
			{
				menuStrip.Items.Add(newMenuItem);
			}
			else
			{
				menuStrip.Items.Insert(insertIndex, newMenuItem);
			}
		}
	}
}
