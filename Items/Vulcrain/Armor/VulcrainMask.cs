using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class VulcrainMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Mask");
            Tooltip.SetDefault("8% increased ranged damage");
        }

        public override void SetDefaults()
        {
            item.defense = 4;
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 60, 0);
            item.rare = 2;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("VulcrainBreastplate") && legs.type == mod.ItemType("VulcrainLeggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.08f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "5% increased damage" +
                "n/3+ defense " +
                "n/Increased life regeneration";
            player.allDamage += 0.05f;
            player.statDefense += 3;
            player.lifeRegen += 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainBar"), 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
        }
    }
}
