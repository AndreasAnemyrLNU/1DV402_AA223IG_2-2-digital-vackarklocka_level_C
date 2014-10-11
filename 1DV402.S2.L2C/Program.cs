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
         //
            TestPackage();

            Console.ReadKey();

        }

        private static void Run(AlarmClock ac, int minutes = 0)
        {
            if (0 == minutes)
            {
                Console.WriteLine(ac.ToString());
            }
            else
            {
                for (int i = 0; i < minutes; i++)
                {
                    ac.TickTock();
                    Console.WriteLine(ac.ToString());
                }
            }
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
            Console.WriteLine("Test av konstruktorn med minst två parametrar av typen string, (\"7:07\",\"7:10\",\"7:15\",\"7:30\")");
            Console.WriteLine();
            Run(new AlarmClock("7:07","7:10","7:15","7:30"));
        }
        private static void Test5()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine("Test 5.");
            Console.WriteLine("Ställer befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
            Console.WriteLine();
            Run(new AlarmClock("23:58","7:10","7:15","7:30"),13);
        }

        private static void Test6()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine("Test 6.");
            Console.WriteLine("Ställer befintligt AlarmClock-objekt till 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter.");
            Console.WriteLine();
            Run(new AlarmClock("6:12", "6:15"), 6);
        }

        private static void Test7()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine("Test 7.");
            Console.WriteLine("Testar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            Console.WriteLine();
            Run(new AlarmClock("24:89","7:69"));
        }
        private static void Test8()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine("Test 8.");
            Console.WriteLine("Testar konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            Console.WriteLine();
            Run(new AlarmClock(32,03,27,00));
        }

        private static void TestPackage()
        {
            try
            {
                Test1();
            }
            catch
            {
                Console.WriteLine("Nåt gick fel med test 1");
            }
            try
            {
                Test2();
            }
            catch
            {
                Console.WriteLine("Nåt gick fel med test 2");
            }
            try
            {
                Test3();
            }
            catch
            {
                Console.WriteLine("Nåt gick fel med test 3");
            }
            try
            {
                Test4();
            }
            catch
            {
                Console.WriteLine("Nåt gick fel med test 4");
            }
            try
            {
                Test5();
            }
            catch
            {
                Console.WriteLine("Nåt gick fel med test 5");
            }
            try
            {
                Test6();
            }
            catch
            {
                Console.WriteLine("Nåt gick fel med test 6");
            }
            try
            {
                Test7();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Test8();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void HorizontalLine() 
        {
            Console.WriteLine("-----------------------------------------------------------------------");
        }


    }
}
