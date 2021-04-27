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
            int lenghtSource = 0;
            while (tmp != 0)
            {
                tmp = tmp >> 1;
                lenghtSource++;
            }
            if (j <= i || (j - i)+1 < lenghtSource)
                return 0;
            int lenghtDest = 0;
            tmp = dest;
            while (tmp != 0)
            {
                tmp = tmp >> 1;
                lenghtDest++;
            }
            if (lenghtDest < lenghtSource)
                return 0;
            int reset = 1;
            int mask = int.MinValue;
            reset <<= i;           
            int counter = (j - i);
            while (counter != 0)
            {
                reset = reset | mask;
                reset = ~reset;
                dest &= reset;
                reset <<= 1;
                counter--;
            }
            source <<= i;
            res = dest | source;
            return res;
        }
    }
}
