using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.HAL;
using System.Threading;
using Cosmos.Core;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using NodeMoonCosmosOS.apps;
using NodeMoonCosmosOS.services;
using System.IO;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.TCP;
using Cosmos.System.Network.Config;
using System.Net.NetworkInformation;
using Cosmos.System.Graphics;

namespace NodeMoonCosmosOS
{
    public class Kernel : Sys.Kernel
    {
        public string tryit;
        public static string historypath = @"0:\";
        protected override void BeforeRun()
        {
            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NodeMoonOS!");
            Console.ResetColor();
            Console.WriteLine("Now Wait For NodeKernel.");
            Cosmos.HAL.Global.PIT.Wait(3000);
            Console.ResetColor();
            NodeMoon.TryBoot();
            appmanager.TrySee();
            echoapp.TryCheck();
            powercontrol.TryCheck();
            sysinfo.TryCheck();
            date.TryCheck();
            Cosmos.HAL.Global.PIT.Wait(2000);
            diskrun.autorun();
            Cosmos.HAL.Global.PIT.Wait(1000);
        }

        protected override void Run()
        {
            NodeMoon.Welcome();
            Console.WriteLine("Mounting a NodeMoonOS");
        antidownwithoutreason:
            NodeMoon.Main(historypath);
            goto antidownwithoutreason;
        }
        public static void PathCD(string historypath)
        {
        antidownwithoutreason:
            NodeMoon.Main(historypath);
            goto antidownwithoutreason;
        }
        public static void Resetpath()
        {
            string historypath = @"0:\";
        antidownwithoutreason:
            NodeMoon.Main(historypath);
            goto antidownwithoutreason;
        }
    }
}
