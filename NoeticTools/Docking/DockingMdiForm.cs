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

using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.Docking
{
    public partial class DockingMdiForm : Form
    {
        private readonly IDockPanel dockPanel;

        public DockingMdiForm(IDockPanel dockPanel, string text)
        {
            this.dockPanel = dockPanel;
            Text = text;
            if (dockPanel as Control != null)
            {
                Controls.Add((Control)dockPanel);
            }
        }

        public void Add(IDockContentPanel contentPanel)
        {
            contentPanel.Show(dockPanel);
        }

        public void DockTo(IDockContentPanel contentPanel, ParentPane parentPane)
        {
            DockState panelDockState = contentPanel.ShowHint;
            if (parentPane.DockState != DockState.Unknown)
            {
                contentPanel.ShowHint = DockState.Float;
            }
            Add(contentPanel);
            if (parentPane.DockState != DockState.Unknown)
            {
                contentPanel.ShowHint = panelDockState;
                contentPanel.DockHandler.FloatPane.DockTo(dockPanel.DockWindows[parentPane.DockState]);
            }
        }

        private void DockingMdiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}