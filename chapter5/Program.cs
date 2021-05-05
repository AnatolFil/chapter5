using System;

namespace chapter5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string a = "123";
            string b = 123.ToString();
            Console.WriteLine(a==b);//true
            Console.WriteLine(a.Equals(b));//true

            object c = "123";
            object d = 123.ToString();

            Console.WriteLine(c == d);//true
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(c.Equals(d));//true

            object e = "123";
            object f = "123";

            Console.WriteLine(e == f);//true
            Console.WriteLine(e.Equals(f));//true
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
        public string convertIntoBin(double numb)
        {
            string res = "";
            while(numb != 0 && res.Length <= 32)
            {
                numb = numb * 2;
                if (numb > 1)
                {
                    res += "1";
                    numb = numb - 1;
                }  
                else
                    res += "0";
            }
            //numb << 52; 
            return res;
        }
    }
}
