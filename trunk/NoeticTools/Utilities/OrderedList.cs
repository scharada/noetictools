#region Copyright

/*---------------------------------------------------------------------------
 * The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 * 
 * http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
 * License for the specific language governing rights and limitations under 
 * the License.
 * 
 * The Initial Developer of the Original Code is Robert Smyth.
 * Portions created by Robert Smyth are Copyright (C) 2008.
 * 
 * All Rights Reserved.
 *---------------------------------------------------------------------------*/

#endregion

using System;
using System.Collections;
using System.Collections.Generic;


namespace NoeticTools.Utilities
{
	public class OrderedList<T> : IList<T>
		where T : IComparable<T>
	{
		private readonly List<T> list = new List<T>();

		public void Add(T newValue)
		{
			int insertIndex;
			for (insertIndex = 0; insertIndex < list.Count; insertIndex++)
			{
				if (newValue.CompareTo(list[insertIndex]) < 0)
				{
					break;
				}
			}
			list.Insert(insertIndex, newValue);
		}

		public void Clear()
		{
			list.Clear();
		}

		public bool Contains(T item)
		{
			return list.Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			list.CopyTo(array, arrayIndex);
		}

		public bool Remove(T item)
		{
			return list.Remove(item);
		}

		public int Count
		{
			get { return list.Count; }
		}

		public bool IsReadOnly
		{
			get { return false; }
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return list.GetEnumerator();
		}

		public IEnumerator GetEnumerator()
		{
			return ((IEnumerable<T>) this).GetEnumerator();
		}

		public int IndexOf(T item)
		{
			return list.IndexOf(item);
		}

		public void Insert(int index, T item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public T this[int index]
		{
			get { return list[index]; }
			set { list[index] = value; }
		}
	}
}