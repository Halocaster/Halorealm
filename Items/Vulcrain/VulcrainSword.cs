using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Halorealm.Items.Vulcrain
{
    public class VulcrainSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Sword");
            Tooltip.SetDefault("'This sword is cold as sin'");
        }

        public override void SetDefaults()
        {
            item.damage = 14;           
            item.melee = true;         
            item.width = 32;           
            item.height = 32;          
            item.useTime = 23;          
            item.useAnimation = 21;
            item.useStyle = 1;          
            item.knockBack = 4;         
            item.value = Item.buyPrice(0, 5, 0, 0);        
            item.rare = 2;            
            item.UseSound = SoundID.Item1;      
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainBar"), 9);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("VulcrainDust"));
            }
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 60);
        }
    }
}
