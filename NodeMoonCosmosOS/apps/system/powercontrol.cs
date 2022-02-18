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
    public static class powercontrol
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: powercontrol");
        }
        public static void Main(string input)
        {
            var text = input.Substring(13);
            if (text == "")
            {
                Console.WriteLine("ERROR: Power Methods is null");
            }
            else if (text == "reboot")
            {
                Console.Clear();
                Console.WriteLine("System will reboot by self in a sec");
                Cosmos.HAL.Global.PIT.Wait(2000);
                Sys.Power.Reboot();
                Console.WriteLine("INFO: IF SYSTEM IS NOT REBOOT we will reboot a cpu.");
                Cosmos.HAL.Global.PIT.Wait(2000);
                CPU.Reboot();
            }
            else if (text == "shutdown")
            {
                Console.Clear();
                Console.WriteLine("System will poweroff by self in a sec");
                Cosmos.HAL.Global.PIT.Wait(2000);
                Sys.Power.Shutdown();
                Console.WriteLine("INFO: IF SYSTEM IS NOT POWEROFF we will halt a cpu.");
                Cosmos.HAL.Global.PIT.Wait(2000);
                CPU.Halt();
            }
        }
    }
}

