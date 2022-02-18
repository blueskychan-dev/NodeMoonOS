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
    public static class appmanager
    {
        public static void TrySee()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon System: APP MANAGER");
        }
        public static void Main(string input, string historypath)
        {
            if (input.StartsWith("echo "))
            {
                echoapp.Main(input);
            }
            else if (input == null)
            {

            }
            else if (input.StartsWith("clear"))
            {
                Console.Clear();
            }
            else if (input.StartsWith("powercontrol "))
            {
                powercontrol.Main(input);
            }
            else if (input.StartsWith("date"))
            {
                date.Main();
            }
            else if (input.StartsWith("sysinfo"))
            {
                sysinfo.Main();
            }
            else if (input == "diskmg")
            {
                diskmg.Main();
            }
            else if (input.StartsWith("diskmg "))
            {
                diskmg.args(input);
            }
            else if (input.StartsWith("ls "))
            {
                listoffile.Main(input);
            }
            else if (input.StartsWith("cat "))
            {
                cat.Main(input);
            }
            else if (input == "ls")
            {
                listoffile.Default(historypath);
            }
            else if (input.StartsWith("touch "))
            {
                touch.Main(input);
            }
            else if (input.StartsWith("mkdir "))
            {
                mkdir.Main(input, historypath);
            }
            else if (input.StartsWith("write "))
            {
                write.Main(input);
            }
            else if (input.StartsWith("cd "))
            {
                cd.Main(input, historypath);
            }
            else if (input == "remove")
            {
                remove.Main();
            }
            else if (input.StartsWith("remove "))
            {
                remove.args(input, historypath);
            }
            else if (input.StartsWith("remove -f"))
            {
                remove.fullpath(input);
            }
            else if (input == "resetpath")
            {
                Console.WriteLine("Reset Path......");
                Kernel.Resetpath();
            }
            else if (input.StartsWith("switchpath "))
            {
                var text = input.Substring(11);

                Kernel.PathCD(text);
            }
            else if (input.StartsWith("kernelinfo"))
            {
                kernelinfo.Main();
            }
            else if (input.StartsWith("hardwareinfo"))
            {
                hardwareinfo.Main();
            }
            else if (input.StartsWith("beep"))
            {
                beep.Main();
            }
            else if (input.StartsWith("playbeep"))
            {
                playbeep.Main();
            }
            else if (input.StartsWith("help"))
            {
                help.Main();
            }
        }

    }
}

