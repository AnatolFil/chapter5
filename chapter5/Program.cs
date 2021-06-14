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
            return res;
        }
        public int countBits(int numb)
        {
            int res = 0;
            int mask = 1;
            int maxBitSeq = 0;
            for(int j=0;j<32;j++)
            {
                int tmp = numb;
                tmp |= mask;
                int funcRes = countMaxBits(tmp);
                if (funcRes > maxBitSeq)
                    maxBitSeq = funcRes;
                mask = mask << 1;
            }
            res = maxBitSeq;
            return res;
        }
        private int countMaxBits(int numb)
        {
            int res = 0;
            int maxBitSeq = 0;
            int shifter2 = 1;
            int bitSeq = 0;
            for (int i = 0; i < 32; i++)
            {
                int tmp2 = numb & shifter2;
                if (tmp2 != 0)
                {
                    bitSeq++;
                }
                else
                {
                    if (bitSeq > maxBitSeq)
                        maxBitSeq = bitSeq;
                    bitSeq = 0;
                }
                if (bitSeq > maxBitSeq)
                    maxBitSeq = bitSeq;
                shifter2 = shifter2 << 1;
            }
            res = maxBitSeq;
            return res;
        }
        public int countBitsOpimised(int numb)
        {
            if (numb == 0)
                return 1;
            if (~numb == 0)
                return 32;
            int res = 1;
            int curBits = 0;
            int prevBits = 0;
            
            while(numb != 0)
            {
                if((numb & 1) == 1)
                {
                    curBits++;
                }
                else
                {
                    prevBits = (numb & 2) == 0 ? 0 : curBits;
                    curBits = 0;
                }
                numb >>= 1;
                res = Math.Max(curBits + prevBits + 1, res);
            }
            return res;
        }
        public void findMaxAndMin(int numb, ref int max, ref int min)
        {
            if (numb < 0)
                return;
            if (numb == 0 || numb == int.MaxValue || numb == 1)
            {
                max = min = numb;
                return;
            }
            min = -1;
            max = -1;
            if (numb == 1073741824)
                max = numb;
            int maskForZero = 1;
            int zeroPos = -1;
            int maskFor1 = 0;
            int pos1 = -1;
            int tmp = numb;
            int i = 0;
            while (tmp != 0)
            {
                if (max != -1 && min != -1)
                    return;
                if((tmp & 1) == 0)
                {
                    zeroPos = i;
                    if(i != 0 && pos1 != -1 && max == -1)
                    {
                        int maskZeroMax = 1;
                        maskZeroMax <<= i;
                        int mask1Max = 1;
                        mask1Max <<= pos1;
                        max = numb | maskZeroMax;
                        mask1Max = ~mask1Max;
                        mask1Max &= 2147483647;
                        max = max & mask1Max;
                    }
                }
                else
                {
                    if(zeroPos != -1 && min == -1)
                    {
                        maskFor1 = 1;
                        maskFor1 <<= i;
                        maskForZero = 1;
                        maskForZero <<= zeroPos;
                        maskFor1 = ~maskFor1;
                        maskFor1 &= 2147483647;
                        min = numb | maskForZero;
                        min = min & maskFor1;
                    }
                    pos1 = i;
                }
                i++;
                tmp >>= 1;
            }            
        }
        public int chageBitsPlacement(int numb)
        {
            int res = 0;
            int fastPointer = 1 << 1;
            int slowPointer = 1;
            while(fastPointer != 0)
            {
                int tmp = (numb & slowPointer);
                tmp <<= 1;
                res = res | tmp;
                tmp = (numb & fastPointer);
                tmp >>= 1;
                res = res | tmp;
                fastPointer <<= 2;
                slowPointer <<= 2;
            }
            return res;
        }
        public int chageBitsPlacementEasy(int numb)
        {
            return ((numb & 0xAAAAAAA) >> 1) | ((numb & 0x55555555) << 1);
        }
    }
}
