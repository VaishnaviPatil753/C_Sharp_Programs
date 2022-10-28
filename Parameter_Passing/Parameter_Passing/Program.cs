using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parameter_Passing
{
    class Program
    {
        static void Main(string[] args)
        {
            int arg;
            arg = 4;
            squareval(arg);
            Console.WriteLine(arg);
            Console.ReadKey();
        }
        static void squareval(int valParameter)
        {
            valParameter *= valParameter;

        }
    }
}
