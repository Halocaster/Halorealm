﻿using Microsoft.Xna.Framework;
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
            projectile.magic = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.alpha = 175;
            projectile.penetrate = 7;
            projectile.aiStyle = 0;
        }

        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 30f)
            {
                projectile.ai[0] = 0f;
                projectile.netUpdate = true;
                projectile.velocity.X = projectile.velocity.X * 0.8f;
            }
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("DarkshadeBurn"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }

        public void OnHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            target.AddBuff(mod.BuffType("DarkshadeBurn"), 120);
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Black;
        }
    }
}
