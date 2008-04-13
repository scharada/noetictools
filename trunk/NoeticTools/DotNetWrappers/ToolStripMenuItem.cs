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
		private readonly System.Windows.Forms.ToolStripMenuItem item;

		public ToolStripMenuItem(System.Windows.Forms.ToolStripMenuItem item)
			: base(item)
		{
			this.item = item;
		}

		public static explicit operator System.Windows.Forms.ToolStripMenuItem(ToolStripMenuItem sourceItem)
		{
			return sourceItem.item;
		}

		public bool Checked
		{
			get { return item.Checked; }
			set { item.Checked = value; }
		}

		public bool CheckOnClick
		{
			get { return item.CheckOnClick; }
			set { item.CheckOnClick = value; }
		}

		public CheckState CheckState
		{
			get { return item.CheckState; }
			set { item.CheckState = value; }
		}

		public Keys ShortcutKeys
		{
			get { return item.ShortcutKeys; }
			set { item.ShortcutKeys = value; }
		}

		public string ShortcutKeyDisplayString
		{
			get { return item.ShortcutKeyDisplayString; }
			set { item.ShortcutKeyDisplayString = value; }
		}

		public bool ShowShortcutKeys
		{
			get { return item.ShowShortcutKeys; }
			set { item.ShowShortcutKeys = value; }
		}

		public bool IsMdiWindowListEntry
		{
			get { return item.IsMdiWindowListEntry; }
		}

		public event EventHandler CheckedChanged
		{
			add { item.CheckedChanged += value; }
			remove { item.CheckedChanged -= value; }
		}

		public event EventHandler CheckStateChanged
		{
			add { item.CheckStateChanged += value; }
			remove { item.CheckStateChanged -= value; }
		}
	}
}