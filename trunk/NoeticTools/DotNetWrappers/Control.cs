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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;


namespace NoeticTools.DotNetWrappers
{
    public class Control : IControl
    {
        private readonly System.Windows.Forms.Control control;

        public Control(System.Windows.Forms.Control control)
        {
            this.control = control;
        }

        public IWindowTarget WindowTarget
        {
            get { return control.WindowTarget; }
            set { control.WindowTarget = value; }
        }

        public AccessibleObject AccessibilityObject
        {
            get { return control.AccessibilityObject; }
        }

        public string AccessibleDefaultActionDescription
        {
            get { return control.AccessibleDefaultActionDescription; }
            set { control.AccessibleDefaultActionDescription = value; }
        }

        public string AccessibleDescription
        {
            get { return control.AccessibleDescription; }
            set { control.AccessibleDescription = value; }
        }

        public string AccessibleName
        {
            get { return control.AccessibleName; }
            set { control.AccessibleName = value; }
        }

        public AccessibleRole AccessibleRole
        {
            get { return control.AccessibleRole; }
            set { control.AccessibleRole = value; }
        }

        public bool AllowDrop
        {
            get { return control.AllowDrop; }
            set { control.AllowDrop = value; }
        }

        public AnchorStyles Anchor
        {
            get { return control.Anchor; }
            set { control.Anchor = value; }
        }

        public bool AutoSize
        {
            get { return control.AutoSize; }
            set { control.AutoSize = value; }
        }

        public Point AutoScrollOffset
        {
            get { return control.AutoScrollOffset; }
            set { control.AutoScrollOffset = value; }
        }

        public LayoutEngine LayoutEngine
        {
            get { return control.LayoutEngine; }
        }

        public Color BackColor
        {
            get { return control.BackColor; }
            set { control.BackColor = value; }
        }

        public Image BackgroundImage
        {
            get { return control.BackgroundImage; }
            set { control.BackgroundImage = value; }
        }

        public ImageLayout BackgroundImageLayout
        {
            get { return control.BackgroundImageLayout; }
            set { control.BackgroundImageLayout = value; }
        }

        public BindingContext BindingContext
        {
            get { return control.BindingContext; }
            set { control.BindingContext = value; }
        }

        public int Bottom
        {
            get { return control.Bottom; }
        }

        public Rectangle Bounds
        {
            get { return control.Bounds; }
            set { control.Bounds = value; }
        }

        public bool CanFocus
        {
            get { return control.CanFocus; }
        }

        public bool CanSelect
        {
            get { return control.CanSelect; }
        }

        public bool Capture
        {
            get { return control.Capture; }
            set { control.Capture = value; }
        }

        public bool CausesValidation
        {
            get { return control.CausesValidation; }
            set { control.CausesValidation = value; }
        }

        public Rectangle ClientRectangle
        {
            get { return control.ClientRectangle; }
        }

        public Size ClientSize
        {
            get { return control.ClientSize; }
            set { control.ClientSize = value; }
        }

        public string CompanyName
        {
            get { return control.CompanyName; }
        }

        public bool ContainsFocus
        {
            get { return control.ContainsFocus; }
        }

        public ContextMenu ContextMenu
        {
            get { return control.ContextMenu; }
            set { control.ContextMenu = value; }
        }

        public ContextMenuStrip ContextMenuStrip
        {
            get { return control.ContextMenuStrip; }
            set { control.ContextMenuStrip = value; }
        }

        public System.Windows.Forms.Control.ControlCollection Controls
        {
            get { return control.Controls; }
        }

        public bool Created
        {
            get { return control.Created; }
        }

        public Cursor Cursor
        {
            get { return control.Cursor; }
            set { control.Cursor = value; }
        }

        public ControlBindingsCollection DataBindings
        {
            get { return control.DataBindings; }
        }

        public Rectangle DisplayRectangle
        {
            get { return control.DisplayRectangle; }
        }

        public bool IsDisposed
        {
            get { return control.IsDisposed; }
        }

        public bool Disposing
        {
            get { return control.Disposing; }
        }

        public DockStyle Dock
        {
            get { return control.Dock; }
            set { control.Dock = value; }
        }

        public bool Enabled
        {
            get { return control.Enabled; }
            set { control.Enabled = value; }
        }

        public bool Focused
        {
            get { return control.Focused; }
        }

        public Font Font
        {
            get { return control.Font; }
            set { control.Font = value; }
        }

        public Color ForeColor
        {
            get { return control.ForeColor; }
            set { control.ForeColor = value; }
        }

        public IntPtr Handle
        {
            get { return control.Handle; }
        }

        public bool HasChildren
        {
            get { return control.HasChildren; }
        }

        public int Height
        {
            get { return control.Height; }
            set { control.Height = value; }
        }

        public bool IsHandleCreated
        {
            get { return control.IsHandleCreated; }
        }

        public bool InvokeRequired
        {
            get { return control.InvokeRequired; }
        }

        public bool IsAccessible
        {
            get { return control.IsAccessible; }
            set { control.IsAccessible = value; }
        }

        public bool IsMirrored
        {
            get { return control.IsMirrored; }
        }

        public int Left
        {
            get { return control.Left; }
            set { control.Left = value; }
        }

        public Point Location
        {
            get { return control.Location; }
            set { control.Location = value; }
        }

        public Padding Margin
        {
            get { return control.Margin; }
            set { control.Margin = value; }
        }

        public Size MaximumSize
        {
            get { return control.MaximumSize; }
            set { control.MaximumSize = value; }
        }

        public Size MinimumSize
        {
            get { return control.MinimumSize; }
            set { control.MinimumSize = value; }
        }

        public string Name
        {
            get { return control.Name; }
            set { control.Name = value; }
        }

        public System.Windows.Forms.Control Parent
        {
            get { return control.Parent; }
            set { control.Parent = value; }
        }

        public string ProductName
        {
            get { return control.ProductName; }
        }

        public string ProductVersion
        {
            get { return control.ProductVersion; }
        }

        public bool RecreatingHandle
        {
            get { return control.RecreatingHandle; }
        }

        public Region Region
        {
            get { return control.Region; }
            set { control.Region = value; }
        }

        public int Right
        {
            get { return control.Right; }
        }

        public RightToLeft RightToLeft
        {
            get { return control.RightToLeft; }
            set { control.RightToLeft = value; }
        }

        public ISite Site
        {
            get { return control.Site; }
            set { control.Site = value; }
        }

        public Size Size
        {
            get { return control.Size; }
            set { control.Size = value; }
        }

        public int TabIndex
        {
            get { return control.TabIndex; }
            set { control.TabIndex = value; }
        }

        public bool TabStop
        {
            get { return control.TabStop; }
            set { control.TabStop = value; }
        }

        public object Tag
        {
            get { return control.Tag; }
            set { control.Tag = value; }
        }

        public string Text
        {
            get { return control.Text; }
            set { control.Text = value; }
        }

        public int Top
        {
            get { return control.Top; }
            set { control.Top = value; }
        }

        public System.Windows.Forms.Control TopLevelControl
        {
            get { return control.TopLevelControl; }
        }

        public bool UseWaitCursor
        {
            get { return control.UseWaitCursor; }
            set { control.UseWaitCursor = value; }
        }

        public bool Visible
        {
            get { return control.Visible; }
            set { control.Visible = value; }
        }

        public int Width
        {
            get { return control.Width; }
            set { control.Width = value; }
        }

        public Size PreferredSize
        {
            get { return control.PreferredSize; }
        }

        public Padding Padding
        {
            get { return control.Padding; }
            set { control.Padding = value; }
        }

        public ImeMode ImeMode
        {
            get { return control.ImeMode; }
            set { control.ImeMode = value; }
        }

        public System.Windows.Forms.Control WrappedControl
        {
            get { return control; }
        }

        public void ResetBindings()
        {
            control.ResetBindings();
        }

        public Size GetPreferredSize(Size proposedSize)
        {
            return control.GetPreferredSize(proposedSize);
        }

        public IAsyncResult BeginInvoke(Delegate method)
        {
            return control.BeginInvoke(method);
        }

        public IAsyncResult BeginInvoke(Delegate method, params object[] args)
        {
            return control.BeginInvoke(method, args);
        }

        public void BringToFront()
        {
            control.BringToFront();
        }

        public bool Contains(System.Windows.Forms.Control ctl)
        {
            return control.Contains(ctl);
        }

        public Graphics CreateGraphics()
        {
            return control.CreateGraphics();
        }

        public void CreateControl()
        {
            control.CreateControl();
        }

        public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects)
        {
            return control.DoDragDrop(data, allowedEffects);
        }

        public void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds)
        {
            control.DrawToBitmap(bitmap, targetBounds);
        }

        public object EndInvoke(IAsyncResult asyncResult)
        {
            return control.EndInvoke(asyncResult);
        }

        public Form FindForm()
        {
            return control.FindForm();
        }

        public bool Focus()
        {
            return control.Focus();
        }

        public System.Windows.Forms.Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue)
        {
            return control.GetChildAtPoint(pt, skipValue);
        }

        public System.Windows.Forms.Control GetChildAtPoint(Point pt)
        {
            return control.GetChildAtPoint(pt);
        }

        public IContainerControl GetContainerControl()
        {
            return control.GetContainerControl();
        }

        public System.Windows.Forms.Control GetNextControl(System.Windows.Forms.Control ctl, bool forward)
        {
            return control.GetNextControl(ctl, forward);
        }

        public void Hide()
        {
            control.Hide();
        }

        public void Invalidate(Region region)
        {
            control.Invalidate(region);
        }

        public void Invalidate(Region region, bool invalidateChildren)
        {
            control.Invalidate(region, invalidateChildren);
        }

        public void Invalidate()
        {
            control.Invalidate();
        }

        public void Invalidate(bool invalidateChildren)
        {
            control.Invalidate(invalidateChildren);
        }

        public void Invalidate(Rectangle rc)
        {
            control.Invalidate(rc);
        }

        public void Invalidate(Rectangle rc, bool invalidateChildren)
        {
            control.Invalidate(rc, invalidateChildren);
        }

        public object Invoke(Delegate method)
        {
            return control.Invoke(method);
        }

        public object Invoke(Delegate method, params object[] args)
        {
            return control.Invoke(method, args);
        }

        public void PerformLayout()
        {
            control.PerformLayout();
        }

        public void PerformLayout(System.Windows.Forms.Control affectedControl, string affectedProperty)
        {
            control.PerformLayout(affectedControl, affectedProperty);
        }

        public Point PointToClient(Point p)
        {
            return control.PointToClient(p);
        }

        public Point PointToScreen(Point p)
        {
            return control.PointToScreen(p);
        }

        public void ResetBackColor()
        {
            control.ResetBackColor();
        }

        public void ResetCursor()
        {
            control.ResetCursor();
        }

        public void ResetFont()
        {
            control.ResetFont();
        }

        public void ResetForeColor()
        {
            control.ResetForeColor();
        }

        public void ResetRightToLeft()
        {
            control.ResetRightToLeft();
        }

        public Rectangle RectangleToClient(Rectangle r)
        {
            return control.RectangleToClient(r);
        }

        public Rectangle RectangleToScreen(Rectangle r)
        {
            return control.RectangleToScreen(r);
        }

        public void Refresh()
        {
            control.Refresh();
        }

        public void ResetText()
        {
            control.ResetText();
        }

        public void ResumeLayout()
        {
            control.ResumeLayout();
        }

        public void ResumeLayout(bool performLayout)
        {
            control.ResumeLayout(performLayout);
        }

        public void Scale(SizeF factor)
        {
            control.Scale(factor);
        }

        public void Select()
        {
            control.Select();
        }

        public bool SelectNextControl(System.Windows.Forms.Control ctl, bool forward, bool tabStopOnly, bool nested,
                                      bool wrap)
        {
            return control.SelectNextControl(ctl, forward, tabStopOnly, nested, wrap);
        }

        public void SendToBack()
        {
            control.SendToBack();
        }

        public void SetBounds(int x, int y, int width, int height)
        {
            control.SetBounds(x, y, width, height);
        }

        public void SetBounds(int x, int y, int width, int height, BoundsSpecified specified)
        {
            control.SetBounds(x, y, width, height, specified);
        }

        public void Show()
        {
            control.Show();
        }

        public void SuspendLayout()
        {
            control.SuspendLayout();
        }

        public void Update()
        {
            control.Update();
        }

        public void ResetImeMode()
        {
            control.ResetImeMode();
        }

        public event EventHandler AutoSizeChanged
        {
            add { control.AutoSizeChanged += value; }
            remove { control.AutoSizeChanged -= value; }
        }

        public event EventHandler BackColorChanged
        {
            add { control.BackColorChanged += value; }
            remove { control.BackColorChanged -= value; }
        }

        public event EventHandler BackgroundImageChanged
        {
            add { control.BackgroundImageChanged += value; }
            remove { control.BackgroundImageChanged -= value; }
        }

        public event EventHandler BackgroundImageLayoutChanged
        {
            add { control.BackgroundImageLayoutChanged += value; }
            remove { control.BackgroundImageLayoutChanged -= value; }
        }

        public event EventHandler BindingContextChanged
        {
            add { control.BindingContextChanged += value; }
            remove { control.BindingContextChanged -= value; }
        }

        public event EventHandler CausesValidationChanged
        {
            add { control.CausesValidationChanged += value; }
            remove { control.CausesValidationChanged -= value; }
        }

        public event EventHandler ClientSizeChanged
        {
            add { control.ClientSizeChanged += value; }
            remove { control.ClientSizeChanged -= value; }
        }

        public event EventHandler ContextMenuChanged
        {
            add { control.ContextMenuChanged += value; }
            remove { control.ContextMenuChanged -= value; }
        }

        public event EventHandler ContextMenuStripChanged
        {
            add { control.ContextMenuStripChanged += value; }
            remove { control.ContextMenuStripChanged -= value; }
        }

        public event EventHandler CursorChanged
        {
            add { control.CursorChanged += value; }
            remove { control.CursorChanged -= value; }
        }

        public event EventHandler DockChanged
        {
            add { control.DockChanged += value; }
            remove { control.DockChanged -= value; }
        }

        public event EventHandler EnabledChanged
        {
            add { control.EnabledChanged += value; }
            remove { control.EnabledChanged -= value; }
        }

        public event EventHandler FontChanged
        {
            add { control.FontChanged += value; }
            remove { control.FontChanged -= value; }
        }

        public event EventHandler ForeColorChanged
        {
            add { control.ForeColorChanged += value; }
            remove { control.ForeColorChanged -= value; }
        }

        public event EventHandler LocationChanged
        {
            add { control.LocationChanged += value; }
            remove { control.LocationChanged -= value; }
        }

        public event EventHandler MarginChanged
        {
            add { control.MarginChanged += value; }
            remove { control.MarginChanged -= value; }
        }

        public event EventHandler RegionChanged
        {
            add { control.RegionChanged += value; }
            remove { control.RegionChanged -= value; }
        }

        public event EventHandler RightToLeftChanged
        {
            add { control.RightToLeftChanged += value; }
            remove { control.RightToLeftChanged -= value; }
        }

        public event EventHandler SizeChanged
        {
            add { control.SizeChanged += value; }
            remove { control.SizeChanged -= value; }
        }

        public event EventHandler TabIndexChanged
        {
            add { control.TabIndexChanged += value; }
            remove { control.TabIndexChanged -= value; }
        }

        public event EventHandler TabStopChanged
        {
            add { control.TabStopChanged += value; }
            remove { control.TabStopChanged -= value; }
        }

        public event EventHandler TextChanged
        {
            add { control.TextChanged += value; }
            remove { control.TextChanged -= value; }
        }

        public event EventHandler VisibleChanged
        {
            add { control.VisibleChanged += value; }
            remove { control.VisibleChanged -= value; }
        }

        public event EventHandler Click
        {
            add { control.Click += value; }
            remove { control.Click -= value; }
        }

        public event ControlEventHandler ControlAdded
        {
            add { control.ControlAdded += value; }
            remove { control.ControlAdded -= value; }
        }

        public event ControlEventHandler ControlRemoved
        {
            add { control.ControlRemoved += value; }
            remove { control.ControlRemoved -= value; }
        }

        public event DragEventHandler DragDrop
        {
            add { control.DragDrop += value; }
            remove { control.DragDrop -= value; }
        }

        public event DragEventHandler DragEnter
        {
            add { control.DragEnter += value; }
            remove { control.DragEnter -= value; }
        }

        public event DragEventHandler DragOver
        {
            add { control.DragOver += value; }
            remove { control.DragOver -= value; }
        }

        public event EventHandler DragLeave
        {
            add { control.DragLeave += value; }
            remove { control.DragLeave -= value; }
        }

        public event GiveFeedbackEventHandler GiveFeedback
        {
            add { control.GiveFeedback += value; }
            remove { control.GiveFeedback -= value; }
        }

        public event EventHandler HandleCreated
        {
            add { control.HandleCreated += value; }
            remove { control.HandleCreated -= value; }
        }

        public event EventHandler HandleDestroyed
        {
            add { control.HandleDestroyed += value; }
            remove { control.HandleDestroyed -= value; }
        }

        public event HelpEventHandler HelpRequested
        {
            add { control.HelpRequested += value; }
            remove { control.HelpRequested -= value; }
        }

        public event InvalidateEventHandler Invalidated
        {
            add { control.Invalidated += value; }
            remove { control.Invalidated -= value; }
        }

        public event EventHandler PaddingChanged
        {
            add { control.PaddingChanged += value; }
            remove { control.PaddingChanged -= value; }
        }

        public event PaintEventHandler Paint
        {
            add { control.Paint += value; }
            remove { control.Paint -= value; }
        }

        public event QueryContinueDragEventHandler QueryContinueDrag
        {
            add { control.QueryContinueDrag += value; }
            remove { control.QueryContinueDrag -= value; }
        }

        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp
        {
            add { control.QueryAccessibilityHelp += value; }
            remove { control.QueryAccessibilityHelp -= value; }
        }

        public event EventHandler DoubleClick
        {
            add { control.DoubleClick += value; }
            remove { control.DoubleClick -= value; }
        }

        public event EventHandler Enter
        {
            add { control.Enter += value; }
            remove { control.Enter -= value; }
        }

        public event EventHandler GotFocus
        {
            add { control.GotFocus += value; }
            remove { control.GotFocus -= value; }
        }

        public event KeyEventHandler KeyDown
        {
            add { control.KeyDown += value; }
            remove { control.KeyDown -= value; }
        }

        public event KeyPressEventHandler KeyPress
        {
            add { control.KeyPress += value; }
            remove { control.KeyPress -= value; }
        }

        public event KeyEventHandler KeyUp
        {
            add { control.KeyUp += value; }
            remove { control.KeyUp -= value; }
        }

        public event LayoutEventHandler Layout
        {
            add { control.Layout += value; }
            remove { control.Layout -= value; }
        }

        public event EventHandler Leave
        {
            add { control.Leave += value; }
            remove { control.Leave -= value; }
        }

        public event EventHandler LostFocus
        {
            add { control.LostFocus += value; }
            remove { control.LostFocus -= value; }
        }

        public event MouseEventHandler MouseClick
        {
            add { control.MouseClick += value; }
            remove { control.MouseClick -= value; }
        }

        public event MouseEventHandler MouseDoubleClick
        {
            add { control.MouseDoubleClick += value; }
            remove { control.MouseDoubleClick -= value; }
        }

        public event EventHandler MouseCaptureChanged
        {
            add { control.MouseCaptureChanged += value; }
            remove { control.MouseCaptureChanged -= value; }
        }

        public event MouseEventHandler MouseDown
        {
            add { control.MouseDown += value; }
            remove { control.MouseDown -= value; }
        }

        public event EventHandler MouseEnter
        {
            add { control.MouseEnter += value; }
            remove { control.MouseEnter -= value; }
        }

        public event EventHandler MouseLeave
        {
            add { control.MouseLeave += value; }
            remove { control.MouseLeave -= value; }
        }

        public event EventHandler MouseHover
        {
            add { control.MouseHover += value; }
            remove { control.MouseHover -= value; }
        }

        public event MouseEventHandler MouseMove
        {
            add { control.MouseMove += value; }
            remove { control.MouseMove -= value; }
        }

        public event MouseEventHandler MouseUp
        {
            add { control.MouseUp += value; }
            remove { control.MouseUp -= value; }
        }

        public event MouseEventHandler MouseWheel
        {
            add { control.MouseWheel += value; }
            remove { control.MouseWheel -= value; }
        }

        public event EventHandler Move
        {
            add { control.Move += value; }
            remove { control.Move -= value; }
        }

        public event EventHandler Resize
        {
            add { control.Resize += value; }
            remove { control.Resize -= value; }
        }

        public event UICuesEventHandler ChangeUICues
        {
            add { control.ChangeUICues += value; }
            remove { control.ChangeUICues -= value; }
        }

        public event EventHandler StyleChanged
        {
            add { control.StyleChanged += value; }
            remove { control.StyleChanged -= value; }
        }

        public event EventHandler SystemColorsChanged
        {
            add { control.SystemColorsChanged += value; }
            remove { control.SystemColorsChanged -= value; }
        }

        public event CancelEventHandler Validating
        {
            add { control.Validating += value; }
            remove { control.Validating -= value; }
        }

        public event EventHandler Validated
        {
            add { control.Validated += value; }
            remove { control.Validated -= value; }
        }

        public event EventHandler ParentChanged
        {
            add { control.ParentChanged += value; }
            remove { control.ParentChanged -= value; }
        }

        public event EventHandler ImeModeChanged
        {
            add { control.ImeModeChanged += value; }
            remove { control.ImeModeChanged -= value; }
        }

        public static explicit operator System.Windows.Forms.Control(Control sourceControl)
        {
            return sourceControl.control;
        }
    }
}