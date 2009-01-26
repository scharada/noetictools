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
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Windows.Forms.Layout;


namespace NoeticTools.DotNetWrappers.Windows.Forms
{
    public interface IComboBox : IListControl
    {
        AutoCompleteMode AutoCompleteMode { get; set; }
        AutoCompleteSource AutoCompleteSource { get; set; }
        AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
        DrawMode DrawMode { get; set; }
        int DropDownWidth { get; set; }
        int DropDownHeight { get; set; }
        bool DroppedDown { get; set; }
        FlatStyle FlatStyle { get; set; }
        bool IntegralHeight { get; set; }
        int ItemHeight { get; set; }
        System.Windows.Forms.ComboBox.ObjectCollection Items { get; }
        int MaxDropDownItems { get; set; }
        int MaxLength { get; set; }
        int PreferredHeight { get; }
        object SelectedItem { get; set; }
        string SelectedText { get; set; }
        int SelectionLength { get; set; }
        int SelectionStart { get; set; }
        bool Sorted { get; set; }
        ComboBoxStyle DropDownStyle { get; set; }
        IContainer Container { get; }
        object DataSource { get; set; }
        string DisplayMember { get; set; }
        IFormatProvider FormatInfo { get; set; }
        string FormatString { get; set; }
        bool FormattingEnabled { get; set; }
        string ValueMember { get; set; }
        int SelectedIndex { get; set; }
        object SelectedValue { get; set; }
        AccessibleObject AccessibilityObject { get; }
        string AccessibleDefaultActionDescription { get; set; }
        string AccessibleDescription { get; set; }
        string AccessibleName { get; set; }
        AccessibleRole AccessibleRole { get; set; }
        bool AllowDrop { get; set; }
        AnchorStyles Anchor { get; set; }
        bool AutoSize { get; set; }
        Point AutoScrollOffset { get; set; }
        LayoutEngine LayoutEngine { get; }
        Color BackColor { get; set; }
        Image BackgroundImage { get; set; }
        ImageLayout BackgroundImageLayout { get; set; }
        BindingContext BindingContext { get; set; }
        int Bottom { get; }
        Rectangle Bounds { get; set; }
        bool CanFocus { get; }
        bool CanSelect { get; }
        bool Capture { get; set; }
        bool CausesValidation { get; set; }
        Rectangle ClientRectangle { get; }
        Size ClientSize { get; set; }
        string CompanyName { get; }
        bool ContainsFocus { get; }
        ContextMenu ContextMenu { get; set; }
        ContextMenuStrip ContextMenuStrip { get; set; }
        System.Windows.Forms.Control.ControlCollection Controls { get; }
        bool Created { get; }
        Cursor Cursor { get; set; }
        ControlBindingsCollection DataBindings { get; }
        Rectangle DisplayRectangle { get; }
        bool IsDisposed { get; }
        bool Disposing { get; }
        DockStyle Dock { get; set; }
        bool Enabled { get; set; }
        bool Focused { get; }
        Font Font { get; set; }
        Color ForeColor { get; set; }
        IntPtr Handle { get; }
        bool HasChildren { get; }
        int Height { get; set; }
        bool IsHandleCreated { get; }
        bool InvokeRequired { get; }
        bool IsAccessible { get; set; }
        bool IsMirrored { get; }
        int Left { get; set; }
        Point Location { get; set; }
        Padding Margin { get; set; }
        Size MaximumSize { get; set; }
        Size MinimumSize { get; set; }
        string Name { get; set; }
        System.Windows.Forms.Control Parent { get; set; }
        string ProductName { get; }
        string ProductVersion { get; }
        bool RecreatingHandle { get; }
        Region Region { get; set; }
        int Right { get; }
        RightToLeft RightToLeft { get; set; }
        ISite Site { get; set; }
        Size Size { get; set; }
        int TabIndex { get; set; }
        bool TabStop { get; set; }
        object Tag { get; set; }
        string Text { get; set; }
        int Top { get; set; }
        System.Windows.Forms.Control TopLevelControl { get; }
        bool UseWaitCursor { get; set; }
        bool Visible { get; set; }
        int Width { get; set; }
        IWindowTarget WindowTarget { get; set; }
        Size PreferredSize { get; }
        Padding Padding { get; set; }
        ImeMode ImeMode { get; set; }
        event DrawItemEventHandler DrawItem;
        event EventHandler DropDown;
        event MeasureItemEventHandler MeasureItem;
        event EventHandler SelectedIndexChanged;
        event EventHandler SelectionChangeCommitted;
        event EventHandler DropDownStyleChanged;
        event EventHandler TextUpdate;
        event EventHandler DropDownClosed;
        void BeginUpdate();
        void EndUpdate();
        int FindString(string s);
        int FindString(string s, int startIndex);
        int FindStringExact(string s);
        int FindStringExact(string s, int startIndex);
        int GetItemHeight(int index);
        void Select(int start, int length);
        void SelectAll();
        object GetLifetimeService();
        object InitializeLifetimeService();
        ObjRef CreateObjRef(Type requestedType);
        event EventHandler Disposed;
        void Dispose();
        void OnDragEnter(DragEventArgs e);
        void OnDragLeave(EventArgs e);
        void OnDragDrop(DragEventArgs e);
        void OnDragOver(DragEventArgs e);
        event PreviewKeyDownEventHandler PreviewKeyDown;
        bool PreProcessMessage(ref Message msg);
        PreProcessControlState PreProcessControlMessage(ref Message msg);
        event EventHandler DataSourceChanged;
        event EventHandler DisplayMemberChanged;
        event ListControlConvertEventHandler Format;
        event EventHandler FormatInfoChanged;
        event EventHandler FormatStringChanged;
        event EventHandler FormattingEnabledChanged;
        event EventHandler ValueMemberChanged;
        event EventHandler SelectedValueChanged;
        string GetItemText(object item);
        void ResetBindings();
        Size GetPreferredSize(Size proposedSize);
        IAsyncResult BeginInvoke(Delegate method);
        IAsyncResult BeginInvoke(Delegate method, params object[] args);
        void BringToFront();
        bool Contains(System.Windows.Forms.Control ctl);
        Graphics CreateGraphics();
        void CreateControl();
        DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects);
        void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);
        object EndInvoke(IAsyncResult asyncResult);
        Form FindForm();
        bool Focus();
        System.Windows.Forms.Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue);
        System.Windows.Forms.Control GetChildAtPoint(Point pt);
        IContainerControl GetContainerControl();
        System.Windows.Forms.Control GetNextControl(System.Windows.Forms.Control ctl, bool forward);
        void Hide();
        void Invalidate(Region region);
        void Invalidate(Region region, bool invalidateChildren);
        void Invalidate();
        void Invalidate(bool invalidateChildren);
        void Invalidate(Rectangle rc);
        void Invalidate(Rectangle rc, bool invalidateChildren);
        object Invoke(Delegate method);
        object Invoke(Delegate method, params object[] args);
        void PerformLayout();
        void PerformLayout(System.Windows.Forms.Control affectedControl, string affectedProperty);
        Point PointToClient(Point p);
        Point PointToScreen(Point p);
        void ResetBackColor();
        void ResetCursor();
        void ResetFont();
        void ResetForeColor();
        void ResetRightToLeft();
        Rectangle RectangleToClient(Rectangle r);
        Rectangle RectangleToScreen(Rectangle r);
        void Refresh();
        void ResetText();
        void ResumeLayout();
        void ResumeLayout(bool performLayout);
        void Scale(SizeF factor);
        void Select();
        bool SelectNextControl(System.Windows.Forms.Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap);
        void SendToBack();
        void SetBounds(int x, int y, int width, int height);
        void SetBounds(int x, int y, int width, int height, BoundsSpecified specified);
        void Show();
        void SuspendLayout();
        void Update();
        void ResetImeMode();
        event EventHandler AutoSizeChanged;
        event EventHandler BackColorChanged;
        event EventHandler BackgroundImageChanged;
        event EventHandler BackgroundImageLayoutChanged;
        event EventHandler BindingContextChanged;
        event EventHandler CausesValidationChanged;
        event EventHandler ClientSizeChanged;
        event EventHandler ContextMenuChanged;
        event EventHandler ContextMenuStripChanged;
        event EventHandler CursorChanged;
        event EventHandler DockChanged;
        event EventHandler EnabledChanged;
        event EventHandler FontChanged;
        event EventHandler ForeColorChanged;
        event EventHandler LocationChanged;
        event EventHandler MarginChanged;
        event EventHandler RegionChanged;
        event EventHandler RightToLeftChanged;
        event EventHandler SizeChanged;
        event EventHandler TabIndexChanged;
        event EventHandler TabStopChanged;
        event EventHandler TextChanged;
        event EventHandler VisibleChanged;
        event EventHandler Click;
        event ControlEventHandler ControlAdded;
        event ControlEventHandler ControlRemoved;
        event DragEventHandler DragDrop;
        event DragEventHandler DragEnter;
        event DragEventHandler DragOver;
        event EventHandler DragLeave;
        event GiveFeedbackEventHandler GiveFeedback;
        event EventHandler HandleCreated;
        event EventHandler HandleDestroyed;
        event HelpEventHandler HelpRequested;
        event InvalidateEventHandler Invalidated;
        event EventHandler PaddingChanged;
        event PaintEventHandler Paint;
        event QueryContinueDragEventHandler QueryContinueDrag;
        event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
        event EventHandler DoubleClick;
        event EventHandler Enter;
        event EventHandler GotFocus;
        event KeyEventHandler KeyDown;
        event KeyPressEventHandler KeyPress;
        event KeyEventHandler KeyUp;
        event LayoutEventHandler Layout;
        event EventHandler Leave;
        event EventHandler LostFocus;
        event MouseEventHandler MouseClick;
        event MouseEventHandler MouseDoubleClick;
        event EventHandler MouseCaptureChanged;
        event MouseEventHandler MouseDown;
        event EventHandler MouseEnter;
        event EventHandler MouseLeave;
        event EventHandler MouseHover;
        event MouseEventHandler MouseMove;
        event MouseEventHandler MouseUp;
        event MouseEventHandler MouseWheel;
        event EventHandler Move;
        event EventHandler Resize;
        event UICuesEventHandler ChangeUICues;
        event EventHandler StyleChanged;
        event EventHandler SystemColorsChanged;
        event CancelEventHandler Validating;
        event EventHandler Validated;
        event EventHandler ParentChanged;
        event EventHandler ImeModeChanged;
    }
}