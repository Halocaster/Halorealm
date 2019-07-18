using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain
{
    public class VulcrainPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Pickaxe");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 6;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 16;
            item.useAnimation = 16;
            item.pick = 58;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = Item.buyPrice(0, 5, 75, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainBar"), 12);
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(10))
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("VulcrainDust"));
            }
        }
    }
}
