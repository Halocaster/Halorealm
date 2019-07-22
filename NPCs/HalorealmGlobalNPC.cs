using Terraria;
using Terraria.ModLoader;

namespace Halorealm.NPCs
{
    public class HalorealmGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.lifeMax > 5 && npc.value > 0f) //edit to make it drop from enemies after killing EoC
            {
                if (Main.rand.NextBool(5))
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("HalocraticEssence"));
                }
            }
        }
    }
}
