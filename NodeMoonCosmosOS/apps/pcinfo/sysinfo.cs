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
    public static class sysinfo
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: sysinfo");
        }
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("oooo oooo                   oooo");
            Console.WriteLine(" oooo                       oo ");
            Console.WriteLine(" 8888o  88   ooooooo    ooooo888  ooooooooo8");
            Console.WriteLine(" 88 888o88 888     888 888    888 888oooooo8");
            Console.WriteLine(" 88   8888 888     888 888    888 888");
            Console.WriteLine("o88o    88   88ooo88     88ooo888o  88oooo888");
            Console.WriteLine("");
            Console.WriteLine("oooo     oooo");
            Console.WriteLine(" 8888o   888   ooooooo ooooooo  oo oooooo");
            Console.WriteLine(" 88 888o8 88 888     888 888     888 888   888");
            Console.WriteLine(" 88  888  88 888     888 888     888 888   888");
            Console.WriteLine("o88o  8  o88o  88ooo88     88ooo88 o888o o888o");



            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Beep();
            Console.WriteLine("Operating System Version: 0.1.7 Open Source");
            Console.WriteLine("All Installation of RAM: " + CPU.GetAmountOfRAM() + "MB");
            Console.WriteLine("All available of Memory: " + CPU.GetEndOfKernel() + 1024 / 1048576 + "KB");
            Console.WriteLine("CPU: " + CPU.GetCPUBrandString());


            Console.Beep();
            Console.ResetColor();
        }
    }
}

