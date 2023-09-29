using Exiled.API.Features;
using HarmonyLib;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anti_Suicide0492
{
    public class Main : Plugin<Config>
    {
        public static Main Instance { get; set; }
        public override string Author => "Godfather Yannik";
        public override string Name => "Anti-Suicide Zombies";
        public override string Prefix => "ACZ";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 0, 0);
        private EventHandler EventHandlerManager { get; set; }

        public override void OnEnabled()
        {
            Instance = this;

            EventHandlerManager = new EventHandler(this);
            Exiled.Events.Handlers.Player.Hurting += EventHandlerManager.OnPlayerHurt;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Hurting -= EventHandlerManager.OnPlayerHurt;
            EventHandlerManager = null;

            base.OnDisabled();
        }
    }
}
