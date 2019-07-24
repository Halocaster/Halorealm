using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Accessories
{
    public class FrostfireEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellstone Charm");
            Tooltip.SetDefault("Attacks inflict Frostburn and Fire");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 5;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<HalorealmPlayer>().frostfireEmblem = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainCharm"));
            recipe.AddIngredient(mod.ItemType("HellstoneCharm"));
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
