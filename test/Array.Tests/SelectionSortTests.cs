using Arrays.Contracts;
using Arrays.Implementations;
using Bogus;
using FluentAssertions;

namespace Array.Tests
{
    public class SelectionSortTests
    {


        [Fact]
        public void AscendingSort_method_should_return_array_in_correct_order()
        {
            var faker = new Faker();
            IArraySorter<int> sorter = new SelectionSort<int>();
            //arrange 
            var unsortedArray = Enumerable.Range(1, 10).Select(_ => faker.Random.Int()).ToArray();
            //act
            var sortedArray = sorter.AscendingSort(unsortedArray);
            //assert
            sortedArray.Should().BeInAscendingOrder();

        }
        [Fact]
        public void DescendingSort_method_should_return_array_in_correct_order()
        {
            IArraySorter<int> sorter = new SelectionSort<int>();
            //arrange 
            var unsortedArray = new[] { -3, 4, -5, 10, -50, 20 };
            //act
            var sortedArray = sorter.DescendingSort(unsortedArray);
            //assert
            sortedArray.Should().BeInAscendingOrder();

        }
    }
}