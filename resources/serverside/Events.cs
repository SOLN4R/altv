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
        public void PlayerConnect(IPlayer player, String reason)
        {
            player.Spawn(new AltV.Net.Data.Position(0, 0, 0), 0);
            player.Model = (uint) PedModel.FreemodeMale01;
        }

        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public void PlayerDisconnect(IPlayer player, String reason)
        {
            
        }
    }
}
