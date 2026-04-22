using Smetik.ArrayTools;

namespace Smetik.ArrayTools.ConsumerTests;

public class ArrayToolsTests
{
    [Fact]
    public void SortAscending_ReturnsSortedArray()
    {
        int[] input = { 5, 2, 9, 1 };
        int[] result = ArrayTools.SortAscending(input);

        Assert.Equal(new[] { 1, 2, 5, 9 }, result);
    }

    [Fact]
    public void SortAscending_WithEmptyArray_ReturnsEmptyArray()
    {
        int[] result = ArrayTools.SortAscending(Array.Empty<int>());

        Assert.Empty(result);
    }

    [Fact]
    public void SortAscending_WithNull_ReturnsEmptyArray()
    {
        int[] result = ArrayTools.SortAscending(null);

        Assert.Empty(result);
    }

    [Fact]
    public void FilterGreaterThan_ReturnsOnlyNeededElements()
    {
        int[] input = { 1, 5, 8, 2, 10 };
        int[] result = ArrayTools.FilterGreaterThan(input, 4);

        Assert.Equal(new[] { 5, 8, 10 }, result);
    }

    [Fact]
    public void FilterGreaterThan_WithEmptyArray_ReturnsEmptyArray()
    {
        int[] result = ArrayTools.FilterGreaterThan(Array.Empty<int>(), 4);

        Assert.Empty(result);
    }

    [Fact]
    public void FilterGreaterThan_WithNull_ReturnsEmptyArray()
    {
        int[] result = ArrayTools.FilterGreaterThan(null, 4);

        Assert.Empty(result);
    }

    [Fact]
    public void IndexOf_ReturnsCorrectIndex()
    {
        int[] input = { 10, 20, 30, 40 };
        int result = ArrayTools.IndexOf(input, 30);

        Assert.Equal(2, result);
    }

    [Fact]
    public void IndexOf_WhenElementNotFound_ReturnsMinusOne()
    {
        int[] input = { 10, 20, 30, 40 };
        int result = ArrayTools.IndexOf(input, 99);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void IndexOf_WithNull_ReturnsMinusOne()
    {
        int result = ArrayTools.IndexOf(null, 10);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void GetElementAt_ReturnsElementByIndex()
    {
        int[] input = { 7, 8, 9 };
        int result = ArrayTools.GetElementAt(input, 1);

        Assert.Equal(8, result);
    }

    [Fact]
    public void GetElementAt_WithNull_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => ArrayTools.GetElementAt(null, 0));
    }

    [Fact]
    public void GetElementAt_WithInvalidIndex_ThrowsArgumentOutOfRangeException()
    {
        int[] input = { 7, 8, 9 };

        Assert.Throws<ArgumentOutOfRangeException>(() => ArrayTools.GetElementAt(input, 5));
    }
}