using CensusAPI.Features;
using System;


namespace join_BC
{
    public class Plugin : Plugin<Configs>
    {
        public override string Name { get; } = "join BC";

        public override Version Version { get; } = new Version(2, 0, 0);

        public override string Author { get; } = "An4r3w";
        
        public EventHandlers EventHandlers { get; set; }

        public override void Disable()
        {
            Plugin.Singleton = this;
            this.EventHandlers = new EventHandlers();
        }

        public override void Enable()
        {
            this.EventHandlers = null;
            CensusCore.CensusCore.InjectEvents();
            
        }

        public static Plugin Singleton;
    }
}
