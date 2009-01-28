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
using NoeticTools.DotNetWrappers;


namespace NoeticTools.PlugIns.Menus
{
    public class ViewFormMenuItem : IViewFormMenuItem, IFormClosedListener
    {
        private readonly IViewController viewController;
        private readonly IToolStripMenuItem viewMenu;
        private bool viewShown;

        public ViewFormMenuItem(string menuItemText, IPluginHostServices hostServices, IViewController viewController)
        {
            this.viewController = viewController;
            IToolStripMenuService menusService = hostServices.GetService<IToolStripMenuService>();
            viewMenu = menusService.AddMenuItem("&View|" + menuItemText);

            UpdateMenu();

            viewMenu.Click += viewMenu_Click;
        }

        void IFormClosedListener.FormClosed()
        {
            viewShown = false;
            UpdateMenu();
        }

        public void ToggleViewShown()
        {
            if (viewShown)
            {
                CloseView();
            }
            else
            {
                ShowView();
            }

            UpdateMenu();
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {
            ToggleViewShown();
        }

        private void CloseView()
        {
            viewController.Close();
            viewShown = false;
            UpdateMenu();
        }

        private void ShowView()
        {
            viewController.Show(this);
            viewShown = true;
            UpdateMenu();
        }

        private void UpdateMenu()
        {
            viewMenu.Checked = viewShown;
        }
    }
}