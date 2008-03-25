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
using System.Windows.Forms.Layout;
using ToolStripItem=System.Windows.Forms.ToolStripItem;


namespace NoeticTools.DotNetWrappers
{
	public class ToolStrip : IToolStrip
	{
		private readonly System.Windows.Forms.ToolStrip toolStrip;

		public ToolStrip(System.Windows.Forms.ToolStrip toolStrip)
		{
			this.toolStrip = toolStrip;
		}

		public bool AutoSize
		{
			get { return toolStrip.AutoSize; }
			set { toolStrip.AutoSize = value; }
		}

		public bool AutoScroll
		{
			get { return toolStrip.AutoScroll; }
			set { toolStrip.AutoScroll = value; }
		}

		public Size AutoScrollMargin
		{
			get { return toolStrip.AutoScrollMargin; }
			set { toolStrip.AutoScrollMargin = value; }
		}

		public Size AutoScrollMinSize
		{
			get { return toolStrip.AutoScrollMinSize; }
			set { toolStrip.AutoScrollMinSize = value; }
		}

		public Point AutoScrollPosition
		{
			get { return toolStrip.AutoScrollPosition; }
			set { toolStrip.AutoScrollPosition = value; }
		}

		public bool AllowDrop
		{
			get { return toolStrip.AllowDrop; }
			set { toolStrip.AllowDrop = value; }
		}

		public bool AllowItemReorder
		{
			get { return toolStrip.AllowItemReorder; }
			set { toolStrip.AllowItemReorder = value; }
		}

		public bool AllowMerge
		{
			get { return toolStrip.AllowMerge; }
			set { toolStrip.AllowMerge = value; }
		}

		public AnchorStyles Anchor
		{
			get { return toolStrip.Anchor; }
			set { toolStrip.Anchor = value; }
		}

		public Color BackColor
		{
			get { return toolStrip.BackColor; }
			set { toolStrip.BackColor = value; }
		}

		public BindingContext BindingContext
		{
			get { return toolStrip.BindingContext; }
			set { toolStrip.BindingContext = value; }
		}

		public bool CanOverflow
		{
			get { return toolStrip.CanOverflow; }
			set { toolStrip.CanOverflow = value; }
		}

		public bool CausesValidation
		{
			get { return toolStrip.CausesValidation; }
			set { toolStrip.CausesValidation = value; }
		}

		public Control.ControlCollection Controls
		{
			get { return toolStrip.Controls; }
		}

		public Cursor Cursor
		{
			get { return toolStrip.Cursor; }
			set { toolStrip.Cursor = value; }
		}

		public Font Font
		{
			get { return toolStrip.Font; }
			set { toolStrip.Font = value; }
		}

		public ToolStripDropDownDirection DefaultDropDownDirection
		{
			get { return toolStrip.DefaultDropDownDirection; }
			set { toolStrip.DefaultDropDownDirection = value; }
		}

		public DockStyle Dock
		{
			get { return toolStrip.Dock; }
			set { toolStrip.Dock = value; }
		}

		public Rectangle DisplayRectangle
		{
			get { return toolStrip.DisplayRectangle; }
		}

		public Color ForeColor
		{
			get { return toolStrip.ForeColor; }
			set { toolStrip.ForeColor = value; }
		}

		public ToolStripGripStyle GripStyle
		{
			get { return toolStrip.GripStyle; }
			set { toolStrip.GripStyle = value; }
		}

		public ToolStripGripDisplayStyle GripDisplayStyle
		{
			get { return toolStrip.GripDisplayStyle; }
		}

		public Padding GripMargin
		{
			get { return toolStrip.GripMargin; }
			set { toolStrip.GripMargin = value; }
		}

		public Rectangle GripRectangle
		{
			get { return toolStrip.GripRectangle; }
		}

		public bool HasChildren
		{
			get { return toolStrip.HasChildren; }
		}

		public HScrollProperties HorizontalScroll
		{
			get { return toolStrip.HorizontalScroll; }
		}

		public Size ImageScalingSize
		{
			get { return toolStrip.ImageScalingSize; }
			set { toolStrip.ImageScalingSize = value; }
		}

		public ImageList ImageList
		{
			get { return toolStrip.ImageList; }
			set { toolStrip.ImageList = value; }
		}

		public bool IsCurrentlyDragging
		{
			get { return toolStrip.IsCurrentlyDragging; }
		}

		public ToolStripItemCollection Items
		{
			get { return toolStrip.Items; }
		}

		public bool IsDropDown
		{
			get { return toolStrip.IsDropDown; }
		}

		public LayoutSettings LayoutSettings
		{
			get { return toolStrip.LayoutSettings; }
			set { toolStrip.LayoutSettings = value; }
		}

		public ToolStripLayoutStyle LayoutStyle
		{
			get { return toolStrip.LayoutStyle; }
			set { toolStrip.LayoutStyle = value; }
		}

		public LayoutEngine LayoutEngine
		{
			get { return toolStrip.LayoutEngine; }
		}

		public ToolStripOverflowButton OverflowButton
		{
			get { return toolStrip.OverflowButton; }
		}

		public Orientation Orientation
		{
			get { return toolStrip.Orientation; }
		}

		public bool Stretch
		{
			get { return toolStrip.Stretch; }
			set { toolStrip.Stretch = value; }
		}

		public ToolStripRenderer Renderer
		{
			get { return toolStrip.Renderer; }
			set { toolStrip.Renderer = value; }
		}

		public ToolStripRenderMode RenderMode
		{
			get { return toolStrip.RenderMode; }
			set { toolStrip.RenderMode = value; }
		}

		public bool ShowItemToolTips
		{
			get { return toolStrip.ShowItemToolTips; }
			set { toolStrip.ShowItemToolTips = value; }
		}

		public bool TabStop
		{
			get { return toolStrip.TabStop; }
			set { toolStrip.TabStop = value; }
		}

		public ToolStripTextDirection TextDirection
		{
			get { return toolStrip.TextDirection; }
			set { toolStrip.TextDirection = value; }
		}

		public VScrollProperties VerticalScroll
		{
			get { return toolStrip.VerticalScroll; }
		}

		public System.Windows.Forms.ToolStripItem GetNextItem(ToolStripItem start, ArrowDirection direction)
		{
			return toolStrip.GetNextItem(start, direction);
		}

		public Control GetChildAtPoint(Point point)
		{
			return toolStrip.GetChildAtPoint(point);
		}

		public Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue)
		{
			return toolStrip.GetChildAtPoint(pt, skipValue);
		}

		public void ResetMinimumSize()
		{
			toolStrip.ResetMinimumSize();
		}

		public void SetAutoScrollMargin(int x, int y)
		{
			toolStrip.SetAutoScrollMargin(x, y);
		}

		public override string ToString()
		{
			return toolStrip.ToString();
		}

		public event EventHandler AutoSizeChanged
		{
			add { toolStrip.AutoSizeChanged += value; }
			remove { toolStrip.AutoSizeChanged -= value; }
		}

		public event EventHandler BeginDrag
		{
			add { toolStrip.BeginDrag += value; }
			remove { toolStrip.BeginDrag -= value; }
		}

		public event EventHandler CausesValidationChanged
		{
			add { toolStrip.CausesValidationChanged += value; }
			remove { toolStrip.CausesValidationChanged -= value; }
		}

		public event ControlEventHandler ControlAdded
		{
			add { toolStrip.ControlAdded += value; }
			remove { toolStrip.ControlAdded -= value; }
		}

		public event EventHandler CursorChanged
		{
			add { toolStrip.CursorChanged += value; }
			remove { toolStrip.CursorChanged -= value; }
		}

		public event ControlEventHandler ControlRemoved
		{
			add { toolStrip.ControlRemoved += value; }
			remove { toolStrip.ControlRemoved -= value; }
		}

		public event EventHandler EndDrag
		{
			add { toolStrip.EndDrag += value; }
			remove { toolStrip.EndDrag -= value; }
		}

		public event EventHandler ForeColorChanged
		{
			add { toolStrip.ForeColorChanged += value; }
			remove { toolStrip.ForeColorChanged -= value; }
		}

		public event ToolStripItemEventHandler ItemAdded
		{
			add { toolStrip.ItemAdded += value; }
			remove { toolStrip.ItemAdded -= value; }
		}

		public event ToolStripItemClickedEventHandler ItemClicked
		{
			add { toolStrip.ItemClicked += value; }
			remove { toolStrip.ItemClicked -= value; }
		}

		public event ToolStripItemEventHandler ItemRemoved
		{
			add { toolStrip.ItemRemoved += value; }
			remove { toolStrip.ItemRemoved -= value; }
		}

		public event EventHandler LayoutCompleted
		{
			add { toolStrip.LayoutCompleted += value; }
			remove { toolStrip.LayoutCompleted -= value; }
		}

		public event EventHandler LayoutStyleChanged
		{
			add { toolStrip.LayoutStyleChanged += value; }
			remove { toolStrip.LayoutStyleChanged -= value; }
		}

		public event PaintEventHandler PaintGrip
		{
			add { toolStrip.PaintGrip += value; }
			remove { toolStrip.PaintGrip -= value; }
		}

		public event EventHandler RendererChanged
		{
			add { toolStrip.RendererChanged += value; }
			remove { toolStrip.RendererChanged -= value; }
		}
	}
}