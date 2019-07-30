using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade
{
    public class ShadowBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bullet");
            Tooltip.SetDefault("Pierces up to 7 targets");
        }

        public override void SetDefaults()
        {
            item.damage = 11;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;          
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 10, 0); //change later
            item.rare = 3;
            item.shoot = mod.ProjectileType("ShadowBullet");   
            item.shootSpeed = 19f;                
            item.ammo = AmmoID.Bullet;             
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(mod.ItemType("DarkshadeBar"), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 75);
            recipe.AddRecipe();
        }
    }
}
