//add sprite

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain
{
    public class VulcrainBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Bow");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 13;
            item.ranged = true;
            item.noMelee = true;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = 10; //change..?
            item.shootSpeed = 18f; 
            item.width = 32;
            item.height = 32;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 16, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;  //set to true if you want
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainBar"), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        //add Frostburn debuff later
    }
}
