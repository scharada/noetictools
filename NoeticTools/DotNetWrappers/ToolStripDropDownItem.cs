#region Copyright

// The contents of this file are subject to the Mozilla Public License
//  Version 1.1 (the "License"); you may not use this file except in compliance
//  with the License. You may obtain a copy of the License at
//  
//  http://www.mozilla.org/MPL/
//  
//  Software distributed under the License is distributed on an "AS IS"
//  basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
//  License for the specific language governing rights and limitations under 
//  the License.
//  
//  The Initial Developer of the Original Code is Robert Smyth.
//  Portions created by Robert Smyth are Copyright (C) 2008.
//  
//  All Rights Reserved.

#endregion

using System;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
    public class ToolStripDropDownItem : ToolStripItem, IToolStripDropDownItem
    {
        private readonly System.Windows.Forms.ToolStripDropDownItem item;

        public ToolStripDropDownItem(System.Windows.Forms.ToolStripDropDownItem item)
            : base(item)
        {
            this.item = item;
        }

        public ToolStripDropDown DropDown
        {
            get { return item.DropDown; }
            set { item.DropDown = value; }
        }

        public ToolStripDropDownDirection DropDownDirection
        {
            get { return item.DropDownDirection; }
            set { item.DropDownDirection = value; }
        }

        public IToolStripItemCollection DropDownItems
        {
            get { return new ToolStripItemCollection(item.DropDownItems); }
        }

        public bool HasDropDownItems
        {
            get { return item.HasDropDownItems; }
        }

        public void HideDropDown()
        {
            item.HideDropDown();
        }

        public void ShowDropDown()
        {
            item.ShowDropDown();
        }

        public event EventHandler DropDownClosed
        {
            add { item.DropDownClosed += value; }
            remove { item.DropDownClosed -= value; }
        }

        public event EventHandler DropDownOpening
        {
            add { item.DropDownOpening += value; }
            remove { item.DropDownOpening -= value; }
        }

        public event EventHandler DropDownOpened
        {
            add { item.DropDownOpened += value; }
            remove { item.DropDownOpened -= value; }
        }

        public event ToolStripItemClickedEventHandler DropDownItemClicked
        {
            add { item.DropDownItemClicked += value; }
            remove { item.DropDownItemClicked -= value; }
        }
    }
}