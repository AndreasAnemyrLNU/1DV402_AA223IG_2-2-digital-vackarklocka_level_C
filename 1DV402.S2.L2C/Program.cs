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

            //Test1(); //Fail

            //Test2(); //Fail

            Test3();

            Test4();

            


        Console.ReadKey();

        }

        private static void Run(AlarmClock ac)
        {
            Console.WriteLine(ac.ToString());         
        }

        private static void Test1(){
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine("Test 1.");
            Console.WriteLine("Test av standardkonstruktorn");
            Console.WriteLine();
            Run(new AlarmClock()); 
       }

        private static void Test2()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine("Test 2.");
            Console.WriteLine("Test av konstruktorn med två parametrar (9, 42)");
            Console.WriteLine();
            Run(new AlarmClock(9,42));
        }

        private static void Test3()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine("Test 3.");
            Console.WriteLine("Test av konstruktorn med fyra parametrar av typen int (13, 24, 7, 35)");
            Console.WriteLine();
            Run(new AlarmClock(13, 24, 7, 35));
        }

        private static void Test4()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine("Test 4.");
            Console.WriteLine("Test av konstruktorn med minst två parametrar av typen string, (\"7:07\")");
            Console.WriteLine();
            Run(new AlarmClock("7:07","7:10","7:15","7:30"));
        }


        private static void HorizontalLine() 
        {
            Console.WriteLine("-----------------------------------------------------------------------");
        }


    }
}
