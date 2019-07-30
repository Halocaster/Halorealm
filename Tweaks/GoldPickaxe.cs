using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Tweaks
{
    public class GoldPickaxe : GlobalItem //try to change the item's vanilla tooltip
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.GoldPickaxe)
            {
                item.pick = 59;
            }
        }
    }
}
