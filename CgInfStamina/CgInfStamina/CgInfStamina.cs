using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeGeassPluginsInfStamina
{
    public class Infstamina : RocketPlugin<CgInfStaminaConfig>
    {
        protected override void Load()
        {

            Logger.Log($"{name} {Assembly.GetName().Version} Loaded");
            UnturnedPlayerEvents.OnPlayerUpdateStamina += geassstamina;
        }

        private void geassstamina(UnturnedPlayer player, byte stamina)
        {
            if (!player.HasPermission(Configuration.Instance.geassstaminaperm))
            {
                return;
            }

            if (stamina >= 30)
            {
                return;
            }
            player.Player.life.serverModifyStamina(100);
        }


        protected override void Unload()
        {
            Logger.Log($"{Name} Unloaded");
        }
    }
}
