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


namespace NodeMoonCosmosOS.services
{
    public static class diskrun
    {
        public static void autorun()
        {
            try
            {
                var fs = new Sys.FileSystem.CosmosVFS();
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  OK  ");
                Console.ResetColor();
                Console.WriteLine("] NodeMoon System: disk services (diskrun)");
            }
            catch (Exception e)
            {
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("FAILED");
                Console.ResetColor();
                Console.WriteLine("] NodeMoon System: disk services (diskrun)");
                Console.WriteLine("INFO: DISKRUN ERROR: " + (e.ToString()));
                Console.WriteLine("WARN: DISKRUN SERVICES STATUS IS FAILED!");
                Console.WriteLine("INFO: you cannot use tools about disk.");
            }
        }
    }
}

