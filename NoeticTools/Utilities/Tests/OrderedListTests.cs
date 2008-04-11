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

using NUnit.Extensions;
using NUnit.Framework;
using System;


namespace NoeticTools.Utilities.Tests
{
	[TestFixture]
	public class OrderedListTests : MockingTestFixture
	{
		private OrderedList<TestItem> list;

		protected override void SetUp()
		{
			list = new OrderedList<TestItem>();
		}

		[Test]
		public void Count_IsZero_Initially()
		{
			Assert.AreEqual(0, list.Count);
		}

		[Test]
		public void Add_AddsItemToList()
		{
			TestItem item = new TestItem(7);
			list.Add(item);

			Assert.AreEqual(1, list.Count);
			Assert.AreSame(item, list[0]);
		}

		[Test]
		public void Add_AddsItemsToListWithDifferentSortValues()
		{
			TestItem item11 = new TestItem(11);
			TestItem item7 = new TestItem(7);
			TestItem item13 = new TestItem(13);

			list.Add(item11);
			list.Add(item7);
			list.Add(item13);

			Assert.AreEqual(3, list.Count);
			Assert.AreSame(item7, list[0]);
			Assert.AreSame(item11, list[1]);
			Assert.AreSame(item13, list[2]);
		}

		[Test]
		public void Add_AppendsItemsOfEqualSortValueAfterItemWithTheSameValue()
		{
			TestItem item2 = new TestItem(2);
			TestItem item7a = new TestItem(7);
			TestItem item7b = new TestItem(7);
			TestItem item7c = new TestItem(7);
			TestItem item13 = new TestItem(13);

			list.Add(item7a);
			list.Add(item7b);
			list.Add(item13);
			list.Add(item7c);
			list.Add(item2);

			Assert.AreEqual(5, list.Count);
			Assert.AreSame(item2, list[0]);
			Assert.AreSame(item7a, list[1]);
			Assert.AreSame(item7b, list[2]);
			Assert.AreSame(item7c, list[3]);
			Assert.AreSame(item13, list[4]);
		}

		[Test]
		public void Clear_FlushesTheList()
		{
			TestItem item2 = new TestItem(2);
			TestItem item7 = new TestItem(7);
			list.Add(item7);
			list.Add(item2);
			Assert.AreEqual(2, list.Count);

			list.Clear();

			Assert.AreEqual(0, list.Count);
		}
	}

	public class TestItem : IComparable<TestItem>
	{
		private readonly int value;

		public TestItem(int value)
		{
			this.value = value;
		}

		public int Value
		{
			get { return value; }
		}

		public int CompareTo(TestItem other)
		{
			return value - other.value;
		}
	}
}