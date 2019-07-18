using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain
{
    public class VulcrainBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Bar");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 25, 0);
            item.rare = 3;
        }

        /*
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainOre"), 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        */
    }
}
