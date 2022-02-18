using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.Core.IOGroup;
using System.Threading;
using Cosmos.HAL;
using Cosmos.Core;
using Cosmos.Common;
using System.Net;
using Cosmos.System.Network;


namespace NodeMoonCosmosOS.apps
{
    public static class date
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon System: date");
        }
        public static void Main()
        {
            Console.WriteLine("Date: " + Cosmos.HAL.RTC.DayOfTheMonth + "/" + Cosmos.HAL.RTC.Month + "/" + "20" + Cosmos.HAL.RTC.Year);
            Console.WriteLine("Time: " + Cosmos.HAL.RTC.Hour + ":" + Cosmos.HAL.RTC.Minute + ":" + Cosmos.HAL.RTC.Second);
            Console.WriteLine("Notice: Date Format is dd/mm/yyyy");
            Console.WriteLine("Notice: Time is 24h format");
        }
        public static void shortforsys()
        {
            Console.WriteLine("Kernel been boot successfully in date:");
            Console.WriteLine("Date: " + Cosmos.HAL.RTC.DayOfTheMonth + "/" + Cosmos.HAL.RTC.Month + "/" + "20" + Cosmos.HAL.RTC.Year);
            Console.WriteLine("Time: " + Cosmos.HAL.RTC.Hour + ":" + Cosmos.HAL.RTC.Minute + ":" + Cosmos.HAL.RTC.Second);
        }
    }
}

