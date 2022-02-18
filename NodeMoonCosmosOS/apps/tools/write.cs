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
    public static class write
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: write");
        }
        public static void Main(string input)
        {
            var path = input.Substring(6);
            Console.WriteLine("Write File to: " + path);
            Console.Write("Context > ");
            var data = Console.ReadLine();
            try
            {
                var hello_file = Sys.FileSystem.VFS.VFSManager.GetFile(path);
                var hello_file_stream = hello_file.GetFileStream();

                if (hello_file_stream.CanWrite)
                {
                    byte[] text_to_write = Encoding.ASCII.GetBytes(data);
                    hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

