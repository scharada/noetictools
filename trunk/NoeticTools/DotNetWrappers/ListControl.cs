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
using System.Runtime.Remoting;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
    public class ListControl : Control, IListControl
    {
        private readonly System.Windows.Forms.ListControl listControl;

        public object GetLifetimeService()
        {
            return listControl.GetLifetimeService();
        }

        public object InitializeLifetimeService()
        {
            return listControl.InitializeLifetimeService();
        }

        public ObjRef CreateObjRef(Type requestedType)
        {
            return listControl.CreateObjRef(requestedType);
        }

        public event EventHandler Disposed
        {
            add { listControl.Disposed += value; }
            remove { listControl.Disposed -= value; }
        }

        public void Dispose()
        {
            listControl.Dispose();
        }

        public IContainer Container
        {
            get { return listControl.Container; }
        }

        public void OnDragEnter(DragEventArgs e)
        {
            ((IDropTarget) listControl).OnDragEnter(e);
        }

        public void OnDragLeave(EventArgs e)
        {
            ((IDropTarget) listControl).OnDragLeave(e);
        }

        public void OnDragDrop(DragEventArgs e)
        {
            ((IDropTarget) listControl).OnDragDrop(e);
        }

        public void OnDragOver(DragEventArgs e)
        {
            ((IDropTarget) listControl).OnDragOver(e);
        }

        public event PreviewKeyDownEventHandler PreviewKeyDown
        {
            add { listControl.PreviewKeyDown += value; }
            remove { listControl.PreviewKeyDown -= value; }
        }

        public bool PreProcessMessage(ref Message msg)
        {
            return listControl.PreProcessMessage(ref msg);
        }

        public PreProcessControlState PreProcessControlMessage(ref Message msg)
        {
            return listControl.PreProcessControlMessage(ref msg);
        }

        public event EventHandler DataSourceChanged
        {
            add { listControl.DataSourceChanged += value; }
            remove { listControl.DataSourceChanged -= value; }
        }

        public event EventHandler DisplayMemberChanged
        {
            add { listControl.DisplayMemberChanged += value; }
            remove { listControl.DisplayMemberChanged -= value; }
        }

        public event ListControlConvertEventHandler Format
        {
            add { listControl.Format += value; }
            remove { listControl.Format -= value; }
        }

        public event EventHandler FormatInfoChanged
        {
            add { listControl.FormatInfoChanged += value; }
            remove { listControl.FormatInfoChanged -= value; }
        }

        public event EventHandler FormatStringChanged
        {
            add { listControl.FormatStringChanged += value; }
            remove { listControl.FormatStringChanged -= value; }
        }

        public event EventHandler FormattingEnabledChanged
        {
            add { listControl.FormattingEnabledChanged += value; }
            remove { listControl.FormattingEnabledChanged -= value; }
        }

        public event EventHandler ValueMemberChanged
        {
            add { listControl.ValueMemberChanged += value; }
            remove { listControl.ValueMemberChanged -= value; }
        }

        public event EventHandler SelectedValueChanged
        {
            add { listControl.SelectedValueChanged += value; }
            remove { listControl.SelectedValueChanged -= value; }
        }

        public string GetItemText(object item)
        {
            return listControl.GetItemText(item);
        }

        public object DataSource
        {
            get { return listControl.DataSource; }
            set { listControl.DataSource = value; }
        }

        public string DisplayMember
        {
            get { return listControl.DisplayMember; }
            set { listControl.DisplayMember = value; }
        }

        public IFormatProvider FormatInfo
        {
            get { return listControl.FormatInfo; }
            set { listControl.FormatInfo = value; }
        }

        public string FormatString
        {
            get { return listControl.FormatString; }
            set { listControl.FormatString = value; }
        }

        public bool FormattingEnabled
        {
            get { return listControl.FormattingEnabled; }
            set { listControl.FormattingEnabled = value; }
        }

        public string ValueMember
        {
            get { return listControl.ValueMember; }
            set { listControl.ValueMember = value; }
        }

        public int SelectedIndex
        {
            get { return listControl.SelectedIndex; }
            set { listControl.SelectedIndex = value; }
        }

        public object SelectedValue
        {
            get { return listControl.SelectedValue; }
            set { listControl.SelectedValue = value; }
        }

        public ListControl(System.Windows.Forms.ListControl listControl)
            : base(listControl)
        {
            this.listControl = listControl;
        }
    }
}