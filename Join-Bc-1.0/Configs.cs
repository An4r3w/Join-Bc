using CensusAPI.Interfaces;
using System.ComponentModel;

namespace join_BC
{
    public class Configs : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        public string BcMessage { get; set; } = "Hello!";

        public bool IsMissionEnabled { get; set; } = false;

        public string MissionMessage { get; set; } = "Good Game!";
    }
}
