using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverside
{
    public class Events : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void PlayerConnect(IPlayer iplayer, String reason)
        {
            iplayer.Spawn(new AltV.Net.Data.Position(0, 0, 0), 0);
            iplayer.Model = (uint) PedModel.FreemodeMale01;
        }

        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public void PlayerDisconnect(IPlayer iplayer, String reason)
        {
            
        }
    }
}