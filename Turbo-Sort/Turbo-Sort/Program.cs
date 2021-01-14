//Given the list of numbers, you are to sort them in non decreasing order.
//Input
//t – the number of numbers in list, then t lines follow[t <= 10 ^ 6].
//Each line contains one integer: N[0 <= N <= 10 ^ 6]

//Output
//Output given numbers in non decreasing order.
//Example
//Input:

//5
//5
//3
//6
//7
//1
//Output:

//1
//3
//5
//6
//7
using System;
using System.Collections.Generic;

namespace Turbo_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for(; a>0;a--)
            {
                string str = Console.ReadLine();
                list.Add(Convert.ToInt32(str));
            }
            var arr = list.ToArray();
            Console.WriteLine("Sorted List");
            Array.Sort(arr);
            foreach(int res in arr)
            {
                Console.WriteLine(res);
            }
        }
    }
}
