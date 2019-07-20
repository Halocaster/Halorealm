using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain
{
    [AutoloadEquip(EquipType.Body)]
    public class VulcrainBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Breastplate");
            Tooltip.SetDefault("4% increased damage");
        }

        public override void SetDefaults()
        {
            item.defense = 6;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 70, 0);
            item.rare = 2;
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.04f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainBar"), 35);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
