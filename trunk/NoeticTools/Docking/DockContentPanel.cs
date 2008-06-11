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

using System.Drawing;
using System.Windows.Forms;
using NoeticTools.DotNetWrappers;
using WeifenLuo.WinFormsUI.Docking;
using Control=System.Windows.Forms.Control;
using DockPanel=NoeticTools.Docking.DockPanel;


namespace NoeticTools.Docking
{
    public partial class DockContentPanel : DockContent, IDockContentPanel
    {
        private readonly IDockContentPanelListener listener;
        private readonly IControl containerPanel;

        public DockContentPanel()
        {
            InitializeComponent();
        }

        public DockContentPanel(IDockContentPanelListener listener, string name, IControl containerPanel, params Control[] controls)
            : this()
        {
            this.listener = listener;
            this.containerPanel = containerPanel;
            Name = name;
            Text = name;
            TabText = name;
            bannerTitle.Text = name;

            if (containerPanel is Control)
            {
                Controls.Add(containerPanel as Control);
            }
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.BackColor = SystemColors.Window;
            containerPanel.Name = "containerPanel";
            containerPanel.BringToFront();

            AddControls(controls);

            FormClosing += DockContentPanel_FormClosing;
            FormClosed += DockCOntentPanel_FormClosed;
        }

        private void DockCOntentPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            listener.OnClosed(e);
        }

        private static void DockContentPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        public void Show(IDockPanel dockPanel)
        {
            if (dockPanel as DockPanel != null)
            {
                base.Show(dockPanel as DockPanel);
            }
        }

        public void Add(Control control)
        {
            containerPanel.Controls.Add(control);
        }

        public void UpdateSize()
        {
            //int height = 25;
            //foreach(Control childControl in Controls)
            //{
            //    height += childControl.Size.Height;
            //}
            //Size = new Size(Size.Width, height);
        }

        protected void AddControls(params Control[] controls)
        {
            containerPanel.Controls.AddRange(controls);
        }
    }
}