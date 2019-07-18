﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Vulcrain
{
    public class VulcrainHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vulcrain Hammer");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 22;
            item.useAnimation = 25;
            item.hammer = 50;     
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 16, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VulcrainBar"), 9);
            recipe.AddIngredient(ItemID.Wood, 3);
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
