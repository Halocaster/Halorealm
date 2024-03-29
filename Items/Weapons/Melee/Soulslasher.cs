﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Items.Weapons.Melee
{
    public class Soulslasher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soulslasher");
            Tooltip.SetDefault(""); //add a beaut tooltip latuhh
        }

        public override void SetDefaults()
        {
            item.damage = 999;
            item.melee = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.sellPrice(66, 99, 66, 99);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("HalocraticEssence"), 50);
            recipe.AddIngredient(mod.ItemType("VulcrainSword"));
            recipe.AddIngredient(ItemID.Muramasa);
            recipe.AddIngredient(ItemID.FieryGreatsword);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // think of a recipe for this sword

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 120);
            target.AddBuff(BuffID.Frostburn, 120);
        }
    }
}