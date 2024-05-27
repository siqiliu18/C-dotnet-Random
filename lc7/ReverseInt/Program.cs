namespace ReverseIntNs
{
    public class ReverseInt
    {
        public int Reverse(int x)
        {
            long res = 0;
            while (x != 0)
            {
                res = res * 10 + x % 10;
                x /= 10;
            }
            if (res > Int32.MaxValue || res < Int32.MinValue)
            {
                return 0;
            }
            return Convert.ToInt32(res);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}