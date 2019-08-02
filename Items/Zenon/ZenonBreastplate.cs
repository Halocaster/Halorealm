using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Zenon
{
    [AutoloadEquip(EquipType.Head)]
    public class ZenonBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zenon Breastplate");
            Tooltip.SetDefault("Increases minion damage by 5%" +
                "\nIncreases your max number of minions");
        }

        public override void SetDefaults()
        {
            item.defense = 6;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.05f;
            player.maxMinions += 1;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeBreastplate);
            recipe.AddIngredient(mod.ItemType("HalocraticEssence"), 100);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}