using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class DarkshadeMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darkshade Mask");
            Tooltip.SetDefault("10% increased ranged damage" +
                "\n 5% increased ranged crit chance");
        }

        public override void SetDefaults()
        {
            item.defense = 9;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 1, 5, 0);
            item.rare = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("DarkshadeBreastplate") && legs.type == mod.ItemType("DarkshadeLeggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.1f;
            player.rangedCrit += 5;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Minor increase in physical and mental stats";
            player.statDefense += 5;
            player.lifeRegen += 15;
            player.rangedCrit += 5;
            player.rangedDamage += 0.05f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DarkshadeBar"), 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
