using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Foxie");
            int x1 = 0;
            Console.ReadLine();
        }

        static double Volume(double h, double d, double pi)
        {
            return pi * (d / 2) * (d / 2) * h;
        }

        static double Area(double h, double d, double pi)
        {
            return pi * (d / 2) * (d / 2) * h;
        }
    }
}
