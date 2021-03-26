using CensusAPI.Features;
using PluginFramework.Attributes;
using PluginFramework.Events.EventsArgs;

namespace join_BC
{
    public class EventHandlers
    {
        [PlayerEvent(PlayerEventType.OnPlayerJoinFinal)]
        public static void OnPlayerJoin(PlayerJoinFinalEvent ev)
        {
            Player player = Player.Get(ev.player);
            player.SendChatMessage(Plugin.Singleton.Config.BcMessage);
            
            if(Plugin.Singleton.Config.IsMissionEnabled)
            {
                player.AddMission(Plugin.Singleton.Config.MissionMessage);
            }
        }
    }
}
