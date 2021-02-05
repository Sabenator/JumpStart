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


namespace JumpStart.NPCs
{
    class Boss1 : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boss1");

        }
        public override void SetDefaults()
        {
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath29;
            npc.aiStyle = -1;
            npc.lifeMax = 100000;
            npc.damage = 125;
            npc.defense = 60;
            npc.knockBackResist = 0f;
            npc.boss = true;
            npc.width = 80;
            npc.height = 80;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            music = MusicID.Boss2;
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)((npc.lifeMax * expertScale) * (1 + (numPlayers * 0.5)));
            npc.damage = (int)(npc.damage * 0.5f);
        }
        private int timer = 0;
        private int attackDelay = 60;
        private bool run = false;
        private int attackcd;
        private int cdscale;
        private float expertScale = 1f;
        private int sel;
        private bool repeatLaser;
        private int count;
        private bool dash;


        public override void AI()
        {
            if (run == false)
            {
                if (Main.expertMode)
                {
                    cdscale = 50;
                    expertScale = 1.5f;
                }
                else
                {
                    cdscale = 110;
                }
                attackcd = cdscale;
                run = true;
            }
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];

            if (!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];

                if (!player.active || player.dead)
                {
                    npc.noTileCollide = true;
                    npc.velocity = new Vector2(0f, 10f);

                    if (npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
            }
            else
            {
                timer++;
                if (timer == 30 && repeatLaser == true)
                {
                    Vector2 proj = new Vector2(10, 0);
                    for (int i = 0; i < 4; i++)
                    {
                        int r4 = Main.rand.Next(0, 45);
                        Projectile.NewProjectile(new Vector2(npc.Center.X, npc.Center.Y), proj.RotatedBy(MathHelper.ToRadians((i * 90) + r4)), ProjectileID.DeathLaser, (int)(npc.damage * 0.75) + Main.rand.Next(-50, 50), 5f);
                    }
                    repeatLaser = false;
                }
                if (timer > attackcd)
                {
                    if (Math.Abs(npc.Center.X - player.Center.X) > 900)
                    {
                        npc.position.X = player.Center.X;
                        npc.position.Y = player.Center.Y + 100;
                    }
                    //attack selector

                    if (npc.life > npc.lifeMax * 0.1)
                    {
                        sel = Main.rand.Next(0, 7);
                        if (sel == 0)
                        {
                            Vector2 proj = new Vector2(10, 0);
                            int r1 = Main.rand.Next(0, 45);
                            for (int i = 0; i < 4; i++)
                            {
                                Projectile.NewProjectile(new Vector2(npc.Center.X, npc.Center.Y), proj.RotatedBy(MathHelper.ToRadians((i * 90) + r1)), ProjectileID.DeathLaser, npc.damage / 2, 5f);
                            }
                            repeatLaser = true;
                        }
                        else if (sel == 1)
                        {

                            Vector2 proj = new Vector2(10, 0);
                            for (int i = 0; i < 8; i++)
                            {
                                int r2 = Main.rand.Next(0, 45);
                                Projectile.NewProjectile(new Vector2(npc.Center.X, npc.Center.Y), proj.RotatedBy(MathHelper.ToRadians((i * 45) + r2)), ProjectileID.DeathLaser, npc.damage / 2, 5f);
                            }
                        }
                        else if (sel == 2 || sel == 3)
                        {
                            Vector2 proj = new Vector2(10, 0);
                            int r3 = Main.rand.Next(0, 45);
                            for (int i = 0; i < 16; i++)
                            {
                                Projectile.NewProjectile(new Vector2(npc.Center.X, npc.Center.Y), proj.RotatedBy(MathHelper.ToRadians((float)((i * 22.5) + r3))), ProjectileID.DeathLaser, npc.damage / 2, 5f);
                            }
                        }

                    }
                    timer = 0;
                }
            }
           





            }
        }
    }

