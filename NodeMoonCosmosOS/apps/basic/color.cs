// Color app is not done we will adding on NodeMoon 0.1.8
// This just source code.

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
    public static class color
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: color");
        }
        public static void Main(string input)
        {
            var text = input.Substring(6);

            if (text.StartsWith("a"))
            {
                
            }
        }
        public static void empty()
        {
            Console.WriteLine("Welcome to Color Manager!");
            Console.WriteLine("\n");

            Console.WriteLine("0 = Black       8 = Gray");
            Console.WriteLine("1 = Blue        9 = Light Blue");
            Console.WriteLine("2 = Green       A = Light Green");
            Console.WriteLine("3 = Aqua        B = Light Aqua");
            Console.WriteLine("4 = Red         C = Light Red");
            Console.WriteLine("5 = Purple      D = Light Purple");
            Console.WriteLine("6 = Yellow      E = Light Yellow");
            Console.WriteLine("7 = White       F = Bright White");

            Console.WriteLine("\n Command Example: color a");
        }
    }
}

