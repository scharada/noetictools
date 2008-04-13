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