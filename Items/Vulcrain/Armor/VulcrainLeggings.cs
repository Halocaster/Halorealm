//add sprite

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class VulcrainLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Leggings");
            Tooltip.SetDefault("3% increased damage"
                + "\n10% increased movement speed");
        }

        public override void SetDefaults()
        {
            item.defense = 5;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 60, 0);
            item.rare = 2;
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.03f;
            player.moveSpeed += 0.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainBar"), 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}