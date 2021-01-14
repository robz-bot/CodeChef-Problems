using System;

namespace Small_Factorials
{
    class Program
    {
        public static int calcFact(int a)
        {
            int temp = 1;
            for(int i=a;i>=1;i--)
            {
                temp *= a;
                a--;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            //To get No.of Test cases
            int getTestCases = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[getTestCases];
            for(int i=0;i<getTestCases;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int a in arr)
            {
                int fact = calcFact(a);
                Console.WriteLine(fact);
            }
        }
    }
}
