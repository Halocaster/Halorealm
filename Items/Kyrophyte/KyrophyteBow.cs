using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Kyrophyte
{
    public class KyrophyteBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kyrophye Bow");
            Tooltip.SetDefault("More faster than the Longbow, but damage is lesser");
        }

        public override void SetDefaults()
        {
            item.damage = 23;
            item.ranged = true;
            item.noMelee = true;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = 10; //change..?
            item.shootSpeed = 9f;
            item.width = 32;
            item.height = 32;
            item.useTime = 14;
            item.useAnimation = 14;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("KyrophyteChunk"), 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
