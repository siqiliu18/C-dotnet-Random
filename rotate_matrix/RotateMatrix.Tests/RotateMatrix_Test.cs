namespace RotateMatrix.Tests;
using MainNS;

public class JumpGameTest
{
    [Fact]
    public void Test1()
    {
        var obj = new RotateMatrix();
        var res = obj.CanJump(new int[] { 2, 3, 1, 1, 4 });
        Assert.True(res);
    }

    [Fact]
    public void Test2()
    {
        var obj = new RotateMatrix();
        var res = obj.CanJump(new int[] { 0 });
        Assert.True(res);
    }

    [Fact]
    public void Test3()
    {
        var obj = new RotateMatrix();
        var res = obj.CanJump(new int[] { 1 });
        Assert.True(res);
    }

    [Fact]
    public void Test4()
    {
        var obj = new RotateMatrix();
        var res = obj.CanJump(new int[] { 0, 2, 3 });
        Assert.False(res);
    }
}

public class RotateMatrixTest
{
    [Fact]
    public void RotateRightTest1()
    {
        var obj = new RotateMatrix();
        int[,] matrix = new int[4, 3] {
            {1,2,3},
            {4,5,6},
            {7,8,9},
            {10,11,12}
        };
        var res = obj.RotateRight(matrix);
        var expected = new int[3, 4] {
            {10, 7, 4, 1},
            {11, 8, 5, 2},
            {12, 9, 6, 3},
        };
        Assert.Equal(expected, res);
    }

    [Fact]
    public void RotateLeftTest1()
    {
        var obj = new RotateMatrix();
        int[,] matrix = new int[4, 3] {
            {1,2,3},
            {4,5,6},
            {7,8,9},
            {10,11,12}
        };
        var res = obj.RotateLeft(matrix);
        var expected = new int[3, 4] {
            {3, 6, 9, 12},
            {2, 5, 8, 11},
            {1, 4, 7, 10},
        };
        Assert.Equal(expected, res);
    }

    [Fact]
    public void FlipDiagonal1()
    {
        var obj = new RotateMatrix();
        int[,] matrix = new int[3, 3] {
            {1,2,3},
            {4,5,6},
            {7,8,9},
        };
        var res = obj.FlipForwardDiagonal(matrix);
        var expected = new int[3, 3] {
            {1,4,7},
            {2,5,8},
            {3,6,9},
        };
        Assert.Equal(expected, res);
    }

    [Fact]
    public void FlipDiagonal2()
    {
        var obj = new RotateMatrix();
        int[,] matrix = new int[3, 3] {
            {1,2,3},
            {4,5,6},
            {7,8,9},
        };
        var res = obj.FlipBackwardDiagonal(matrix);
        var expected = new int[3, 3] {
            {9,6,3},
            {8,5,2},
            {7,4,1},
        };
        Assert.Equal(expected, res);
    }
}