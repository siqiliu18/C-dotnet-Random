namespace ReverseInt.Tests;

// https://stackoverflow.com/a/14728506/9954367
using ReverseIntNs;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var reverseIntObj = new ReverseInt();
        var res = reverseIntObj.Reverse(123);
        Assert.Equal(321, res);
    }

    [Fact]
    public void Test2()
    {
        var reverseIntObj = new ReverseInt();
        var res = reverseIntObj.Reverse(-123);
        Assert.Equal(-321, res);
    }

    [Fact]
    public void Test3()
    {
        var reverseIntObj = new ReverseInt();
        var res = reverseIntObj.Reverse(120);
        Assert.Equal(21, res);
    }

    [Fact]
    public void Test4()
    {
        var reverseIntObj = new ReverseInt();
        var res = reverseIntObj.Reverse(1534236469);
        Assert.Equal(0, res);
    }
}