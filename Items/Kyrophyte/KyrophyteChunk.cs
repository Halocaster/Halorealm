using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Kyrophyte
{
    public class KyrophyteChunk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kyrophyte Chunk");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 40, 0);
            item.rare = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.JungleSpores, 3);
            recipe.AddIngredient(ItemID.BeeWax, 3);
            recipe.AddIngredient(ItemID.Vine, 2);
            recipe.AddIngredient(ItemID.Stinger);
            // recipe.AddIngredient(ItemID.GoldOre, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
