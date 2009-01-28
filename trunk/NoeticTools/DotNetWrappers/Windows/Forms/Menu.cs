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
using System.Runtime.Remoting;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers.Windows.Forms
{
    public class Menu : Component
    {
        private readonly System.Windows.Forms.Menu menu;

        public Menu(System.Windows.Forms.Menu menu) : base(menu)
        {
            this.menu = menu;
        }

        public IntPtr Handle
        {
            get { return menu.Handle; }
        }

        public bool IsParent
        {
            get { return menu.IsParent; }
        }

        public System.Windows.Forms.MenuItem MdiListItem
        {
            get { return menu.MdiListItem; }
        }

        public string Name
        {
            get { return menu.Name; }
            set { menu.Name = value; }
        }

        public System.Windows.Forms.Menu.MenuItemCollection MenuItems
        {
            get { return menu.MenuItems; }
        }

        public object Tag
        {
            get { return menu.Tag; }
            set { menu.Tag = value; }
        }

        public object GetLifetimeService()
        {
            return menu.GetLifetimeService();
        }

        public object InitializeLifetimeService()
        {
            return menu.InitializeLifetimeService();
        }

        public ObjRef CreateObjRef(Type requestedType)
        {
            return menu.CreateObjRef(requestedType);
        }

        public System.Windows.Forms.MenuItem FindMenuItem(int type, IntPtr value)
        {
            return menu.FindMenuItem(type, value);
        }

        public ContextMenu GetContextMenu()
        {
            return menu.GetContextMenu();
        }

        public MainMenu GetMainMenu()
        {
            return menu.GetMainMenu();
        }

        public void MergeMenu(System.Windows.Forms.Menu menuSrc)
        {
            menu.MergeMenu(menuSrc);
        }
    }
}