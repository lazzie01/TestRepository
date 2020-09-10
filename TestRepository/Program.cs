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
            double h = 2.18;
            double d = 1.74;
            double pi = Math.PI;

            double v = Volume(h,d,pi);

            Console.WriteLine("Volume is: "+ v);
            Console.ReadLine();
        }

        static double Volume(double h, double d, double pi)
        {
            return pi * (d / 2) * (d / 2) * h;
        }
    }
}
