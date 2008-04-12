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

using System;
using System.Drawing;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
	public class ToolStripItem
	{
		protected readonly System.Windows.Forms.ToolStripItem toolStripItem;

		public static implicit operator System.Windows.Forms.ToolStripItem(NoeticTools.DotNetWrappers.ToolStripItem item)
		{
			return item.toolStripItem;
		}

		public ToolStripItem(System.Windows.Forms.ToolStripItem toolStripItem)
		{
			this.toolStripItem = toolStripItem;
		}

		public string AccessibleDefaultActionDescription
		{
			get { return toolStripItem.AccessibleDefaultActionDescription; }
			set { toolStripItem.AccessibleDefaultActionDescription = value; }
		}

		public string AccessibleDescription
		{
			get { return toolStripItem.AccessibleDescription; }
			set { toolStripItem.AccessibleDescription = value; }
		}

		public string AccessibleName
		{
			get { return toolStripItem.AccessibleName; }
			set { toolStripItem.AccessibleName = value; }
		}

		public AccessibleRole AccessibleRole
		{
			get { return toolStripItem.AccessibleRole; }
			set { toolStripItem.AccessibleRole = value; }
		}

		public ToolStripItemAlignment Alignment
		{
			get { return toolStripItem.Alignment; }
			set { toolStripItem.Alignment = value; }
		}

		public bool AllowDrop
		{
			get { return toolStripItem.AllowDrop; }
			set { toolStripItem.AllowDrop = value; }
		}

		public bool AutoSize
		{
			get { return toolStripItem.AutoSize; }
			set { toolStripItem.AutoSize = value; }
		}

		public bool AutoToolTip
		{
			get { return toolStripItem.AutoToolTip; }
			set { toolStripItem.AutoToolTip = value; }
		}

		public bool Available
		{
			get { return toolStripItem.Available; }
			set { toolStripItem.Available = value; }
		}

		public Image BackgroundImage
		{
			get { return toolStripItem.BackgroundImage; }
			set { toolStripItem.BackgroundImage = value; }
		}

		public ImageLayout BackgroundImageLayout
		{
			get { return toolStripItem.BackgroundImageLayout; }
			set { toolStripItem.BackgroundImageLayout = value; }
		}

		public Color BackColor
		{
			get { return toolStripItem.BackColor; }
			set { toolStripItem.BackColor = value; }
		}

		public Rectangle Bounds
		{
			get { return toolStripItem.Bounds; }
		}

		public Rectangle ContentRectangle
		{
			get { return toolStripItem.ContentRectangle; }
		}

		public bool CanSelect
		{
			get { return toolStripItem.CanSelect; }
		}

		public AnchorStyles Anchor
		{
			get { return toolStripItem.Anchor; }
			set { toolStripItem.Anchor = value; }
		}

		public DockStyle Dock
		{
			get { return toolStripItem.Dock; }
			set { toolStripItem.Dock = value; }
		}

		public ToolStripItemDisplayStyle DisplayStyle
		{
			get { return toolStripItem.DisplayStyle; }
			set { toolStripItem.DisplayStyle = value; }
		}

		public bool DoubleClickEnabled
		{
			get { return toolStripItem.DoubleClickEnabled; }
			set { toolStripItem.DoubleClickEnabled = value; }
		}

		public bool Enabled
		{
			get { return toolStripItem.Enabled; }
			set { toolStripItem.Enabled = value; }
		}

		public Color ForeColor
		{
			get { return toolStripItem.ForeColor; }
			set { toolStripItem.ForeColor = value; }
		}

		public Font Font
		{
			get { return toolStripItem.Font; }
			set { toolStripItem.Font = value; }
		}

		public int Height
		{
			get { return toolStripItem.Height; }
			set { toolStripItem.Height = value; }
		}

		public ContentAlignment ImageAlign
		{
			get { return toolStripItem.ImageAlign; }
			set { toolStripItem.ImageAlign = value; }
		}

		public Image Image
		{
			get { return toolStripItem.Image; }
			set { toolStripItem.Image = value; }
		}

		public Color ImageTransparentColor
		{
			get { return toolStripItem.ImageTransparentColor; }
			set { toolStripItem.ImageTransparentColor = value; }
		}

		public int ImageIndex
		{
			get { return toolStripItem.ImageIndex; }
			set { toolStripItem.ImageIndex = value; }
		}

		public string ImageKey
		{
			get { return toolStripItem.ImageKey; }
			set { toolStripItem.ImageKey = value; }
		}

		public ToolStripItemImageScaling ImageScaling
		{
			get { return toolStripItem.ImageScaling; }
			set { toolStripItem.ImageScaling = value; }
		}

		public bool IsDisposed
		{
			get { return toolStripItem.IsDisposed; }
		}

		public bool IsOnDropDown
		{
			get { return toolStripItem.IsOnDropDown; }
		}

		public bool IsOnOverflow
		{
			get { return toolStripItem.IsOnOverflow; }
		}

		public Padding Margin
		{
			get { return toolStripItem.Margin; }
			set { toolStripItem.Margin = value; }
		}

		public MergeAction MergeAction
		{
			get { return toolStripItem.MergeAction; }
			set { toolStripItem.MergeAction = value; }
		}

		public int MergeIndex
		{
			get { return toolStripItem.MergeIndex; }
			set { toolStripItem.MergeIndex = value; }
		}

		public string Name
		{
			get { return toolStripItem.Name; }
			set { toolStripItem.Name = value; }
		}

		public System.Windows.Forms.ToolStrip Owner
		{
			get { return toolStripItem.Owner; }
			set { toolStripItem.Owner = value; }
		}

		public System.Windows.Forms.ToolStripItem OwnerItem
		{
			get { return toolStripItem.OwnerItem; }
		}

		public ToolStripItemOverflow Overflow
		{
			get { return toolStripItem.Overflow; }
			set { toolStripItem.Overflow = value; }
		}

		public Padding Padding
		{
			get { return toolStripItem.Padding; }
			set { toolStripItem.Padding = value; }
		}

		public ToolStripItemPlacement Placement
		{
			get { return toolStripItem.Placement; }
		}

		public bool Pressed
		{
			get { return toolStripItem.Pressed; }
		}

		public RightToLeft RightToLeft
		{
			get { return toolStripItem.RightToLeft; }
			set { toolStripItem.RightToLeft = value; }
		}

		public bool RightToLeftAutoMirrorImage
		{
			get { return toolStripItem.RightToLeftAutoMirrorImage; }
			set { toolStripItem.RightToLeftAutoMirrorImage = value; }
		}

		public bool Selected
		{
			get { return toolStripItem.Selected; }
		}

		public Size Size
		{
			get { return toolStripItem.Size; }
			set { toolStripItem.Size = value; }
		}

		public object Tag
		{
			get { return toolStripItem.Tag; }
			set { toolStripItem.Tag = value; }
		}

		public string Text
		{
			get { return toolStripItem.Text; }
			set { toolStripItem.Text = value; }
		}

		public ContentAlignment TextAlign
		{
			get { return toolStripItem.TextAlign; }
			set { toolStripItem.TextAlign = value; }
		}

		public ToolStripTextDirection TextDirection
		{
			get { return toolStripItem.TextDirection; }
			set { toolStripItem.TextDirection = value; }
		}

		public TextImageRelation TextImageRelation
		{
			get { return toolStripItem.TextImageRelation; }
			set { toolStripItem.TextImageRelation = value; }
		}

		public string ToolTipText
		{
			get { return toolStripItem.ToolTipText; }
			set { toolStripItem.ToolTipText = value; }
		}

		public bool Visible
		{
			get { return toolStripItem.Visible; }
			set { toolStripItem.Visible = value; }
		}

		public int Width
		{
			get { return toolStripItem.Width; }
			set { toolStripItem.Width = value; }
		}

		public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects)
		{
			return toolStripItem.DoDragDrop(data, allowedEffects);
		}

		public System.Windows.Forms.ToolStrip GetCurrentParent()
		{
			return toolStripItem.GetCurrentParent();
		}

		public Size GetPreferredSize(Size constrainingSize)
		{
			return toolStripItem.GetPreferredSize(constrainingSize);
		}

		public void Invalidate()
		{
			toolStripItem.Invalidate();
		}

		public void Invalidate(Rectangle r)
		{
			toolStripItem.Invalidate(r);
		}

		public void PerformClick()
		{
			toolStripItem.PerformClick();
		}

		public void Select()
		{
			toolStripItem.Select();
		}

		public void ResetBackColor()
		{
			toolStripItem.ResetBackColor();
		}

		public void ResetDisplayStyle()
		{
			toolStripItem.ResetDisplayStyle();
		}

		public void ResetForeColor()
		{
			toolStripItem.ResetForeColor();
		}

		public void ResetFont()
		{
			toolStripItem.ResetFont();
		}

		public void ResetImage()
		{
			toolStripItem.ResetImage();
		}

		public void ResetMargin()
		{
			toolStripItem.ResetMargin();
		}

		public void ResetPadding()
		{
			toolStripItem.ResetPadding();
		}

		public void ResetRightToLeft()
		{
			toolStripItem.ResetRightToLeft();
		}

		public void ResetTextDirection()
		{
			toolStripItem.ResetTextDirection();
		}

		public override string ToString()
		{
			return toolStripItem.ToString();
		}

		public event EventHandler AvailableChanged
		{
			add { toolStripItem.AvailableChanged += value; }
			remove { toolStripItem.AvailableChanged -= value; }
		}

		public event EventHandler BackColorChanged
		{
			add { toolStripItem.BackColorChanged += value; }
			remove { toolStripItem.BackColorChanged -= value; }
		}

		public event EventHandler Click
		{
			add { toolStripItem.Click += value; }
			remove { toolStripItem.Click -= value; }
		}

		public event EventHandler DisplayStyleChanged
		{
			add { toolStripItem.DisplayStyleChanged += value; }
			remove { toolStripItem.DisplayStyleChanged -= value; }
		}

		public event EventHandler DoubleClick
		{
			add { toolStripItem.DoubleClick += value; }
			remove { toolStripItem.DoubleClick -= value; }
		}

		public event DragEventHandler DragDrop
		{
			add { toolStripItem.DragDrop += value; }
			remove { toolStripItem.DragDrop -= value; }
		}

		public event DragEventHandler DragEnter
		{
			add { toolStripItem.DragEnter += value; }
			remove { toolStripItem.DragEnter -= value; }
		}

		public event DragEventHandler DragOver
		{
			add { toolStripItem.DragOver += value; }
			remove { toolStripItem.DragOver -= value; }
		}

		public event EventHandler DragLeave
		{
			add { toolStripItem.DragLeave += value; }
			remove { toolStripItem.DragLeave -= value; }
		}

		public event EventHandler EnabledChanged
		{
			add { toolStripItem.EnabledChanged += value; }
			remove { toolStripItem.EnabledChanged -= value; }
		}

		public event EventHandler ForeColorChanged
		{
			add { toolStripItem.ForeColorChanged += value; }
			remove { toolStripItem.ForeColorChanged -= value; }
		}

		public event GiveFeedbackEventHandler GiveFeedback
		{
			add { toolStripItem.GiveFeedback += value; }
			remove { toolStripItem.GiveFeedback -= value; }
		}

		public event EventHandler LocationChanged
		{
			add { toolStripItem.LocationChanged += value; }
			remove { toolStripItem.LocationChanged -= value; }
		}

		public event MouseEventHandler MouseDown
		{
			add { toolStripItem.MouseDown += value; }
			remove { toolStripItem.MouseDown -= value; }
		}

		public event EventHandler MouseEnter
		{
			add { toolStripItem.MouseEnter += value; }
			remove { toolStripItem.MouseEnter -= value; }
		}

		public event EventHandler MouseLeave
		{
			add { toolStripItem.MouseLeave += value; }
			remove { toolStripItem.MouseLeave -= value; }
		}

		public event EventHandler MouseHover
		{
			add { toolStripItem.MouseHover += value; }
			remove { toolStripItem.MouseHover -= value; }
		}

		public event MouseEventHandler MouseMove
		{
			add { toolStripItem.MouseMove += value; }
			remove { toolStripItem.MouseMove -= value; }
		}

		public event MouseEventHandler MouseUp
		{
			add { toolStripItem.MouseUp += value; }
			remove { toolStripItem.MouseUp -= value; }
		}

		public event EventHandler OwnerChanged
		{
			add { toolStripItem.OwnerChanged += value; }
			remove { toolStripItem.OwnerChanged -= value; }
		}

		public event PaintEventHandler Paint
		{
			add { toolStripItem.Paint += value; }
			remove { toolStripItem.Paint -= value; }
		}

		public event QueryContinueDragEventHandler QueryContinueDrag
		{
			add { toolStripItem.QueryContinueDrag += value; }
			remove { toolStripItem.QueryContinueDrag -= value; }
		}

		public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp
		{
			add { toolStripItem.QueryAccessibilityHelp += value; }
			remove { toolStripItem.QueryAccessibilityHelp -= value; }
		}

		public event EventHandler RightToLeftChanged
		{
			add { toolStripItem.RightToLeftChanged += value; }
			remove { toolStripItem.RightToLeftChanged -= value; }
		}

		public event EventHandler TextChanged
		{
			add { toolStripItem.TextChanged += value; }
			remove { toolStripItem.TextChanged -= value; }
		}

		public event EventHandler VisibleChanged
		{
			add { toolStripItem.VisibleChanged += value; }
			remove { toolStripItem.VisibleChanged -= value; }
		}
	}
}