public class TopKFreqElem
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict[nums[i]] = 1;
            }
        }
        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        List<int> res = new List<int>();
        int count = 1;
        foreach (var key in dict.Keys)
        {
            if (count <= k)
            {
                res.Add(key);
                count++;
            }
        }
        return res.ToArray();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Try programiz.pro");
        Console.WriteLine(TopKFrequent([1, 1, 1, 2, 2, 3], 2));
    }
}

/*
1. Have to add Xunit package at root csproj?
2. duplicated cs issue solution https://stackoverflow.com/a/63853501/9954367
*/