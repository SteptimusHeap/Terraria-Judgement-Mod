using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement.Items
{
    public class FlameSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("j"); //
            Tooltip.SetDefault("A flaming sword found in The depths of hell.");
        }

        public override void SetDefaults()
        {
            item.damage = 26;
            item.melee = true;
            item.width = 100;
            item.height = 100;
            item.useTime = 27; //27
            item.useAnimation = 27; //27
            item.useStyle = 1;
            item.knockBack = 15;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-100, -100);
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