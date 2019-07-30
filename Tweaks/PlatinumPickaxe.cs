using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Tweaks
{
    public class PlatinumPickaxe : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.PlatinumPickaxe)
            {
                tooltips.RemoveAll(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                if (line != null)
                {
                    line.text = "Can mine Meteorite and Vulcrain";
                }

            }
        }
        //special thanks to IceCoffe for the help
    }
}
