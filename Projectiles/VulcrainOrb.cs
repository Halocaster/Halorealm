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
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 29;  //change later
            aiType = ProjectileID.DiamondBolt; //change later
            projectile.timeLeft = 3600;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.friendly = true;
            projectile.maxPenetrate = 6;
        }

        public override void AI()
        {
            projectile.light = 0.5f; 
            projectile.alpha = 150; 
            projectile.rotation += (float)projectile.direction * 0.5f;
            projectile.velocity.Y += projectile.ai[0];
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("VulcrainDust"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 2);
        }

        //add OnTileCollide projectile explosion later
    }
}
