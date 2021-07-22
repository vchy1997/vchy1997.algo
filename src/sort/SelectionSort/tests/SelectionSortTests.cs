using System;
using Xunit;

namespace ALGO.SelectionSort.Tests
{
    public class SelectionSortTests
    {
        private readonly SelectionSort _selectionSort;
        public SelectionSortTests()
        {
            _selectionSort = new SelectionSort();
        }

        [Theory]
        [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 7, 4, 5, 63 }, new int[] { 4, 5, 7, 63 })]

        public void Run_Sort_1_Success(int[] param, int[] expected)
        {
            //arrange

            //act

            var actual = _selectionSort.Sort_1(param);

            //assert

            Assert.Equal(expected, actual);
        }
    }
}
