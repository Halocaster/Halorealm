using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Halorealm.NPCs
{
    public class HalorealmGlobalNPC : GlobalNPC
    {
        public bool darkshadeBurn;

        public override void ResetEffects(NPC npc)
        {
            darkshadeBurn = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (darkshadeBurn)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 20;
                if (damage < 2)
                {
                    damage = 2;
                }
            }
        }

        public override void NPCLoot(NPC npc)
        {
            if (npc.lifeMax > 5 && npc.value > 0f) //edit to make it drop from enemies after killing EoC
            {
                if (Main.rand.NextBool(2))
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("HalocraticEssence"));
                }
            }
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (darkshadeBurn)
            {
                if (Main.rand.Next(4) < 3)
                {
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType("DarkshadeBurn"), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity *= 1.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                    if (Main.rand.NextBool(4))
                    {
                        Main.dust[dust].noGravity = false;
                        Main.dust[dust].scale *= 0.5f;
                    }
                }
                Lighting.AddLight(npc.position, 0.2f, 0.1f, 0.7f);
            }
        }
    }
}
