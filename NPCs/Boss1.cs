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
            npc.lifeMax = 80000;
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
        private float tpCoordX;
        private float tpCoordY;


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
                npc.netUpdate = true;
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
                if (timer == 240)
                {
                    int rng = Main.rand.Next(0, 7);
                    if (rng == 0)
                    {
                        tpCoordX = player.position.X + 30;
                        tpCoordY = player.position.Y;
                    }
                    else if (rng == 0)
                    {
                        tpCoordX = player.position.X + 21;
                        tpCoordY = player.position.Y - 21;
                    }
                    else if (rng == 0)
                    {
                        tpCoordY = player.position.Y - 30;
                        tpCoordX = player.position.X;
                    }
                    else if (rng == 0)
                    {
                        tpCoordX = player.position.X - 21;
                        tpCoordY = player.position.Y - 21;
                    }
                    else if (rng == 0)
                    {
                        tpCoordX = player.position.X - 30;
                        tpCoordY = player.position.Y;
                    }
                    else if (rng == 0)
                    {
                        tpCoordX = player.position.X - 21;
                        tpCoordY = player.position.Y + 21;
                    }
                    else if (rng == 0)
                    {
                        tpCoordY = player.position.Y + 30;
                        tpCoordX = player.position.X;
                    }
                    else
                    {
                        tpCoordX = player.position.X + 21;
                        tpCoordY = player.position.Y + 21;
                    }
                    Projectile.NewProjectile(new Vector2(tpCoordX, tpCoordY), new Vector2(0, 0), mod.ProjectileType("Boss1Marker"), (int)(66 * expertScale), 5f, -1);
                    npc.netUpdate = true;
                }
                else if (timer == 340)
                {
                    npc.position.X = new Vector2(tpCoordX, tpCoordY).X;
                    npc.position.Y = new Vector2(tpCoordX, tpCoordY).Y;
                    Dust.NewDust(npc.Center, npc.width, npc.height, 25, 0, 0, 150, default(Color), 0.7f);
                    Dust.NewDust(npc.Center, npc.width, npc.height, 50, 0, 0, 150, default(Color), 0.7f);
                    Dust.NewDust(npc.Center, npc.width, npc.height, 60, 0, 0, 150, default(Color), 0.7f);
                    npc.netUpdate = true;
                }
                else if (timer == 460)
                {
                    Vector2 dir = new Vector2(32, 0);
                    for (int i = 0; i < 8; i++)
                    {
                        Projectile.NewProjectile(npc.Center, dir.RotatedBy(MathHelper.ToRadians(i * 45)), mod.ProjectileType("Boss1Marker"), (int)(100 * expertScale), 5f, -1);
                        dir = new Vector2(32, 0);
                    }
                    npc.netUpdate = true;
                } else if(timer > 540){
                    timer = 0;
                }
            }
            }
        }
    }

