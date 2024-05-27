using System.Collections.Generic;

namespace MainNS
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            HashSet<string> ans = new HashSet<string>();
            _ = ans.Add("()");
            if (n == 1) return ans.ToList<string>();
            for (int i = 1; i < n; i++)
            {
                var curr = ans.ToArray<string>();
                ans.Clear();
                foreach (string str in curr)
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        string newStr = str.Insert(j + 1, "()");
                        ans.Add(newStr);
                    }
                }
            }
            return ans.ToList<string>();
        }

        public IList<string> GenPsQueue(int n)
        {
            if (n == 1) return new List<string> { "()" };
            Queue<string> queue = new Queue<string> { };
            HashSet<string> set = new HashSet<string> { "()" };
            queue.Enqueue("()");
            while (queue.Peek().Length < n * 2)
            {
                string curr = queue.Dequeue();
                for (int i = 0; i < curr.Length; i++)
                {
                    string newStr = curr.Insert(i + 1, "()");
                    if (!set.Contains(newStr))
                    {
                        queue.Enqueue(newStr);
                        set.Add(newStr);
                    }
                }
            }
            return queue.ToList<string>();
        }

        public IList<string> GenPsRecurr(int n)
        {
            HashSet<string> set = new HashSet<string> { };
            dfs(n, set, "()");
            return set.ToList<string>();
        }

        private void dfs(int n, HashSet<string> set, string str)
        {
            if (str.Length == n * 2)
            {
                set.Add(str);
                return;
            }

            for (int i = 0; i < str.Length; i++)
            {
                string newStr = str.Insert(i + 1, "()");
                dfs(n, set, newStr);
            }
        }

        public IList<string> GenerateParenthesisLCA1(int n)
        {
            var result = new List<string>();
            search(result, "", 0, 0, n);
            return result;
        }

        private void search(List<string> result, string current, int open, int close, int max)
        {
            //Base case - Max length is double the amount of parentheis 
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }

            if (open < max)
            {
                search(result, current + "(", open + 1, close, max);
            }
            if (close < open)
            {
                search(result, current + ")", open, close + 1, max);
            }
        }

        public IList<string> GenerateParenthesisLCA2(int n)
        {
            if (n == 1) return new List<string> { "()" };

            var list = new List<string>();

            Get("", 0, 0);

            void Get(string str, int left, int right)
            {
                if (left == n && right == n)
                {
                    list.Add(str);
                    return;
                }

                if (left < n)
                {
                    Get(str + '(', left + 1, right);
                }

                if (right < left)
                {
                    Get(str + ')', left, right + 1);
                }
            }

            return list;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Leetcode problem #22");
        }
    }
}