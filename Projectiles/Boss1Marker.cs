using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace JumpStart.Projectiles
{
	public class Boss1Marker : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Name Here");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 0;
			projectile.friendly = false;
			projectile.ranged = true;
			aiType = 0;
			projectile.alpha = 255;
		}

		// Additional hooks/methods here.
		public int timer = 0;
        public override void AI()
        {

			Player player = Main.player[projectile.owner];
			timer++;
			if (projectile.alpha > 0) {
				projectile.alpha += 5;
			}
			int choice = 0;
			int r = Main.rand.Next(0, 3);
			if (r == 0) {
				choice = 50;
			}
			else if (r == 1) {
				choice = 60;
			} else {
				choice = 25;
			}
			Lighting.AddLight(projectile.Center, 0.9f, 0.1f, 0.3f);
			Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, 0, 0, 150, default(Color), 0.7f);
			if (timer > 120) {
				projectile.Kill();
			}
			
        }
        public override void Kill(int timeLeft)
        {
			NPC npc = Main.npc[projectile.owner];
			int startRain = -1280;
			for (int i = 0; i < 16; i++) {
				Projectile.NewProjectile(new Vector2((npc.position.X - startRain) + (i * 80), npc.position.Y + 1200), new Vector2(0, -10), ProjectileID.DeathLaser, 150, 5f, projectile.owner);
			}
		}
    }
}