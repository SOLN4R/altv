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
        [CommandEvent(CommandEventType.CommandNotFound)]
        public void CommandNotFound(IPlayer iplayer, string command) 
        {
            iplayer.SendChatMessage("{E81123}[Ошибка] {FFFFFF}Команды " + command + " не существует.");
            return;
        }
    }
}
