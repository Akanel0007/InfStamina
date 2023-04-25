using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeassPluginsInfStamina
{
    public class CgInfStaminaConfig : IRocketPluginConfiguration
    {
        public string LoadMessage { get; set; }
        public string geassstaminaperm;
        public void LoadDefaults()
        {
            geassstaminaperm = "geassstperm";
            LoadMessage = "Code Geass Support https://discord.gg/HCfG6JctPC";
        }

    }

}
