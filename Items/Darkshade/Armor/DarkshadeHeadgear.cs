using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class DarkshadeHeadgear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darkshade Helmet");
            Tooltip.SetDefault("10% increased magic damage" +
                "\n 5% increased magic crit chance" +
                "\n Reduced mana usage" +
                "\n +60 mana");
        }

        public override void SetDefaults()
        {
            item.defense = 8;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 1, 25, 0);
            item.rare = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("DarkshadeBreastplate") && legs.type == mod.ItemType("DarkshadeLeggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.1f;
            player.magicCrit += 5;
            player.manaCost -= 5;
            player.statManaMax2 += 60;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Minor increase in magical stats";
            player.statDefense += 5;
            player.lifeRegen += 15;
            player.magicCrit += 5;
            player.magicDamage += 0.05f;
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
