using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anti_Suicide0492
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not debug messages should be shown.")]
        public bool Debug { get; set; } = false;

        [Description("Stop a zombie from suicide by tesla.")]
        public bool StopTeslaSuicide { get; set; } = true;

        [Description("Stop a zombie from suicide by jumping in the void.")]
        public bool StopVoidSuicide { get; set; } = true;

        [Description("Send a message to the player that he is not allowed to role cursing.")]
        public bool StopSuicideMessage { get; set; } = true;

        [Description("Should the suicide message be a broadcast? (otherwise it will be a hint)")]
        public bool SendMessageAsBroadcast { get; set; } = true;

        [Description("Change the stop suicide message")]
        public string SuicideMessage { get; set; } = "<color=red>You are not allowed to commit suicide</color>";

        [Description("Change the stop suicide message duration")]
        public float SuicideMessageDuration { get; set; } = 2;
    }
}
