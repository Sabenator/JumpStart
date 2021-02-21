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
	class BossSawBigSlow : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Big Saw Blade (Mean)");
			Main.projFrames[projectile.type] = 3;
		}

		public override void SetDefaults()
		{
			projectile.arrow = false;
			projectile.width = 22;
			projectile.height = 22;
			projectile.aiStyle = 0;
			projectile.friendly = false;
			projectile.ranged = true;
			projectile.alpha = 255;
			projectile.knockBack = 3f;
			projectile.maxPenetrate = 20;
			projectile.hostile = true;
			projectile.scale = 2f;
		}
		public int counter = 0;
		public int delay = 300;
		public override void AI()
		{
			counter++;
			if (counter == 1) {
				Main.PlaySound(SoundID.Item71, projectile.position);
			}
			projectile.velocity *= 0.95f;
			if (projectile.velocity.Length() < 0.1) {
				projectile.velocity *= 0;
			}
			if (counter > 500) {
				Main.PlaySound(SoundID.Item10, projectile.position);
				BossMethods.ShootRing(Main.expertMode ? 12 : 8, ModContent.ProjectileType<BossSawSmall>(), 8f, 3f, 150, projectile.Center);
				projectile.Kill();
			}
			if (projectile.alpha > 0) {
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
