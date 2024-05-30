
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

        public int[][] FlipForwardDiagonal2(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            // If we go by this way, we only init the rows in table.
            int[][] table = new int[rows][];
            // Then we need to init the array in each row. int[,] = new int[rowNum, colNum] init at the beginning.
            for (int row = 0; row < rows; row++)
            {
                table[row] = new int[cols];
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    table[col][row] = matrix[row][col];
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

        // https://stackoverflow.com/a/33742025/9954367
        public void SortArrArr()
        {
            int[][] x = new int[4][];
            x[0] = new int[] { 5, 2, 5 };
            x[1] = new int[] { 6, 8, 3 };
            x[2] = new int[] { 8, 9, 6 };
            x[3] = new int[] { 8, 3, 6 };
            var sorted = x.OrderBy(y => y[0]).ThenBy(y => y[1]);
            foreach (var arr in sorted)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
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
            obj.SortArrArr();
            Console.WriteLine("============");
            int[,] testArr = new int[2, 2]; // init cells to 0
            int rows = testArr.GetLength(0);
            int cols = testArr.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(testArr[row, col] + " ");
                }
                Console.WriteLine();
            }
            int[][] copyArr = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                copyArr[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    copyArr[row][col] = testArr[row, col] + 1;
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(copyArr[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}