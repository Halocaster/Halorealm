using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm
{
    public class HalorealmPlayer : ModPlayer
    {
        public bool vulcrainCharm;
        public bool hellstoneCharm;
        public bool frostfireEmblem;
        public bool darkshadeBurn;

        public override void ResetEffects()
        {
            vulcrainCharm = false;
            hellstoneCharm = false;
            frostfireEmblem = false;
            darkshadeBurn = false;
        }

        public override void UpdateDead()
        {
            darkshadeBurn = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (darkshadeBurn)
            {
                if (player.lifeRegen > 0)
                {
                    player.lifeRegen = 0;
                }
                player.lifeRegenTime = 0;
                player.lifeRegen -= 20;
            }
        }

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (vulcrainCharm)
            {
                target.AddBuff(BuffID.Frostburn, 120);
            }

            if (hellstoneCharm)
            {
                target.AddBuff(BuffID.OnFire, 120);
            }

            if (frostfireEmblem)
            {
                target.AddBuff(BuffID.Frostburn, 120);
                target.AddBuff(BuffID.OnFire, 120);
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (vulcrainCharm)
            {
                target.AddBuff(BuffID.Frostburn, 120);
            }

            if (hellstoneCharm)
            {
                target.AddBuff(BuffID.OnFire, 120);
            }

            if (frostfireEmblem)
            {
                target.AddBuff(BuffID.Frostburn, 120);
                target.AddBuff(BuffID.OnFire, 120);
            }
        }

        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (vulcrainCharm)
            {
                target.AddBuff(BuffID.Frostburn, 120);
            }

            if (hellstoneCharm)
            {
                target.AddBuff(BuffID.OnFire, 120);
            }

            if (frostfireEmblem)
            {
                target.AddBuff(BuffID.Frostburn, 120);
                target.AddBuff(BuffID.OnFire, 120);
            }
        }

        public override void DrawEffects(PlayerDrawInfo drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
        {
            if (darkshadeBurn)
            {
                if (Main.rand.NextBool(4) && drawInfo.shadow == 0f)
                {
                    int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, mod.DustType("DarkshadeBurn"), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default(Color), 3f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity *= 1.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                    Main.playerDrawDust.Add(dust);
                }
                r *= 0.2f;
                g *= 0.1f;
                b *= 0.7f;
                fullBright = true;
            }
        }
    }
}
