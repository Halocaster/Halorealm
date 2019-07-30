using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Darkshade
{
    public class DarkshadeHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Darkshade Hamaxe");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 25;
            item.useAnimation = 25;
            item.hammer = 79;
            item.axe = 31;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 57, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DarkshadeBar"), 15);
            recipe.AddIngredient(ItemID.IronBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(10))
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("DarkshadeBurn"));
            }
        }
    }
}

