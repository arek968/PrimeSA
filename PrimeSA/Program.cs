using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSA
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i=1; i< 10; i++)
            {
                for (int j = 1; j < 10; j++)
                    Console.WriteLine(string.Format("i= {0}, j= {1}, ixj={2}", i , j, i*j));
            }
            Console.ReadLine();
            
        }
    }
}
