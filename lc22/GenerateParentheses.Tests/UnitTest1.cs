namespace GenerateParentheses.Tests;
using MainNS;

public class UnitTest1
{
    // https://stackoverflow.com/questions/3669970/compare-two-listt-objects-for-equality-ignoring-order
    public static bool ScrambledEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2)
    {
        var cnt = new Dictionary<T, int>();
        foreach (T s in list1)
        {
            if (cnt.ContainsKey(s))
            {
                cnt[s]++;
            }
            else
            {
                cnt.Add(s, 1);
            }
        }
        foreach (T s in list2)
        {
            if (cnt.ContainsKey(s))
            {
                cnt[s]--;
            }
            else
            {
                return false;
            }
        }
        return cnt.Values.All(c => c == 0);
    }

    [Fact]
    public void Test1()
    {
        Solution obj = new Solution();
        var ans = obj.GenerateParenthesis(1);
        Assert.Equal(ans, new List<string> { "()" });
    }

    [Fact]
    public void Test2()
    {
        Solution obj = new Solution();
        var ans = obj.GenerateParenthesis(2);
        Assert.Equal(ans, new List<string> { "(())", "()()" });
    }

    [Fact]
    public void Test3()
    {
        Solution obj = new Solution();
        var ans = obj.GenerateParenthesis(3);
        var res = ScrambledEquals(ans, new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" });
        Assert.True(res);
    }

    [Fact]
    public void Test4()
    {
        Solution obj = new Solution();
        var ans = obj.GenPsQueue(2);
        Assert.Equal(ans, new List<string> { "(())", "()()" });
    }

    [Fact]
    public void Test5()
    {
        Solution obj = new Solution();
        var ans = obj.GenPsQueue(3);
        var res = ScrambledEquals(ans, new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" });
        Assert.True(res);
    }

    [Fact]
    public void Test6()
    {
        Solution obj = new Solution();
        var ans = obj.GenPsRecurr(1);
        Assert.Equal(ans, new List<string> { "()" });
    }

    [Fact]
    public void Test7()
    {
        Solution obj = new Solution();
        var ans = obj.GenPsRecurr(2);
        Assert.Equal(ans, new List<string> { "(())", "()()" });
    }

    [Fact]
    public void Test8()
    {
        Solution obj = new Solution();
        var ans = obj.GenPsRecurr(3);
        var res = ScrambledEquals(ans, new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" });
        Assert.True(res);
    }
}