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
    public static class cd
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: echo");
        }
        public static void Main(string input, string historypath)
        {
            var text = input.Substring(3);
            var oldpath = historypath;
            historypath = historypath + text;
            try
            {
                Sys.FileSystem.VFS.VFSManager.CreateFile(historypath + @"\tmp");
                Sys.FileSystem.VFS.VFSManager.DeleteFile(historypath + @"\tmp");
                Kernel.PathCD(historypath);
            }
            catch
            {
                Console.WriteLine("ERROR: Path is not found UNDOING!");
            }
        }
    }
}

