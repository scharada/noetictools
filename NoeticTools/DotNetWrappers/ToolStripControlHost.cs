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
using System.Drawing;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
    public class ToolStripControlHost : ToolStripItem, IToolStripControlHost
    {
        private readonly System.Windows.Forms.ToolStripControlHost host;

        public ToolStripControlHost(System.Windows.Forms.ToolStripControlHost host)
            : base(host)
        {
            this.host = host;
        }

        public bool CausesValidation
        {
            get { return host.CausesValidation; }
            set { host.CausesValidation = value; }
        }

        public ContentAlignment ControlAlign
        {
            get { return host.ControlAlign; }
            set { host.ControlAlign = value; }
        }

        public System.Windows.Forms.Control Control
        {
            get { return host.Control; }
        }

        public bool Focused
        {
            get { return host.Focused; }
        }

        public void Focus()
        {
            host.Focus();
        }

        public event EventHandler Enter
        {
            add { host.Enter += value; }
            remove { host.Enter -= value; }
        }

        public event EventHandler GotFocus
        {
            add { host.GotFocus += value; }
            remove { host.GotFocus -= value; }
        }

        public event EventHandler Leave
        {
            add { host.Leave += value; }
            remove { host.Leave -= value; }
        }

        public event EventHandler LostFocus
        {
            add { host.LostFocus += value; }
            remove { host.LostFocus -= value; }
        }

        public event KeyEventHandler KeyDown
        {
            add { host.KeyDown += value; }
            remove { host.KeyDown -= value; }
        }

        public event KeyPressEventHandler KeyPress
        {
            add { host.KeyPress += value; }
            remove { host.KeyPress -= value; }
        }

        public event KeyEventHandler KeyUp
        {
            add { host.KeyUp += value; }
            remove { host.KeyUp -= value; }
        }

        public event CancelEventHandler Validating
        {
            add { host.Validating += value; }
            remove { host.Validating -= value; }
        }

        public event EventHandler Validated
        {
            add { host.Validated += value; }
            remove { host.Validated -= value; }
        }
    }
}