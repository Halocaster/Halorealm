using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Projectiles
{
    public class TheShadow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Shadow");
            Main.projFrames[projectile.type] = 5;
        }

        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 40;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.alpha = 175;
            projectile.penetrate = 7;
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Black;
        }
    }
}
