//You're given an integer N. Write a program to calculate the sum of all the digits of N.

//Input
//The first line contains an integer T, the total number of testcases.Then follow T lines, each line contains an integer N.

//Output
//For each test case, calculate the sum of digits of N, and display it in a new line.

//Constraints
//1 ≤ T ≤ 1000
//1 ≤ N ≤ 1000000
//Example
//Input
//3 
//12345
//31203
//2123
//Output
//15
//9
//8
using System;
using System.Collections.Generic;

namespace Sum_of_Digits
{
    class Program
    {
        public static int[] numtoArray(int n)
        {
            if (n == 0) return new int[1] { 0 };

            var digits = new List<int>();

            for(;n!=0;n/=10)
            {
                digits.Add(n%10);
            }

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int res = 0;
            if (num >= 10)
            {
                int[] n = numtoArray(num);
                foreach (int a in n)
                {
                    res += a;
                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Enter Valid Number (10 to 1000)");
            }
            
        }
    }
}
