using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement.Items
{
    public class Summon : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("j"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Oof.");
        }

        public override void SetDefaults()
        {
            item.width = 100;
            item.height = 100;
            item.useTime = 27; //27
            item.useAnimation = 27; //27
            item.useStyle = 5;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(1, 1);
        }
        public override bool UseItem(Player P)
        {
            NPC.SpawnOnPlayer(Main.myPlayer, mod.NPCType("Judgement.NPCs.Boss:SlimeBoss"));
            return true;
        }
    public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}