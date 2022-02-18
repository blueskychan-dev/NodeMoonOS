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
    public static class listoffile
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: listoffile (ls)");
        }
        public static void Main(string input)
        {
            var path = input.Substring(3);
            Console.WriteLine("List of Files in path: " + path);
            var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(path);
            foreach (var directoryEntry in directory_list)
            {
                Console.WriteLine(directoryEntry.mName);
            }
        }
        public static void Default(string historypath)
        {
            string path = historypath;
            Console.WriteLine("List of Files in path: " + path);
            try
            {
                var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(path);
                foreach (var directoryEntry in directory_list)
                {
                    Console.WriteLine(directoryEntry.mName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("READ ERROR WITH MESSAGE: " + e.ToString());
                Console.WriteLine("This error message is helpful for check what happening?");
            }
        }
    }
}

