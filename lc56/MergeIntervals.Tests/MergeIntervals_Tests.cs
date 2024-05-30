namespace MergeIntervals.Tests;
using MergeIntervalsNS;

public class MergeIntervalsTest1
{
    [Fact]
    public void Test0()
    {
        var obj = new Solution();
        var inArr = new int[1][]
        {
            new int[] {1,3},
        };
        var res = obj.Merge(inArr);
        var expected = new int[1][]
        {
            new int[] {1, 3},
        };
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Test1()
    {
        var obj = new Solution();
        var inArr = new int[4][]
        {
            new int[] {1,3},
            new int[] {2,6},
            new int[] {8,10},
            new int[] {15,18}
        };
        var res = obj.Merge(inArr);
        var expected = new int[3][]
        {
            new int[] {1, 6},
            new int[] {8, 10},
            new int[] {15, 18},
        };
        Assert.Equal(expected, res);
    }


    [Fact]
    public void Test2()
    {
        var obj = new Solution();
        var inArr = new int[2][]
        {
            new int[] {1,4},
            new int[] {2,3},
        };
        var res = obj.Merge(inArr);
        var expected = new int[1][]
        {
            new int[] {1, 4},
        };
        Assert.Equal(expected, res);
    }
}