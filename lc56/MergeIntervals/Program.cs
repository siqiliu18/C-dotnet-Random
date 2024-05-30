namespace MergeIntervalsNS
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            // https://stackoverflow.com/questions/33741875/sort-2d-array-rows-in-ascending-order-of-their-first-elements-in-c-sharp
            // var sort = intervals.OrderBy(x => x[0]).ThenBy(x => x[1]);
            // var sortArr = sort.ToArray();
            // int lv = sortArr[0][0];
            // int rv = sortArr[0][1];

            // another methods to sort
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            // Array.Sort(intervals, (a,b) => a[0]-b[0]);
            int lv = intervals[0][0];
            int rv = intervals[0][1];

            List<int[]> ans = new List<int[]> { };

            for (int i = 1; i < intervals.Length; i++)
            {
                if (rv < intervals[i][0])
                {
                    var currArr = new int[] { lv, rv };
                    ans.Add(currArr);
                    lv = intervals[i][0];
                    rv = intervals[i][1];
                }
                else
                {
                    if (rv < intervals[i][1])
                        rv = intervals[i][1];
                }
            }
            ans.Add(new int[] { lv, rv });
            return ans.ToArray();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Leetcode #56 - merge intervals");
            var obj = new Solution();
            var inArr = new int[4][]
            {
                new int[] {1,3},
                new int[] {2,6},
                new int[] {8,10},
                new int[] {15,18}
            };
            var res = obj.Merge(inArr);
            Console.WriteLine(res);
        }
    }

}