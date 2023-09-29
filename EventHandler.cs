using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PluginAPI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Anti_Suicide0492
{
    public class EventHandler
    {
        private readonly Main plugin;

        public EventHandler(Main plugin)
        {
            this.plugin = plugin;
        }

        internal void OnPlayerHurt(HurtingEventArgs ev)
        {
            if (ev.Player == null)
            {
                return;
            }

            if (ev.Player.Role.Type == PlayerRoles.RoleTypeId.Scp0492)
            {
                if (ev.DamageHandler.Type == Exiled.API.Enums.DamageType.Tesla && plugin.Config.StopTeslaSuicide)
                {
                    ev.IsAllowed = false;
                    SendSuicideMessageToPlayer(ev.Player);
                }
                else if (ev.DamageHandler.Type == Exiled.API.Enums.DamageType.Crushed && plugin.Config.StopVoidSuicide)
                {
                    ev.IsAllowed = false;
                    var roomcoord = ev.Player.CurrentRoom.Doors.Where(d => d.RequiredPermissions.RequiredPermissions == Interactables.Interobjects.DoorUtils.KeycardPermissions.None).ElementAt(new System.Random().Next(ev.Player.CurrentRoom.Doors.Where(d => d.RequiredPermissions.RequiredPermissions == Interactables.Interobjects.DoorUtils.KeycardPermissions.None).ToList().Count)).Position;
                    roomcoord += Vector3.forward * 0.4f;
                    roomcoord += Vector3.up;
                    ev.Player.Position = roomcoord;
                    SendSuicideMessageToPlayer(ev.Player);
                }
            }
        }

        public void SendSuicideMessageToPlayer(Player player)
        {
            if (player == null) return;

            if (plugin.Config.StopSuicideMessage)
            {
                if (plugin.Config.SendMessageAsBroadcast)
                {
                    player.Broadcast(new Exiled.API.Features.Broadcast() { Content = plugin.Config.SuicideMessage, Duration = (ushort)(plugin.Config.SuicideMessageDuration * 1000), Show = true, Type = Broadcast.BroadcastFlags.Normal}, true);
                } else
                {
                    player.ShowHint(plugin.Config.SuicideMessage, plugin.Config.SuicideMessageDuration);
                }
            }
        }
    }
}
