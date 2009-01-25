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
    public interface IListControl : IControl
    {
        IContainer Container { get; }
        object DataSource { get; set; }
        string DisplayMember { get; set; }
        IFormatProvider FormatInfo { get; set; }
        string FormatString { get; set; }
        bool FormattingEnabled { get; set; }
        string ValueMember { get; set; }
        int SelectedIndex { get; set; }
        object SelectedValue { get; set; }
        IWindowTarget WindowTarget { get; set; }
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
    }
}