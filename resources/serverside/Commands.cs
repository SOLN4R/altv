using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Resources.Chat.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverside
{
    public class Commands : IScript
    {
        [Command("test")]
        public static void Test(IPlayer iplayer, string Message)
        {
            Message = "Hello from Serverside!";
            iplayer.Emit("SERVER_CLIENT_Message", Message);
        }
    }
}
