using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.NPCs
{
    public class Haloslime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Haloslime");
            Main.npcFrameCount[npc.type] = 2;
        }

        public override void SetDefaults()
        {
            npc.damage = 7;
            npc.width = 32;
            npc.height = 32;
            npc.aiStyle = 1; //make a unique AI sometime
            npc.knockBackResist = 1f;
            npc.alpha = 175;
            npc.defense = 2;
            npc.value = 25f;
            npc.lifeMax = 25;
            npc.buffImmune[BuffID.OnFire] = true;
            npc.buffImmune[BuffID.Frostburn] = true;
            npc.buffImmune[BuffID.ShadowFlame] = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Overworld.Chance * 0.05f;
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 60);
            target.AddBuff(BuffID.Frostburn, 60);
            target.AddBuff(BuffID.ShadowFlame, 60);
        }
        
    }
}
