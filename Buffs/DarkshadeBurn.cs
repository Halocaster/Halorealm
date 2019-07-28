﻿using Halorealm.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace Halorealm.Buffs
{
    public class DarkshadeBurn : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Darkshade Flames");
            Description.SetDefault("Rapidly losing life");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<HalorealmPlayer>().darkshadeBurn = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<HalorealmGlobalNPC>().darkshadeBurn = true;
        }
    }
}
