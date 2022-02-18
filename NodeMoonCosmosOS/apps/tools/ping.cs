// This code is not working DONT TRY IN UR CODE!
// Everything working code WILL are in appmanager.cs

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
using System.Net.NetworkInformation;
using Cosmos.System.Network.IPv4.UDP;
using Cosmos.System.Network.IPv4.TCP;

namespace NodeMoonCosmosOS.apps
{
    public static class netping
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] NodeMoon app: ping (netping)");
        }
        public static void Main(string input)
        {
            var ip = input.Substring(5);
            Ping pinger = null;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(ip);
                Console.WriteLine("Ping: " + ip + " Status: " + reply.Status + " time=" + reply.RoundtripTime + "ms");
            }
            catch
            {

            }
        }
    }
}

