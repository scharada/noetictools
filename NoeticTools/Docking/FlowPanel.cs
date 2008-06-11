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
using Control=System.Windows.Forms.Control;


namespace NoeticTools.Docking
{
    public partial class FlowPanel : UserControl, IContainerPanel, IResizable
    {
        public FlowPanel()
        {
            InitializeComponent();
        }

        public void Add(IControl control)
        {
            control.Dock = DockStyle.Top;
            if (control is Control)
            {
                Controls.Add(control as Control);
                control.BringToFront();
            }

            ((IResizable)this).FitHeight();
        }

        void IResizable.FitHeight()
        {
            int height = 0;
            foreach (Control control in Controls)
            {
                height += control.Height;
            }
            Size = new Size(Size.Width, height);

            if (Parent is IResizable)
            {
                ((IResizable)Parent).FitHeight();
            }
        }
    }
}