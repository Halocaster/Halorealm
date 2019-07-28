using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade
{
    public class DarkshadeBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darkshade Bar");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 60, 0);
            item.rare = 3;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DarkshadeFragment"), 3);
            recipe.AddTile(TileID.Workbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}
