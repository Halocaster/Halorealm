using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Zenon
{
    [AutoloadEquip(EquipType.Head)]
    public class ZenonHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zenon Hood");
            Tooltip.SetDefault("Increases minion damage by 5%" +
                "\nIncreases your max number of minions");
        }

        public override void SetDefaults()
        {
            item.defense = 5;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 85, 0);
            item.rare = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ZenonBreastplate") && legs.type == mod.ItemType("ZenonGreaves");
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.05f;
            player.maxMinions += 1;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases minion damage by 15%" +
                "\nIncreases your max number of minions";
            player.minionDamage += 15f;
            player.maxMinions += 2;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeHeadgear);
            recipe.AddIngredient(mod.ItemType("HalocraticEssence"), 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}
