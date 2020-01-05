using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Judgement.Projectiles
{

    public class MagicThing : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A magic Shooter Thingy");
        }

        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 0;
            projectile.timeLeft = 600;
            projectile.friendly = true;
            projectile.magic = true;
            aiType = ProjectileID.Bullet;

        }
    }
}