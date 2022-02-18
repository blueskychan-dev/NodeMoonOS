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
    public static class cat
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: cat");
        }
        public static void Main(string input)
        {
            var path = input.Substring(4);
            try
            {
                var hello_file = Sys.FileSystem.VFS.VFSManager.GetFile(path);
                var hello_file_stream = hello_file.GetFileStream();

                if (hello_file_stream.CanRead)
                {
                    byte[] text_to_read = new byte[hello_file_stream.Length];
                    hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                    Console.WriteLine(Encoding.Default.GetString(text_to_read));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

