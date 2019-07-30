using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade
{
    public class DarkshadeRepeater : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darkshade Repeater");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.noMelee = true;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1; 
            item.shootSpeed = 10f;
            item.width = 32;
            item.height = 32;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 80, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;  
            item.useTurn = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DarkshadeBar"), 20);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

