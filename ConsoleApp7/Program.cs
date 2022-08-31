using System;

namespace ConsoleApp7
{
    internal class program
    {
        static void Main(string[] args)
        {
            int[] apcfans = { 23, 17, 21, 31, 27, 18 };

            int total = 0;
            foreach (var youthAge in apcfans)
            {
                total = total + youthAge;
               
            }
            Console.WriteLine($"the sum of apsfans is {total}");
            int sum = total;
            Console.ReadLine();
        }
       
    }
}
