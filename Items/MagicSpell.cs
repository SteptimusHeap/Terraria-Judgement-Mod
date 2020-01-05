using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement.Items
{
    public class MagicSpell : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("j"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A magic Spell book that sends a spray of water");
        }

        public override void SetDefaults()
        {
            item.damage = 26;
            item.magic = true;
            item.width = 500;
            item.height = 500;
            item.useTime = 20; //27
            item.useAnimation = 20; //27
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 10000;
            item.shoot = mod.ProjectileType("MagicThing");
            item.shootSpeed = 5;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.mana = 20;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 0);
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