using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm
{
    public class HalorealmPlayer : ModPlayer
    {
        public bool vulcrainCharm;

        public override void ResetEffects()
        {
            vulcrainCharm = false;
        }

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (vulcrainCharm)
            {
                target.AddBuff(BuffID.Frostburn, 120);
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (vulcrainCharm)
            {
                target.AddBuff(BuffID.Frostburn, 120);
            }
        }
    }
}
