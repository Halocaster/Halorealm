using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade
{
    public class Shadowshooter : ModItem
    {
        public override string Texture => "Terraria/Item_" + ItemID.ChainGun; //add sprite latuhh

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadowshooter");
            Tooltip.SetDefault("'Shoots Shadow Bullets'" +
                "45% chance not to consume ammo");
        }

        public override void SetDefaults()
        {
            item.color = Color.DarkGray;
            item.damage = 20; //change if too op
            item.ranged = true;
            item.noMelee = true;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = 10;
            item.shootSpeed = 20f;
            item.width = 32;
            item.height = 32;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;  //set to false if too op
            item.useTurn = true;
        }

       public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DarkshadeBar"), 30);
            recipe.AddIngredient(ItemID.IllegalGunParts);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .45f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("ShadowBullet");
            }
            return true;
        }
    }
}
