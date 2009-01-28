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
using System.Collections.Generic;
using System.Drawing;


namespace NoeticTools.DotNetWrappers
{
    public class ToolStripItemCollection : IToolStripItemCollection
    {
        private readonly System.Windows.Forms.ToolStripItemCollection collection;

        public ToolStripItemCollection(System.Windows.Forms.ToolStripItemCollection collection)
        {
            this.collection = collection;
        }

        public IToolStripItem this[int index]
        {
            get { return ToWrappedItemConverter(collection[index]); }
        }

        public IToolStripItem this[string name]
        {
            get { return ToWrappedItemConverter(collection[name]); }
        }

        public bool IsReadOnly
        {
            get { return collection.IsReadOnly; }
        }

        public int Count
        {
            get { return collection.Count; }
        }

        public System.Windows.Forms.ToolStripItem Add(string text)
        {
            return collection.Add(text);
        }

        public System.Windows.Forms.ToolStripItem Add(Image image)
        {
            return collection.Add(image);
        }

        public System.Windows.Forms.ToolStripItem Add(string text, Image image)
        {
            return collection.Add(text, image);
        }

        public System.Windows.Forms.ToolStripItem Add(string text, Image image, EventHandler onClick)
        {
            return collection.Add(text, image, onClick);
        }

        public int Add(IToolStripItem value)
        {
            return collection.Add(ToUnwrappedItemConveter(value));
        }

        public void AddRange(IToolStripItem[] toolStripItems)
        {
            List<IToolStripItem> sourceItems = new List<IToolStripItem>(toolStripItems);

            List<System.Windows.Forms.ToolStripItem> items =
                sourceItems.ConvertAll<System.Windows.Forms.ToolStripItem>(ToUnwrappedItemConveter);

            collection.AddRange(items.ToArray());
        }

        public void AddRange(IToolStripItemCollection toolStripItems)
        {
            collection.AddRange((System.Windows.Forms.ToolStripItemCollection) toolStripItems);
        }

        public bool Contains(IToolStripItem value)
        {
            return collection.Contains(ToUnwrappedItemConveter(value));
        }

        public bool ContainsKey(string key)
        {
            return collection.ContainsKey(key);
        }

        public IToolStripItem[] Find(string key, bool searchAllChildren)
        {
            List<System.Windows.Forms.ToolStripItem> foundItems =
                new List<System.Windows.Forms.ToolStripItem>(collection.Find(key, searchAllChildren));
            return foundItems.ConvertAll<IToolStripItem>(ToWrappedItemConverter).ToArray();
        }

        public void Insert(int index, IToolStripItem value)
        {
            collection.Insert(index, ToUnwrappedItemConveter(value));
        }

        public int IndexOf(IToolStripItem value)
        {
            return collection.IndexOf(ToUnwrappedItemConveter(value));
        }

        public int IndexOfKey(string key)
        {
            return collection.IndexOfKey(key);
        }

        public void Remove(IToolStripItem value)
        {
            collection.Remove(ToUnwrappedItemConveter(value));
        }

        public void RemoveByKey(string key)
        {
            collection.RemoveByKey(key);
        }

        public void CopyTo(IToolStripItem[] array, int index)
        {
            collection.CopyTo(array, index);
        }

        public new bool Equals(object obj)
        {
            return collection.Equals(obj);
        }

        public new int GetHashCode()
        {
            return collection.GetHashCode();
        }

        public void Clear()
        {
            collection.Clear();
        }

        public void RemoveAt(int index)
        {
            collection.RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
            collection.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return collection.GetEnumerator();
        }

        private static System.Windows.Forms.ToolStripItem ToUnwrappedItemConveter(IToolStripItem sourceItem)
        {
            return (ToolStripItem) sourceItem;
        }

        private static IToolStripItem ToWrappedItemConverter(System.Windows.Forms.ToolStripItem sourceItem)
        {
            IToolStripItem wrappedItem;

            if (sourceItem.GetType() == typeof (System.Windows.Forms.ToolStripMenuItem))
            {
                wrappedItem = new ToolStripMenuItem((System.Windows.Forms.ToolStripMenuItem) sourceItem);
            }
            else
            {
                wrappedItem = new ToolStripItem(sourceItem);
            }

            return wrappedItem;
        }
    }
}