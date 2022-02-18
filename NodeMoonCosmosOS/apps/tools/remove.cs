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
    public static class remove
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: remove");
        }
        public static void Main()
        {
            Console.WriteLine("ERROR: missing operand");
            Console.WriteLine("$ remove <FileName> -- Delete files");
            Console.WriteLine("$ remove <FolderName> -- Delete files on full path");
            Console.WriteLine("$ remove -f <FileName> -- Delete files on full path");
            Console.WriteLine("Folder Delete in Work in Process **Follow us in github and discord**");
            Console.ResetColor();
        }
        public static void args(string input, string historypath)
        {
            var text = input.Substring(7);
            {
                var path = input.Substring(7);
                string filepath = historypath + @"\" + path;
                Console.WriteLine("Deleting Files...");
                try
                {
                    Sys.FileSystem.VFS.VFSManager.DeleteFile(filepath);
                }
                catch (Exception e)
                {
                    Console.WriteLine("INFO: REMOVE CRASH: " + (e.ToString()));
                }
            }
        }
        public static void fullpath(string input)
        {
            var path = input.Substring(10);
            Console.WriteLine("Deleting Files...");
            try
            {
                Sys.FileSystem.VFS.VFSManager.DeleteFile(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("INFO: REMOVE CRASH: " + (e.ToString()));
            }
        }
    }
}


