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
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.IO;

namespace NodeMoonCosmosOS.apps
{
    public static class diskmg
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: diskmg");
        }
        public static void Main()
        {
            Console.WriteLine("Welcome to DiskManager (diskmg)");
            Console.WriteLine("What is diskmg? diskmg is disk manager, explorer program of");
            Console.WriteLine("NodeMoonOS! Now this are all args");
            Console.WriteLine("-t <numberdisk> -- What is disk type system.");
            Console.WriteLine("-s <numberdisk> -- Get available free space of disk.");
            Console.WriteLine("what is numberdisk? -- if you mount any drive first disk is 0: and 1,2,3: (We use DOS format)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ONE MORE THING: DISKMANAGER IS NOT RECOMMENDS ON REAL HARDWARE WE NOT SUPPORT 100%!");
            Console.WriteLine("YOU DATA CAN LOSTING IF SOMETHING IS BUGS PLEASE USE VM ONLY! THAT WILL SAFE");
            Console.ResetColor();
        }
        public static void args(string input)
        {
            var text = input.Substring(7);
            if (text.StartsWith("-t "))
            {
                var disk = input.Substring(10);
                Console.WriteLine("disk number: " + disk);
                try
                {
                    string fs_type = Sys.FileSystem.VFS.VFSManager.GetFileSystemType(disk);
                    Console.WriteLine("File System Type: " + fs_type);
                }
                catch (Exception e)
                {
                    Console.WriteLine("INFO: DISKMG CRASH: " + (e.ToString()));
                }
            }
            else if (text.StartsWith("-s"))
            {
                var disk = input.Substring(10);
                Console.WriteLine("disk number: " + disk);
                try
                {
                    long available_space = Sys.FileSystem.VFS.VFSManager.GetAvailableFreeSpace(disk);
                    Console.WriteLine("Available Free Space: " + available_space + "bytes");
                }
                catch (Exception e)
                {
                    Console.WriteLine("INFO: DISKMG CRASH: " + (e.ToString()));
                }
            }
        }
    }
}

