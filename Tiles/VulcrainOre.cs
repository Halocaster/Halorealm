using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Halorealm.Tiles
{
    public class VulcrainOre : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true; 
            Main.tileValue[Type] = 550;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 800;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Vulcrain Ore");
            AddMapEntry(new Color(22, 75, 201), name);
            dustType = 84;
            drop = mod.ItemType("VulcrainOre");
            soundType = 21;
            soundStyle = 1;
            minPick = 55;
        }
    }
}
