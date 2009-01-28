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
    public class ToolStripButton : ToolStripItem, IToolStripButton
    {
        private readonly EventHandler onClickHandler; // TODO: Remove this as this class is a wrapper
        private readonly System.Windows.Forms.ToolStripButton toolStripButton;

        public ToolStripButton(System.Windows.Forms.ToolStripButton toolStripButton)
            : base(toolStripButton)
        {
            this.toolStripButton = toolStripButton;
            toolStripButton.Click += onClick;
        }

        public ToolStripButton(System.Windows.Forms.ToolStripButton toolStripButton, EventHandler onClickHandler)
            : this(toolStripButton)
        {
            this.onClickHandler = onClickHandler;
        }

        public bool CheckOnClick
        {
            get { return toolStripButton.CheckOnClick; }
            set { toolStripButton.CheckOnClick = value; }
        }

        public bool Checked
        {
            get { return toolStripButton.Checked; }
            set { toolStripButton.Checked = value; }
        }

        public CheckState CheckState
        {
            get { return toolStripButton.CheckState; }
            set { toolStripButton.CheckState = value; }
        }

        public event EventHandler CheckedChanged
        {
            add { toolStripButton.CheckedChanged += value; }
            remove { toolStripButton.CheckedChanged -= value; }
        }

        public event EventHandler CheckStateChanged
        {
            add { toolStripButton.CheckStateChanged += value; }
            remove { toolStripButton.CheckStateChanged -= value; }
        }

        private void onClick(object sender, EventArgs e)
        {
            if (onClickHandler != null)
            {
                onClickHandler(this, e);
            }
        }
    }
}