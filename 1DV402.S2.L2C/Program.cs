using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2C
{
    class Program
    {

        public static string ErrorMessage { get; set; }
        static void Main(string[] args)
        {    
            //Argumens tells wich of the tests to run. You can ignore by skip some arguments(nr:s)
            ViewDisplay();
            Console.WriteLine();
            Console.WriteLine();

            TestPackage(1,2,3,4,5,6,7,8);

            Console.ReadKey();
        }
        //Create an Alarmobject named ac. You can also give a number of
        //how many minutes time will fly. Of course 0 is accepted also...
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
                    //Console outputting is colored DarkMagent when time and alarmtime is equality
                    if (ac.TickTock())
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(string.Format("{0} BEEP! BEEP! BEEP!", ac.ToString()));
                        Console.ResetColor();
                    }
                    else
                    {
                        //Outpus when time has no alarm
                        Console.WriteLine(ac.ToString());
                    }
                }
            }


        }
        private static void Test1(){
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine(Properties.Resources.Test1.Replace("\\n", Environment.NewLine));
            Run(new AlarmClock()); 
       }
        private static void Test2()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine(Properties.Resources.Test2.Replace("\\n", Environment.NewLine));
            Run(new AlarmClock(9,42));
        }
        private static void Test3()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine(Properties.Resources.Test3.Replace("\\n", Environment.NewLine));
            Run(new AlarmClock(13, 24, 7, 35));
        }
        private static void Test4()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine(Properties.Resources.Test4.Replace("\\n", Environment.NewLine));
            Console.WriteLine();
            Run(new AlarmClock("7:07","7:10","7:15","7:30"));
        }
        private static void Test5()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine(Properties.Resources.Test5.Replace("\\n", Environment.NewLine));
            Run(new AlarmClock("23:58","7:10","7:15","7:30"),13);
        }
        private static void Test6()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine(Properties.Resources.Test6.Replace("\\n", Environment.NewLine));
            Run(new AlarmClock("6:12","6:13","6:15"), 6);
        }
        private static void Test7()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine(Properties.Resources.Test7.Replace("\\n", Environment.NewLine));
            Run(new AlarmClock("24:89","7:69"));
        }
        private static void Test8()
        {
            HorizontalLine();
            HorizontalLine();
            Console.WriteLine(Properties.Resources.Test8.Replace("\\n", Environment.NewLine));
            Run(new AlarmClock(32,03,27,00));
        }
        private static void TestPackage(params int[] runTest)
        {

            try 
            {
                if(runTest.Contains(1))
                {
                Test1();
                }
            }
            catch
            {
                Console.WriteLine(string.Format(Properties.Resources.ViewErrTest,"Första"));
            }
            try
            {
                if (runTest.Contains(2))
                {
                    Test2();
                }
            }
            catch
            {
                Console.WriteLine(string.Format(Properties.Resources.ViewErrTest, "Andra"));
            }
            try
            {
                if (runTest.Contains(3))
                {
                    Test3();
                }
            }
            catch
            {
                Console.WriteLine(string.Format(Properties.Resources.ViewErrTest, "Tredja"));
            }
            try
            {
                if (runTest.Contains(4))
                {
                    Test4();
                }
            }
            catch
            {
                Console.WriteLine(string.Format(Properties.Resources.ViewErrTest, "Fjärde"));
            }
            try
            {
                if (runTest.Contains(5))
                {
                    Test5();
                }
            }
            catch
            {
                Console.WriteLine(string.Format(Properties.Resources.ViewErrTest, "Femte"));
            }
            try
            {
                if (runTest.Contains(6))
                {
                    Test6();
                }
            }
            catch
            {
                Console.WriteLine(string.Format(Properties.Resources.ViewErrTest, "Sjätte"));
            }
            try
            {
                if (runTest.Contains(7))
                {
                    Test7();
                    ViewErrorMessage();
                }
            }
            catch
            {
                Console.WriteLine(string.Format(Properties.Resources.ViewErrTest, "Sjunde"));
            }
            try
            {
                if (runTest.Contains(8))
                {
                    Test8();
                    ViewErrorMessage();
                }
            }
            catch
            {
                Console.WriteLine(string.Format(Properties.Resources.ViewErrTest, "Åttonde"));
            }
        }
        private static void HorizontalLine() 
        {
            Console.WriteLine("-----------------------------------------------------------------------");
        }
        private static void ViewErrorMessage()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ErrorMessage);
            ErrorMessage = null;
            Console.ResetColor();
        }


        private static void ViewDisplay()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(Properties.Resources.Display);
            Console.ResetColor();
        }


    }
}
