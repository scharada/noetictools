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

#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NoeticTools.DotNetWrappers;
using ToolStripButton=System.Windows.Forms.ToolStripButton;
using ToolStripComboBox=System.Windows.Forms.ToolStripComboBox;
using ToolStripItem=System.Windows.Forms.ToolStripItem;


namespace NoeticTools.PlugIns.ToolBar
{
	public class ToolBarService : IToolStripService
	{
		private readonly List<string> menuOrdering = new List<string>();
		private readonly IToolStrip toolStrip;

		public ToolBarService(IToolStrip toolStrip, IEnumerable<string> menuOrdering)
		{
			this.toolStrip = toolStrip;
			this.menuOrdering.AddRange(menuOrdering);
		}

		IToolStripButton IToolStripService.AddButton(string name, Image image, EventHandler onClick, string toolTipText)
		{
			ToolStripButton button = new ToolStripButton(name, image);
			button.DisplayStyle = ToolStripItemDisplayStyle.Image;
			button.ToolTipText = toolTipText;
			button.Name = name.TrimEnd(new char[] {'.'});

			int newButtonNameIndex = menuOrdering.IndexOf(GetNormalisedName(button));
			for (int menuIndex = 0; menuIndex < toolStrip.Items.Count; menuIndex++)
			{
				int menuItemNameIndex = menuOrdering.IndexOf(GetNormalisedName(toolStrip.Items[menuIndex]));
				if (menuItemNameIndex > newButtonNameIndex)
				{
					toolStrip.Items.Insert(menuIndex, button);
					break;
				}
			}
			if (!toolStrip.Items.Contains(button))
			{
				toolStrip.Items.Add(button);
			}

			return new DotNetWrappers.ToolStripButton(button, onClick);
		}

		public IToolStripComboBox AddComboBox(string name)
		{
			ToolStripComboBox comboBox = new ToolStripComboBox(name);
			toolStrip.Items.Add(comboBox);
			return new DotNetWrappers.ToolStripComboBox(comboBox);
		}

		private static string GetNormalisedName(ToolStripItem button)
		{
			return button.Name.Replace("&", string.Empty);
		}
	}
}