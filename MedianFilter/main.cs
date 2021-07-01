using System;
using ConsoleFilter.filter;

namespace ConsoleFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,3]{{1,2,3},{4,6,5},{7,8,9}};
            int r = 1;
            MatrixFilter Oleg = new MatrixFilter(a);
            var b =Oleg.Filter(r);
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}