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
    public interface IToolStripItem : IComponent
    {
        string AccessibleDefaultActionDescription { get; set; }

        string AccessibleDescription { get; set; }

        string AccessibleName { get; set; }

        AccessibleRole AccessibleRole { get; set; }

        ToolStripItemAlignment Alignment { get; set; }

        bool AllowDrop { get; set; }

        bool AutoSize { get; set; }

        bool AutoToolTip { get; set; }

        bool Available { get; set; }

        Image BackgroundImage { get; set; }

        ImageLayout BackgroundImageLayout { get; set; }

        Color BackColor { get; set; }

        Rectangle Bounds { get; }

        Rectangle ContentRectangle { get; }

        bool CanSelect { get; }

        AnchorStyles Anchor { get; set; }

        DockStyle Dock { get; set; }

        ToolStripItemDisplayStyle DisplayStyle { get; set; }

        bool DoubleClickEnabled { get; set; }

        bool Enabled { get; set; }

        Color ForeColor { get; set; }

        Font Font { get; set; }

        int Height { get; set; }

        ContentAlignment ImageAlign { get; set; }

        Image Image { get; set; }

        Color ImageTransparentColor { get; set; }

        int ImageIndex { get; set; }

        string ImageKey { get; set; }

        ToolStripItemImageScaling ImageScaling { get; set; }

        bool IsDisposed { get; }

        bool IsOnDropDown { get; }

        bool IsOnOverflow { get; }

        Padding Margin { get; set; }

        MergeAction MergeAction { get; set; }

        int MergeIndex { get; set; }

        string Name { get; set; }

        System.Windows.Forms.ToolStrip Owner { get; set; }

        System.Windows.Forms.ToolStripItem OwnerItem { get; }

        ToolStripItemOverflow Overflow { get; set; }

        Padding Padding { get; set; }

        ToolStripItemPlacement Placement { get; }

        bool Pressed { get; }

        RightToLeft RightToLeft { get; set; }

        bool RightToLeftAutoMirrorImage { get; set; }

        bool Selected { get; }

        Size Size { get; set; }

        object Tag { get; set; }

        string Text { get; set; }

        ContentAlignment TextAlign { get; set; }

        ToolStripTextDirection TextDirection { get; set; }

        TextImageRelation TextImageRelation { get; set; }

        string ToolTipText { get; set; }

        bool Visible { get; set; }

        int Width { get; set; }

        DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects);
        System.Windows.Forms.ToolStrip GetCurrentParent();
        Size GetPreferredSize(Size constrainingSize);
        void Invalidate();
        void Invalidate(Rectangle r);
        void PerformClick();
        void Select();
        void ResetBackColor();
        void ResetDisplayStyle();
        void ResetForeColor();
        void ResetFont();
        void ResetImage();
        void ResetMargin();
        void ResetPadding();
        void ResetRightToLeft();
        void ResetTextDirection();

        event EventHandler AvailableChanged;
        event EventHandler BackColorChanged;
        event EventHandler Click;
        event EventHandler DisplayStyleChanged;
        event EventHandler DoubleClick;
        event DragEventHandler DragDrop;
        event DragEventHandler DragEnter;
        event DragEventHandler DragOver;
        event EventHandler DragLeave;
        event EventHandler EnabledChanged;
        event EventHandler ForeColorChanged;
        event GiveFeedbackEventHandler GiveFeedback;
        event EventHandler LocationChanged;
        event MouseEventHandler MouseDown;
        event EventHandler MouseEnter;
        event EventHandler MouseLeave;
        event EventHandler MouseHover;
        event MouseEventHandler MouseMove;
        event MouseEventHandler MouseUp;
        event EventHandler OwnerChanged;
        event PaintEventHandler Paint;
        event QueryContinueDragEventHandler QueryContinueDrag;
        event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
        event EventHandler RightToLeftChanged;
        event EventHandler TextChanged;
        event EventHandler VisibleChanged;
    }
}