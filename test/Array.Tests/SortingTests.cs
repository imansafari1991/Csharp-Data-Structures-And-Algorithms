using Arrays.Implementations;
using FluentAssertions;
using Xunit.Abstractions;

namespace Array.Tests;

public class SortingTests
{
    private ITestOutputHelper _outputHelper;

    public SortingTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }
    private int[][] Samples()
    {
        int[][] samples = new int[9][];
        samples[0] = new[] { 1 };
        samples[1] = new[] { 2, 1 };
        samples[2] = new[] { 2, 1, 3 };
        samples[3] = new[] { 1, 1, 1 };
        samples[4] = new[] { 2, -1, 3, 3 };
        samples[5] = new[] { 4, -5, 3, 3 };
        samples[6] = new[] { 0, -5, 3, 3 };
        samples[7] = new[] { 0, -5, 3, 0 };
        samples[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8 };

        return samples;
    }
    [Fact]
    public void BubbleSort_ValidInput_SortedInput()
    {
        RunTestsForSortAlgorithm(Sorting.BubbleSort);
    }

    private void RunTestsForSortAlgorithm(Action<int[]> sort)
    {
        foreach (var sample in Samples())
        {
            sort(sample);
            sample.Should().BeInAscendingOrder();
            PrintOut(sample);
        }
    }
    [Fact]
    public void SelectionSort_ValidInput_SortedOutput()
    {
        RunTestsForSortAlgorithm(Sorting.SelectionSort);
    }
    [Fact]
    public void InsertionSort_ValidInput_SortedOutput()
    {
        RunTestsForSortAlgorithm(Sorting.InsertionSort);
    }
    private void PrintOut(int[] array)
    {
        _outputHelper.WriteLine("-----TRACE-----\n");
        _outputHelper.WriteLine(string.Join(",",array));
        _outputHelper.WriteLine("\n----------------------\n");
    }

}