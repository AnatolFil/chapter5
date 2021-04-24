using System;

namespace chapter5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
    }
    public class bits
    {
        public int insertNumb(int source, int dest, int j, int i)
        {
            int res = 0;
            int tmp = source;
            int lenght = 0;
            while (tmp != 0)
            {
                tmp = tmp >> 1;
                lenght++;
            }
            if (j <= i || j - i < lenght)
                return 0;
            return res;

        }
    }
}
