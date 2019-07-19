//add sprite

using Terraria;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain
{
    public class VulcrainOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Ore");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 999;
            item.consumable = true;
            item.createTile = mod.TileType("VulcrainOre");
            item.width = 12;
            item.height = 12;
            item.value = Item.sellPrice(0, 0, 20, 0);
        }
    }
}
