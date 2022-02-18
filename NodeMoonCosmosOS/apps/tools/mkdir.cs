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
    public static class mkdir
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: mkdir");
        }
        public static void Main(string input, string historypath)
        {
            var path = input.Substring(6);
            Console.WriteLine("Trying Create folder on: " + historypath);
            try
            {
                Sys.FileSystem.VFS.VFSManager.CreateDirectory(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        }
    }

