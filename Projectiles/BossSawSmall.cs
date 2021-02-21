using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using JumpStart;
using JumpStart.Projectiles;

namespace JumpStart.Projectiles
{
    class BossSawSmall : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Small Saw Blade (Mean)");
			Main.projFrames[projectile.type] = 3;
		}

		public override void SetDefaults()
		{
			projectile.arrow = false;
			projectile.width = 14;
			projectile.height = 14;
			projectile.aiStyle = 0;
			projectile.friendly = false;
			projectile.ranged = true;
			projectile.alpha = 255;
			projectile.knockBack = 3f;
			projectile.maxPenetrate = 12;
			projectile.hostile = true;
			projectile.scale = 2f;
		}
		public int counter = 0;
        public override void AI()
        {
			counter++;
			if (counter == 1)
			{
				Main.PlaySound(SoundID.Item71, projectile.position);
			}
			if (projectile.alpha > 0)
			{
				projectile.alpha -= 5;
			}
			projectile.rotation += 12;
		}
		public override void OnHitPlayer(Player target, int damage, bool crit)
		{
			if ((Main.expertMode || Main.rand.NextBool()) && projectile.ai[0] >= 0f)
			{
				target.AddBuff(BuffID.Bleeding, 240, true);
			}
		}

	}
}
