//add sprite

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Kyrophyte
{
    public class KyrophyteGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kyrophyte Gun");
            Tooltip.SetDefault("'Better than the minishark'" +
                "40% chance not to consume ammo");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.noMelee = true;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = 10;
            item.shootSpeed = 18f;
            item.width = 32;
            item.height = 32;
            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;  //set to false if too op
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("KyrophyteChunk"), 25);
            recipe.AddIngredient(ItemID.IllegalGunParts);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .40f;
		}
    }
}
