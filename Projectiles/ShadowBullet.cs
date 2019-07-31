using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Projectiles
{
    public class ShadowBullet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bullet");     
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;   
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;          
            projectile.aiStyle = 1;             
            projectile.friendly = true;        
            projectile.hostile = false;         
            projectile.ranged = true;           
            projectile.penetrate = 7;           
            projectile.timeLeft = 600;      
            projectile.alpha = 100;        
            projectile.light = 0.05f;           
            projectile.ignoreWater = true;
            projectile.tileCollide = true;          
            projectile.extraUpdates = 1;    
            aiType = ProjectileID.Bullet;          
        }
    }
}
