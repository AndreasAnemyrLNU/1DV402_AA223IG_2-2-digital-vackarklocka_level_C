using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2C
{
    class Program
    {
        static void Main(string[] args)
        {


           NumberDisplay testNumberDisplayObj = new NumberDisplay(20,6);

           Console.WriteLine(testNumberDisplayObj.ToString("G"));
           testNumberDisplayObj.Increment();
           Console.WriteLine(testNumberDisplayObj);
           testNumberDisplayObj.Increment();
           Console.WriteLine(testNumberDisplayObj);
           testNumberDisplayObj.Increment();
           Console.WriteLine(testNumberDisplayObj);
           testNumberDisplayObj.Increment();
           Console.WriteLine(testNumberDisplayObj);
           testNumberDisplayObj.Increment();
           Console.WriteLine(testNumberDisplayObj);
           testNumberDisplayObj.Increment();
           Console.WriteLine(testNumberDisplayObj);
           testNumberDisplayObj.Increment();
           Console.WriteLine(testNumberDisplayObj);
           testNumberDisplayObj.Increment();
           Console.WriteLine(testNumberDisplayObj.ToString("00"));

           Console.ReadKey();

        }
    }
}
