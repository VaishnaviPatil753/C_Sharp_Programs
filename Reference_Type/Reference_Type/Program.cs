using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reference_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int arg;
            arg = 5;
            squareRef(ref arg);
            Console.WriteLine(arg);
            Console.ReadKey();
        }
        static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;

        }
    }
}
