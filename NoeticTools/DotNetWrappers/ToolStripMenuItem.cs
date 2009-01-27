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
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
	public class ToolStripMenuItem : ToolStripDropDownItem, IToolStripMenuItem
	{
		private readonly System.Windows.Forms.ToolStripMenuItem menuItem;

        public ToolStripMenuItem(System.Windows.Forms.ToolStripMenuItem menuItem)
            : base(menuItem)
		{
            this.menuItem = menuItem;
		}

		public static explicit operator System.Windows.Forms.ToolStripMenuItem(ToolStripMenuItem sourceItem)
		{
			return sourceItem.menuItem;
		}

		public bool Checked
		{
			get { return menuItem.Checked; }
			set { menuItem.Checked = value; }
		}

		public bool CheckOnClick
		{
			get { return menuItem.CheckOnClick; }
			set { menuItem.CheckOnClick = value; }
		}

		public CheckState CheckState
		{
			get { return menuItem.CheckState; }
			set { menuItem.CheckState = value; }
		}

		public Keys ShortcutKeys
		{
			get { return menuItem.ShortcutKeys; }
			set { menuItem.ShortcutKeys = value; }
		}

		public string ShortcutKeyDisplayString
		{
			get { return menuItem.ShortcutKeyDisplayString; }
			set { menuItem.ShortcutKeyDisplayString = value; }
		}

		public bool ShowShortcutKeys
		{
			get { return menuItem.ShowShortcutKeys; }
			set { menuItem.ShowShortcutKeys = value; }
		}

		public bool IsMdiWindowListEntry
		{
			get { return menuItem.IsMdiWindowListEntry; }
		}

		public event EventHandler CheckedChanged
		{
			add { menuItem.CheckedChanged += value; }
			remove { menuItem.CheckedChanged -= value; }
		}

		public event EventHandler CheckStateChanged
		{
			add { menuItem.CheckStateChanged += value; }
			remove { menuItem.CheckStateChanged -= value; }
		}
	}
}