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

using System.Drawing;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
    public class ToolStripLabel : ToolStripItem
    {
        private readonly System.Windows.Forms.ToolStripLabel toolStripLabel;

        public ToolStripLabel()
            : this(new ToolStripStatusLabel())
        {
        }

        private ToolStripLabel(System.Windows.Forms.ToolStripLabel toolStripLabel)
            : base(toolStripLabel)
        {
            this.toolStripLabel = toolStripLabel;
        }

        public bool IsLink
        {
            get { return toolStripLabel.IsLink; }
            set { toolStripLabel.IsLink = value; }
        }

        public Color ActiveLinkColor
        {
            get { return toolStripLabel.ActiveLinkColor; }
            set { toolStripLabel.ActiveLinkColor = value; }
        }

        public LinkBehavior LinkBehavior
        {
            get { return toolStripLabel.LinkBehavior; }
            set { toolStripLabel.LinkBehavior = value; }
        }

        public Color LinkColor
        {
            get { return toolStripLabel.LinkColor; }
            set { toolStripLabel.LinkColor = value; }
        }

        public bool LinkVisited
        {
            get { return toolStripLabel.LinkVisited; }
            set { toolStripLabel.LinkVisited = value; }
        }

        public Color VisitedLinkColor
        {
            get { return toolStripLabel.VisitedLinkColor; }
            set { toolStripLabel.VisitedLinkColor = value; }
        }
    }
}