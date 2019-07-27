using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade
{
    public class DarkshadeSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darkshade Sword");
            Tooltip.SetDefault("'From the edge of unknown'");
        }

        public override void SetDefaults()
        {
            item.damage = 21;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.scale += 0.1f;
        }
    }
}
