using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Projectiles
{
    public class Aeroslice : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Aeroslice");
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = -1f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 275f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 11f;
        }

        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.scale = 1f;
            projectile.extraUpdates = 0;
        }

        public override void PostAI()
        {
            if (Main.rand.NextBool())
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 16);
                dust.noGravity = true;
                dust.scale = 1.6f;
            }
        }
    }
}
