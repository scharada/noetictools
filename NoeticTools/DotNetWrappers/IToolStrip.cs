using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;


namespace NoeticTools.DotNetWrappers
{
	public interface IToolStrip
	{
		bool AutoSize { get; set; }
		bool AutoScroll { get; set; }
		Size AutoScrollMargin { get; set; }
		Size AutoScrollMinSize { get; set; }
		Point AutoScrollPosition { get; set; }
		bool AllowDrop { get; set; }
		bool AllowItemReorder { get; set; }
		bool AllowMerge { get; set; }
		AnchorStyles Anchor { get; set; }
		Color BackColor { get; set; }
		BindingContext BindingContext { get; set; }
		bool CanOverflow { get; set; }
		bool CausesValidation { get; set; }
		Control.ControlCollection Controls { get; }
		Cursor Cursor { get; set; }
		Font Font { get; set; }
		ToolStripDropDownDirection DefaultDropDownDirection { get; set; }
		DockStyle Dock { get; set; }
		Rectangle DisplayRectangle { get; }
		Color ForeColor { get; set; }
		ToolStripGripStyle GripStyle { get; set; }
		ToolStripGripDisplayStyle GripDisplayStyle { get; }
		Padding GripMargin { get; set; }
		Rectangle GripRectangle { get; }
		bool HasChildren { get; }
		HScrollProperties HorizontalScroll { get; }
		Size ImageScalingSize { get; set; }
		ImageList ImageList { get; set; }
		bool IsCurrentlyDragging { get; }
		ToolStripItemCollection Items { get; }
		bool IsDropDown { get; }
		LayoutSettings LayoutSettings { get; set; }
		ToolStripLayoutStyle LayoutStyle { get; set; }
		LayoutEngine LayoutEngine { get; }
		ToolStripOverflowButton OverflowButton { get; }
		Orientation Orientation { get; }
		bool Stretch { get; set; }
		ToolStripRenderer Renderer { get; set; }
		ToolStripRenderMode RenderMode { get; set; }
		bool ShowItemToolTips { get; set; }
		bool TabStop { get; set; }
		ToolStripTextDirection TextDirection { get; set; }
		VScrollProperties VerticalScroll { get; }

		ToolStripItem GetNextItem(ToolStripItem start, ArrowDirection direction);
		Control GetChildAtPoint(Point point);
		Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue);
		ToolStripItem GetItemAt(int x, int y);
		ToolStripItem GetItemAt(Point point);
		void ResetMinimumSize();
		void SetAutoScrollMargin(int x, int y);
		string ToString();

		event EventHandler AutoSizeChanged;
		event EventHandler BeginDrag;
		event EventHandler CausesValidationChanged;
		event ControlEventHandler ControlAdded;
		event EventHandler CursorChanged;
		event ControlEventHandler ControlRemoved;
		event EventHandler EndDrag;
		event EventHandler ForeColorChanged;
		event ToolStripItemEventHandler ItemAdded;
		event ToolStripItemClickedEventHandler ItemClicked;
		event ToolStripItemEventHandler ItemRemoved;
		event EventHandler LayoutCompleted;
		event EventHandler LayoutStyleChanged;
		event PaintEventHandler PaintGrip;
		event EventHandler RendererChanged;
	}
}