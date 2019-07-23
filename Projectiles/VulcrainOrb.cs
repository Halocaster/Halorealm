//add sprite

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Projectiles
{
    public class VulcrainOrb : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Orb");
            Main.projFrames[projectile.type] = 3;
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 12;
            projectile.height = 12;
            projectile.aiStyle = 29;  //change later
            aiType = ProjectileID.SapphireBolt; //change later
            projectile.timeLeft = 3600;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.friendly = true;
            projectile.maxPenetrate = 6;
        }

        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 0.215f, 0.30f, 0.90f);
            projectile.alpha = 255; 
            projectile.rotation += (float)projectile.direction * 0.5f;
            projectile.velocity.Y += projectile.ai[0];
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("VulcrainDust"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 60);
        }

        //add OnTileCollide projectile explosion later
    }
}
