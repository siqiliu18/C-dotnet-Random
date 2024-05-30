
namespace MainNS
{
    public class RotateMatrix
    {
        // leetcode #55
        public bool CanJump(int[] nums)
        {
            int[] dp = new int[nums.Length];
            Array.Fill(dp, int.MaxValue);
            dp[0] = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) break;
                for (int j = i + 1; j <= i + nums[i] && j < nums.Length; j++)
                {
                    int curr = nums[i] + 1;
                    dp[j] = Math.Min(curr, dp[j]);
                }
            }
            return dp[nums.Length - 1] != int.MaxValue;
        }

        public int[,] RotateRight(int[,] matrix)
        {
            // https://stackoverflow.com/questions/9404683/how-to-get-the-length-of-row-column-of-multidimensional-array-in-c
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] table = new int[cols, rows];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    table[col, rows - row - 1] = matrix[row, col];
                }
            }
            return table;
        }

        public int[,] RotateLeft(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] table = new int[cols, rows];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    table[cols - col - 1, row] = matrix[row, col];
                }
            }
            return table;
        }

        public int[,] FlipForwardDiagonal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] table = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    table[col, row] = matrix[row, col];
                }
            }
            return table;
        }

        public int[,] FlipBackwardDiagonal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] table = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    table[cols - col - 1, rows - row - 1] = matrix[row, col];
                }
            }
            return table;
        }

        // https://www.dotnetperls.com/sort-dictionary
        public void SortMapByKey()
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("car", 2);
            dictionary.Add("zebra", 0);
            dictionary.Add("apple", 1);

            // Step 2: get keys and sort them.
            var list = dictionary.Keys.ToList();
            list.Sort();

            // Step 3: loop through keys.
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, dictionary[key]);
            }
        }

        public void SortMapByVal(string scending = "ascending")
        {
            var dictionary = new Dictionary<string, int>(5);
            dictionary.Add("cat", 1);
            dictionary.Add("dog", 0);
            dictionary.Add("mouse", 5);
            dictionary.Add("eel", 3);
            dictionary.Add("programmer", 2);

            // Order by values.
            // ... Use LINQ to specify sorting by value.
            var items = scending == "ascending" ? from pair in dictionary
                                                  orderby pair.Value ascending
                                                  select pair :
                                                from pair in dictionary
                                                orderby pair.Value descending
                                                select pair;

            // Display results.
            foreach (KeyValuePair<string, int> pair in items)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("============");
            int[,] arr = new int[5, 2];
            var obj = new RotateMatrix();
            obj.SortMapByKey();
            Console.WriteLine("-------------");
            obj.SortMapByVal();
            Console.WriteLine("============");
        }
    }
}