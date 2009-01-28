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
using System.ComponentModel;
using System.Runtime.Remoting;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers.Windows.Forms
{
    public class MenuItem
    {
        private readonly System.Windows.Forms.MenuItem menuItem;

        public MenuItem(System.Windows.Forms.MenuItem menuItem)
        {
            this.menuItem = menuItem;
        }

        public ISite Site
        {
            get { return menuItem.Site; }
            set { menuItem.Site = value; }
        }

        public IContainer Container
        {
            get { return menuItem.Container; }
        }

        public IntPtr Handle
        {
            get { return menuItem.Handle; }
        }

        public System.Windows.Forms.MenuItem MdiListItem
        {
            get { return menuItem.MdiListItem; }
        }

        public string Name
        {
            get { return menuItem.Name; }
            set { menuItem.Name = value; }
        }

        public System.Windows.Forms.Menu.MenuItemCollection MenuItems
        {
            get { return menuItem.MenuItems; }
        }

        public object Tag
        {
            get { return menuItem.Tag; }
            set { menuItem.Tag = value; }
        }

        public bool BarBreak
        {
            get { return menuItem.BarBreak; }
            set { menuItem.BarBreak = value; }
        }

        public bool Break
        {
            get { return menuItem.Break; }
            set { menuItem.Break = value; }
        }

        public bool Checked
        {
            get { return menuItem.Checked; }
            set { menuItem.Checked = value; }
        }

        public bool DefaultItem
        {
            get { return menuItem.DefaultItem; }
            set { menuItem.DefaultItem = value; }
        }

        public bool OwnerDraw
        {
            get { return menuItem.OwnerDraw; }
            set { menuItem.OwnerDraw = value; }
        }

        public bool Enabled
        {
            get { return menuItem.Enabled; }
            set { menuItem.Enabled = value; }
        }

        public int Index
        {
            get { return menuItem.Index; }
            set { menuItem.Index = value; }
        }

        public bool IsParent
        {
            get { return menuItem.IsParent; }
        }

        public bool MdiList
        {
            get { return menuItem.MdiList; }
            set { menuItem.MdiList = value; }
        }

        public MenuMerge MergeType
        {
            get { return menuItem.MergeType; }
            set { menuItem.MergeType = value; }
        }

        public int MergeOrder
        {
            get { return menuItem.MergeOrder; }
            set { menuItem.MergeOrder = value; }
        }

        public char Mnemonic
        {
            get { return menuItem.Mnemonic; }
        }

        public System.Windows.Forms.Menu Parent
        {
            get { return menuItem.Parent; }
        }

        public bool RadioCheck
        {
            get { return menuItem.RadioCheck; }
            set { menuItem.RadioCheck = value; }
        }

        public string Text
        {
            get { return menuItem.Text; }
            set { menuItem.Text = value; }
        }

        public Shortcut Shortcut
        {
            get { return menuItem.Shortcut; }
            set { menuItem.Shortcut = value; }
        }

        public bool ShowShortcut
        {
            get { return menuItem.ShowShortcut; }
            set { menuItem.ShowShortcut = value; }
        }

        public bool Visible
        {
            get { return menuItem.Visible; }
            set { menuItem.Visible = value; }
        }

        public object GetLifetimeService()
        {
            return menuItem.GetLifetimeService();
        }

        public object InitializeLifetimeService()
        {
            return menuItem.InitializeLifetimeService();
        }

        public ObjRef CreateObjRef(Type requestedType)
        {
            return menuItem.CreateObjRef(requestedType);
        }

        public event EventHandler Disposed
        {
            add { menuItem.Disposed += value; }
            remove { menuItem.Disposed -= value; }
        }

        public void Dispose()
        {
            menuItem.Dispose();
        }

        public System.Windows.Forms.MenuItem FindMenuItem(int type, IntPtr value)
        {
            return menuItem.FindMenuItem(type, value);
        }

        public ContextMenu GetContextMenu()
        {
            return menuItem.GetContextMenu();
        }

        public MainMenu GetMainMenu()
        {
            return menuItem.GetMainMenu();
        }

        public void MergeMenu(System.Windows.Forms.Menu menuSrc)
        {
            menuItem.MergeMenu(menuSrc);
        }

        public event EventHandler Click
        {
            add { menuItem.Click += value; }
            remove { menuItem.Click -= value; }
        }

        public event DrawItemEventHandler DrawItem
        {
            add { menuItem.DrawItem += value; }
            remove { menuItem.DrawItem -= value; }
        }

        public event MeasureItemEventHandler MeasureItem
        {
            add { menuItem.MeasureItem += value; }
            remove { menuItem.MeasureItem -= value; }
        }

        public event EventHandler Popup
        {
            add { menuItem.Popup += value; }
            remove { menuItem.Popup -= value; }
        }

        public event EventHandler Select
        {
            add { menuItem.Select += value; }
            remove { menuItem.Select -= value; }
        }

        public System.Windows.Forms.MenuItem CloneMenu()
        {
            return menuItem.CloneMenu();
        }

        public System.Windows.Forms.MenuItem MergeMenu()
        {
            return menuItem.MergeMenu();
        }

        public void MergeMenu(System.Windows.Forms.MenuItem itemSrc)
        {
            menuItem.MergeMenu(itemSrc);
        }

        public void PerformClick()
        {
            menuItem.PerformClick();
        }

        public void PerformSelect()
        {
            menuItem.PerformSelect();
        }
    }
}