using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Accessories
{
    public class HellstoneCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellstone Charm");
            Tooltip.SetDefault("Attacks inflict fire");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.value = Item.sellPrice(0, 1, 60, 0);
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<HalorealmPlayer>().hellstoneCharm = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 25);
            recipe.AddIngredient(ItemID.FireFeather, 5); //change the item latuuhh
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddIngredient(ItemID.Fireblossom, 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
