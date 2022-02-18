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
    public static class kernelinfo
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: kernelinfo");
        }
        public static void Main()
        {
            Console.WriteLine("Kernel Info: NodeKernel Stable");
            Console.WriteLine("Version: 1.2.0");
            Console.WriteLine("Based on: CosmosOS (Userkit 2022)");
        }
    }
}

