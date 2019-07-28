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
            Tooltip.SetDefault("'From the edge of unknown'\n" +
                "Inflicts Darkshade Flames");
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

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(mod.BuffType("DarkshadeBurn"), 120);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(2))
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("DarkshadeBurn"));
            }
        }
    }
}
