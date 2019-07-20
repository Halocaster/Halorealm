//add sprite

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class VulcrainHeadgear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Headgear");
            Tooltip.SetDefault("8% increased magic damage");
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
            player.magicDamage += 0.08f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Attacks inflict mild frostburn";
            player.AddBuff(BuffID.Frostburn, 1);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainBar"), 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}