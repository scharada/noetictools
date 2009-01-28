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
    public interface IToolStrip : IScrollableControl
    {
        bool AllowItemReorder { get; set; }
        bool AllowMerge { get; set; }
        bool CanOverflow { get; set; }
        ToolStripDropDownDirection DefaultDropDownDirection { get; set; }
        ToolStripGripStyle GripStyle { get; set; }
        ToolStripGripDisplayStyle GripDisplayStyle { get; }
        Padding GripMargin { get; set; }
        Rectangle GripRectangle { get; }
        Size ImageScalingSize { get; set; }
        ImageList ImageList { get; set; }
        bool IsCurrentlyDragging { get; }
        IToolStripItemCollection Items { get; }
        bool IsDropDown { get; }
        LayoutSettings LayoutSettings { get; set; }
        ToolStripLayoutStyle LayoutStyle { get; set; }
        ToolStripOverflowButton OverflowButton { get; }
        Orientation Orientation { get; }
        bool Stretch { get; set; }
        ToolStripRenderer Renderer { get; set; }
        ToolStripRenderMode RenderMode { get; set; }
        bool ShowItemToolTips { get; set; }
        ToolStripTextDirection TextDirection { get; set; }

        System.Windows.Forms.ToolStripItem GetNextItem(ToolStripItem start, ArrowDirection direction);
        void ResetMinimumSize();

        event EventHandler BeginDrag;
        event EventHandler EndDrag;
        event ToolStripItemEventHandler ItemAdded;
        event ToolStripItemClickedEventHandler ItemClicked;
        event ToolStripItemEventHandler ItemRemoved;
        event EventHandler LayoutCompleted;
        event EventHandler LayoutStyleChanged;
        event PaintEventHandler PaintGrip;
        event EventHandler RendererChanged;
    }
}