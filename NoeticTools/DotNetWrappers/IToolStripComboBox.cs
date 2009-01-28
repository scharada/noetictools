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
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
    public interface IToolStripComboBox : IToolStripControlHost
    {
        AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
        AutoCompleteMode AutoCompleteMode { get; set; }
        AutoCompleteSource AutoCompleteSource { get; set; }
        ComboBox ComboBox { get; }
        int DropDownHeight { get; set; }
        ComboBoxStyle DropDownStyle { get; set; }
        int DropDownWidth { get; set; }
        bool DroppedDown { get; set; }
        FlatStyle FlatStyle { get; set; }
        bool IntegralHeight { get; set; }
        ComboBox.ObjectCollection Items { get; }
        int MaxDropDownItems { get; set; }
        int MaxLength { get; set; }
        int SelectedIndex { get; set; }
        object SelectedItem { get; set; }
        string SelectedText { get; set; }
        int SelectionLength { get; set; }
        int SelectionStart { get; set; }
        bool Sorted { get; set; }

        void BeginUpdate();
        void EndUpdate();
        int FindString(string s);
        int FindString(string s, int startIndex);
        int FindStringExact(string s);
        int FindStringExact(string s, int startIndex);
        int GetItemHeight(int index);
        void Select(int start, int length);
        void SelectAll();

        event EventHandler DropDown;
        event EventHandler DropDownClosed;
        event EventHandler DropDownStyleChanged;
        event EventHandler SelectedIndexChanged;
        event EventHandler TextUpdate;
    }
}