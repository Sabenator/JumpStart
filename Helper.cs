using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace JumpStart
{
    public class JumpStartFunctions {
        public static void ProjBurst(float x, float y, int velocity, int projID, int count, int BaseDmg, float kb)
        {
            float rotation = 360 / count;
            Vector2 proj = new Vector2(velocity, 0);
            for (int i = 0; i < count; i++)
            {
                Projectile.NewProjectile(new Vector2(x, y), proj.RotatedBy(i * rotation), projID, BaseDmg, kb);
            }
        }
        public static void ProjBurst(float x, float y, int velocity, int projID, int count, float expertScaling, int BaseDmg, float kb, int initRotation, int countMax)
        {
            Vector2 proj = new Vector2(velocity, 0);
            proj = proj.RotatedBy(MathHelper.ToRadians(initRotation));
            int countR = Main.rand.Next(count, countMax);
            for (int i = 0; i < countR; i++)
            {
                proj = proj.RotatedBy(MathHelper.ToRadians(360 / countR));
                Projectile.NewProjectile(new Vector2(x, y), proj, projID, BaseDmg, kb);
            }
        }
    }
}
