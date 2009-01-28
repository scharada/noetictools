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
    public class ScrollableControl : Control, IScrollableControl
    {
        private readonly System.Windows.Forms.ScrollableControl scrollableControl;

        public ScrollableControl(System.Windows.Forms.ScrollableControl scrollableControl)
            : base(scrollableControl)
        {
            this.scrollableControl = scrollableControl;
        }

        public bool AutoScroll
        {
            get { return scrollableControl.AutoScroll; }
            set { scrollableControl.AutoScroll = value; }
        }

        public Size AutoScrollMargin
        {
            get { return scrollableControl.AutoScrollMargin; }
            set { scrollableControl.AutoScrollMargin = value; }
        }

        public Point AutoScrollPosition
        {
            get { return scrollableControl.AutoScrollPosition; }
            set { scrollableControl.AutoScrollPosition = value; }
        }

        public Size AutoScrollMinSize
        {
            get { return scrollableControl.AutoScrollMinSize; }
            set { scrollableControl.AutoScrollMinSize = value; }
        }

        public HScrollProperties HorizontalScroll
        {
            get { return scrollableControl.HorizontalScroll; }
        }

        public VScrollProperties VerticalScroll
        {
            get { return scrollableControl.VerticalScroll; }
        }

        public System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding
        {
            get { return scrollableControl.DockPadding; }
        }

        public void ScrollControlIntoView(IControl activeControl)
        {
            scrollableControl.ScrollControlIntoView((System.Windows.Forms.Control) activeControl);
        }

        public void SetAutoScrollMargin(int x, int y)
        {
            scrollableControl.SetAutoScrollMargin(x, y);
        }

        public event ScrollEventHandler Scroll
        {
            add { scrollableControl.Scroll += value; }
            remove { scrollableControl.Scroll -= value; }
        }
    }
}