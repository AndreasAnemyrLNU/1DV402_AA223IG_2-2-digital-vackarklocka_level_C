﻿using System;
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


            AlarmClock alarmClock = new AlarmClock("7:32","8:49");

            Console.WriteLine(alarmClock.ToString());


        Console.ReadKey();

        }
    }
}
