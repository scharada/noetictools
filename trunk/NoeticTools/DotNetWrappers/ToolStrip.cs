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
	public class ToolStrip : ScrollableControl, IToolStrip
	{
		private readonly System.Windows.Forms.ToolStrip toolStrip;

		public ToolStrip(System.Windows.Forms.ToolStrip toolStrip) : base(toolStrip)
		{
			this.toolStrip = toolStrip;
		}

		public static implicit operator System.Windows.Forms.ToolStrip (ToolStrip sourceToolStrip)
		{
			return sourceToolStrip.toolStrip;
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

		public bool CanOverflow
		{
			get { return toolStrip.CanOverflow; }
			set { toolStrip.CanOverflow = value; }
		}

		public ToolStripDropDownDirection DefaultDropDownDirection
		{
			get { return toolStrip.DefaultDropDownDirection; }
			set { toolStrip.DefaultDropDownDirection = value; }
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

		public IToolStripItemCollection Items
		{
			get { return new ToolStripItemCollection(toolStrip.Items); }
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

		public ToolStripTextDirection TextDirection
		{
			get { return toolStrip.TextDirection; }
			set { toolStrip.TextDirection = value; }
		}

		public System.Windows.Forms.ToolStripItem GetNextItem(ToolStripItem start, ArrowDirection direction)
		{
			return toolStrip.GetNextItem(start, direction);
		}

		public void ResetMinimumSize()
		{
			toolStrip.ResetMinimumSize();
		}

		public override string ToString()
		{
			return toolStrip.ToString();
		}

		public event EventHandler BeginDrag
		{
			add { toolStrip.BeginDrag += value; }
			remove { toolStrip.BeginDrag -= value; }
		}

		public event EventHandler EndDrag
		{
			add { toolStrip.EndDrag += value; }
			remove { toolStrip.EndDrag -= value; }
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