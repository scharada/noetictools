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


namespace NoeticTools.DotNetWrappers.Windows.Forms
{
    public class ComboBox : ListControl, IComboBox
    {
        private readonly System.Windows.Forms.ComboBox comboBox;

        public ComboBox(System.Windows.Forms.ComboBox comboBox) : base(comboBox)
        {
            this.comboBox = comboBox;
        }

        public AutoCompleteMode AutoCompleteMode
        {
            get { return comboBox.AutoCompleteMode; }
            set { comboBox.AutoCompleteMode = value; }
        }

        public AutoCompleteSource AutoCompleteSource
        {
            get { return comboBox.AutoCompleteSource; }
            set { comboBox.AutoCompleteSource = value; }
        }

        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return comboBox.AutoCompleteCustomSource; }
            set { comboBox.AutoCompleteCustomSource = value; }
        }

        public DrawMode DrawMode
        {
            get { return comboBox.DrawMode; }
            set { comboBox.DrawMode = value; }
        }

        public int DropDownWidth
        {
            get { return comboBox.DropDownWidth; }
            set { comboBox.DropDownWidth = value; }
        }

        public int DropDownHeight
        {
            get { return comboBox.DropDownHeight; }
            set { comboBox.DropDownHeight = value; }
        }

        public bool DroppedDown
        {
            get { return comboBox.DroppedDown; }
            set { comboBox.DroppedDown = value; }
        }

        public FlatStyle FlatStyle
        {
            get { return comboBox.FlatStyle; }
            set { comboBox.FlatStyle = value; }
        }

        public bool IntegralHeight
        {
            get { return comboBox.IntegralHeight; }
            set { comboBox.IntegralHeight = value; }
        }

        public int ItemHeight
        {
            get { return comboBox.ItemHeight; }
            set { comboBox.ItemHeight = value; }
        }

        public System.Windows.Forms.ComboBox.ObjectCollection Items
        {
            get { return comboBox.Items; }
        }

        public int MaxDropDownItems
        {
            get { return comboBox.MaxDropDownItems; }
            set { comboBox.MaxDropDownItems = value; }
        }

        public int MaxLength
        {
            get { return comboBox.MaxLength; }
            set { comboBox.MaxLength = value; }
        }

        public int PreferredHeight
        {
            get { return comboBox.PreferredHeight; }
        }

        public object SelectedItem
        {
            get { return comboBox.SelectedItem; }
            set { comboBox.SelectedItem = value; }
        }

        public string SelectedText
        {
            get { return comboBox.SelectedText; }
            set { comboBox.SelectedText = value; }
        }

        public int SelectionLength
        {
            get { return comboBox.SelectionLength; }
            set { comboBox.SelectionLength = value; }
        }

        public int SelectionStart
        {
            get { return comboBox.SelectionStart; }
            set { comboBox.SelectionStart = value; }
        }

        public bool Sorted
        {
            get { return comboBox.Sorted; }
            set { comboBox.Sorted = value; }
        }

        public ComboBoxStyle DropDownStyle
        {
            get { return comboBox.DropDownStyle; }
            set { comboBox.DropDownStyle = value; }
        }

        public event DrawItemEventHandler DrawItem
        {
            add { comboBox.DrawItem += value; }
            remove { comboBox.DrawItem -= value; }
        }

        public event EventHandler DropDown
        {
            add { comboBox.DropDown += value; }
            remove { comboBox.DropDown -= value; }
        }

        public event MeasureItemEventHandler MeasureItem
        {
            add { comboBox.MeasureItem += value; }
            remove { comboBox.MeasureItem -= value; }
        }

        public event EventHandler SelectedIndexChanged
        {
            add { comboBox.SelectedIndexChanged += value; }
            remove { comboBox.SelectedIndexChanged -= value; }
        }

        public event EventHandler SelectionChangeCommitted
        {
            add { comboBox.SelectionChangeCommitted += value; }
            remove { comboBox.SelectionChangeCommitted -= value; }
        }

        public event EventHandler DropDownStyleChanged
        {
            add { comboBox.DropDownStyleChanged += value; }
            remove { comboBox.DropDownStyleChanged -= value; }
        }

        public event EventHandler TextUpdate
        {
            add { comboBox.TextUpdate += value; }
            remove { comboBox.TextUpdate -= value; }
        }

        public event EventHandler DropDownClosed
        {
            add { comboBox.DropDownClosed += value; }
            remove { comboBox.DropDownClosed -= value; }
        }

        public void BeginUpdate()
        {
            comboBox.BeginUpdate();
        }

        public void EndUpdate()
        {
            comboBox.EndUpdate();
        }

        public int FindString(string s)
        {
            return comboBox.FindString(s);
        }

        public int FindString(string s, int startIndex)
        {
            return comboBox.FindString(s, startIndex);
        }

        public int FindStringExact(string s)
        {
            return comboBox.FindStringExact(s);
        }

        public int FindStringExact(string s, int startIndex)
        {
            return comboBox.FindStringExact(s, startIndex);
        }

        public int GetItemHeight(int index)
        {
            return comboBox.GetItemHeight(index);
        }

        public void Select(int start, int length)
        {
            comboBox.Select(start, length);
        }

        public void SelectAll()
        {
            comboBox.SelectAll();
        }
    }
}