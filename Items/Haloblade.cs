using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items
{
    public class Haloblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Haloblade");
            Tooltip.SetDefault(""); //add a beaut tooltip latuhh
        }

        public override void SetDefaults()
        {
            item.damage = 39;
            item.melee = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 1, 20, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient();
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/

        // think of a recipe for this sword

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 120);
            target.AddBuff(BuffID.Frostburn, 120);
        }
    }
}