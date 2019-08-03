using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class DarkshadeLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Leggings");
            Tooltip.SetDefault("5% increased damage"
                + "\n20% increased movement speed");
        }

        public override void SetDefaults()
        {
            item.defense = 10;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.05f;
            player.moveSpeed += 0.2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DarkshadeBar"), 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
