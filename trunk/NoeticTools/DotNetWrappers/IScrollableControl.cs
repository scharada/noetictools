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
    public interface IScrollableControl : IControl
    {
        bool AutoScroll { get; set; }
        Size AutoScrollMargin { get; set; }
        Point AutoScrollPosition { get; set; }
        Size AutoScrollMinSize { get; set; }
        HScrollProperties HorizontalScroll { get; }
        VScrollProperties VerticalScroll { get; }

        System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding { get; }

        void ScrollControlIntoView(IControl activeControl);
        void SetAutoScrollMargin(int x, int y);

        event ScrollEventHandler Scroll;
    }
}