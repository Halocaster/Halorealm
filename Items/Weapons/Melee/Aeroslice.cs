using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Weapons.Melee
{
    public class Aeroslice : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aeroslice");
            Tooltip.SetDefault("'Cuts every atom in it's path'");
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.noMelee = true;
            item.channel = true;
            item.noUseGraphic = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 23;
            item.useAnimation = 21;
            item.useStyle = 5;
            item.knockBack = 7;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("Aeroslice");
            item.shootSpeed = 20f;
        }
    }
}
