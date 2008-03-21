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
		}

		public ToolStripMenuItem AddMenuItem(string menuPath)
		{
			string[] menuItemNames = menuPath == string.Empty ? new string[0] : menuPath.Split('|');

			ToolStripMenuItem menuItem = null;
			foreach (string newItemText in menuItemNames)
			{
				string menuName = GetMenuNameFromText(newItemText);

				if (menuStrip.Items.ContainsKey(menuName))
				{
					menuItem = (ToolStripMenuItem)menuStrip.Items[menuName];
				}
				else
				{
					menuItem = AddMenuItem(menuItem, newItemText);
				}

			}

			return menuItem;
		}

		private ToolStripMenuItem AddMenuItem(ToolStripDropDownItem parentMenuItem, string newItemText)
		{
			ToolStripMenuItem newMenuItem = new ToolStripMenuItem(newItemText);
			newMenuItem.Name = GetMenuNameFromText(newItemText);

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

		private string GetMenuNameFromText(string menuText)
		{
			return menuText.Replace("&", string.Empty).ToLower();
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
