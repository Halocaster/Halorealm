using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.NPCs.Bosses
{
    public class SeekerOfTruth : ModNPC
    {
        public override string Texture => "Terraria/NPC_" + NPCID.AncientCultistSquidhead;
        //get a sprite soon

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Seeker of Truth");
        }

        public override void SetDefaults()
        {
            npc.boss = true;
            npc.aiStyle = 86; //Ancient Vision AI
            npc.color = Color.Red;
            npc.damage = 20;
            npc.defDamage = 20;
            npc.defense = 32;
            npc.knockBackResist = 100f;
            npc.lifeMax = 6500;
            music = MusicID.Boss1;
            npc.alpha = 175;
            npc.lavaImmune = true;
            npc.noTileCollide = false;
            npc.value = Item.buyPrice(0, 25, 0, 0);
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            //bossBag = mod.ItemType("SeekerOfTruthBag");
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax / Main.expertLife * 1.5f * bossLifeScale);
            npc.defense = 40;
            npc.damage = (int)(npc.damage * 0.5f);
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 60);
        }

        public void OnSpawn() 
        {

        }

        public override void AI() //make AI latuuhhh
        {

        }
    }
}
