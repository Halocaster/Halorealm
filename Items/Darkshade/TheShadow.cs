using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade
{
    public class TheShadow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Shadow");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 44; //change if too op
            item.magic = true;
            item.noMelee = true;
            item.mana = 10;
            item.shoot = mod.ProjectileType("TheShadow"); //make the projectile pierce into enemies
            item.shootSpeed = 24f;  //change if the projectile moves too fast or too slow :)
            item.width = 30;
            item.height = 30;
            item.useTime = 20; //change
            item.useAnimation = 20;  //change
            item.useStyle = 5;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item20; //change
            item.autoReuse = true;
            item.useTurn = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DarkshadeBar"), 30);
            recipe.AddIngredient(mod.ItemType("VulcrainStaff"));
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

