using Xunit;

namespace Program.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // var topKFreqElem = new TopKFreqElem();
        var input1 = new int[] { 1, 1, 1, 2, 2, 3 };
        var res = TopKFreqElem.TopKFrequent(input1, 2);
        Assert.Equal(res, new int[] { 1, 2 });
    }
}