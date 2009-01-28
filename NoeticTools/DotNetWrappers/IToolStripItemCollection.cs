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
using System.Collections;
using System.Drawing;


namespace NoeticTools.DotNetWrappers
{
    public interface IToolStripItemCollection
    {
        IToolStripItem this[int index] { get; }
        IToolStripItem this[string name] { get; }
        bool IsReadOnly { get; }
        int Count { get; }

        System.Windows.Forms.ToolStripItem Add(string text);
        System.Windows.Forms.ToolStripItem Add(Image image);
        System.Windows.Forms.ToolStripItem Add(string text, Image image);
        System.Windows.Forms.ToolStripItem Add(string text, Image image, EventHandler onClick);
        int Add(IToolStripItem value);
        void AddRange(IToolStripItem[] toolStripItems);
        void AddRange(IToolStripItemCollection toolStripItems);
        bool Contains(IToolStripItem value);
        bool ContainsKey(string key);
        IToolStripItem[] Find(string key, bool searchAllChildren);
        void Insert(int index, IToolStripItem value);
        int IndexOf(IToolStripItem value);
        int IndexOfKey(string key);
        void Remove(IToolStripItem value);
        void RemoveByKey(string key);
        void CopyTo(IToolStripItem[] array, int index);
        bool Equals(object obj);
        int GetHashCode();
        void Clear();
        void RemoveAt(int index);
        void CopyTo(Array array, int index);
        IEnumerator GetEnumerator();
    }
}