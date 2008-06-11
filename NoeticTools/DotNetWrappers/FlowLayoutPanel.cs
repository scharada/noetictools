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


namespace NoeticTools.DotNetWrappers
{
    public class FlowLayoutPanel : Panel
    {
        private readonly System.Windows.Forms.FlowLayoutPanel panel;

        public FlowLayoutPanel(System.Windows.Forms.FlowLayoutPanel panel)
            : base(panel)
        {
            this.panel = panel;
        }

        public FlowDirection FlowDirection
        {
            get { return panel.FlowDirection; }
            set { panel.FlowDirection = value; }
        }

        public bool WrapContents
        {
            get { return panel.WrapContents; }
            set { panel.WrapContents = value; }
        }

        public bool GetFlowBreak(System.Windows.Forms.Control control)
        {
            return panel.GetFlowBreak(control);
        }

        public void SetFlowBreak(System.Windows.Forms.Control control, bool value)
        {
            panel.SetFlowBreak(control, value);
        }
    }
}