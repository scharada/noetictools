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
using System.Drawing;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
    public class StatusStrip : ToolStrip, IStatusStrip
    {
        private readonly System.Windows.Forms.StatusStrip statusStrip;

        public StatusStrip(System.Windows.Forms.StatusStrip statusStrip)
            : base(statusStrip)
        {
            this.statusStrip = statusStrip;
        }

        public Padding Padding
        {
            get { return statusStrip.Padding; }
            set { statusStrip.Padding = value; }
        }

        public bool SizingGrip
        {
            get { return statusStrip.SizingGrip; }
            set { statusStrip.SizingGrip = value; }
        }

        public Rectangle SizeGripBounds
        {
            get { return statusStrip.SizeGripBounds; }
        }

        public event EventHandler PaddingChanged
        {
            add { statusStrip.PaddingChanged += value; }
            remove { statusStrip.PaddingChanged -= value; }
        }
    }
}