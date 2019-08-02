using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class DarkshadeBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darkshade Breastplate");
            Tooltip.SetDefault("10% increased damage");
        }

        public override void SetDefaults()
        {
            item.defense = 9;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 1, 10, 0);
            item.rare = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DarkshadeBar"), 35);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
