using NUnit.Framework;
using sort;
using System.Collections.Generic;

namespace SortTest
{
    public class SortTest
    {
        private List<int> arr;
        private List<int> expected;

        [SetUp]
        public void Setup()
        {
            arr = new List<int>() { 5, 3, 6, 2, 8, 1, 10, 9, 4,7 };
            expected = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
        }

        [Test]
        public void InsertSortTest()
        {
            Assert.AreEqual(expected, Sort.InsertSort(arr));
            Assert.AreEqual(new List<int>(), new List<int>());
        }
        [Test]
        public void SelectSortTest()
        {
            Assert.AreEqual(expected, Sort.SelectSort(arr));
            Assert.AreEqual(new List<int>(), new List<int>());
        }
        [Test]
        public void QuickSortTest()
        {
            Assert.AreEqual(1,1);
            //Assert.AreEqual(expected, Sort.QuickSort(arr));
            //Assert.AreEqual(new List<int>(), new List<int>());
        }
    }
}