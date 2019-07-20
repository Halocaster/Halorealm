//add sprite

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain
{
    public class VulcrainStaff : ModItem
    {
        public class VulcrainSword : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Vulcrain Staff");
                Tooltip.SetDefault("'It is not a spear.'");
                Item.staff[item.type] = true;
            }

            public override void SetDefaults()
            {
                item.damage = 35; //change if too op
                item.magic = true;
                item.noMelee = true;
                item.mana = 9;
                item.shoot = mod.ProjectileType("VulcrainOrb");
                item.shootSpeed = 18f;  //change if the projectile moves too fast or too slow :)
                item.width = 46;
                item.height = 46;
                item.useTime = 15; //change
                item.useAnimation = 15;  //change
                item.useStyle = 5;
                item.knockBack = 7;
                item.value = Item.sellPrice(0, 0, 80, 0);
                item.rare = 2;
                item.UseSound = SoundID.Item20; //change
                item.autoReuse = true;
                item.useTurn = true;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(mod.ItemType("VulcrainBar"), 12);
                recipe.AddIngredient(ItemID.Ruby, 2);
                recipe.AddIngredient(ItemID.Diamond, 2);
                recipe.AddIngredient(ItemID.Amber, 2);
                recipe.AddIngredient(ItemID.Emerald, 2);
                recipe.AddIngredient(ItemID.Sapphire, 2);
                recipe.AddIngredient(ItemID.Topaz, 2);
                recipe.AddIngredient(ItemID.Amethyst, 2);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
