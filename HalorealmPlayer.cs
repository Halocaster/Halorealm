using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm
{
    public class HalorealmPlayer : ModPlayer
    {
        public bool vulcrainCharm;
        public bool hellstoneCharm;

        public override void ResetEffects()
        {
            vulcrainCharm = false;
            hellstoneCharm = false;
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
        }
    }
}
