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
            npc.lifeMax = 250000;
            npc.damage = 200;
            npc.defense = 80;
            npc.knockBackResist = 0f;
            npc.boss = true;
            npc.width = 64;
            npc.height = 64;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            music = MusicID.Boss2;
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax + 100000) + ((numPlayers - 1) * 50000);
            npc.damage = (int)(npc.damage * 0.4f);
        }

        public bool stunned = false;
        public int stunCoolDown = 0;
        public int stunCoolDownMax = Main.expertMode ? 60 : 100;
        public bool attackSequence1 = false;
        public bool attackSequence2 = false;
        public bool attackSequence3 = false;
        public int ai = 0;
        public bool dash = false;
        public Vector2 target;
        public Vector2 start;
        public int dashCounter = 0;
        public Vector2 targetFixed;
        public int chaseTimer = 0;
        public bool right = false;



        public override void AI()
        {
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];

            if (!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];

                if (!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, 10f);
                    if (npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
                npc.netUpdate = true;
            }
            else {
                target = player.Center;
                ai++;

                if (npc.life > (Main.expertMode ? npc.lifeMax * 0.9f : npc.lifeMax * 0.8f))
                {
                    if (ai % 180 == 0)
                    {
                        dash = true;
                        targetFixed = player.Center;
                        start = npc.Center;
                        dashCounter = 0;
                    }
                    if (dash == true)
                    {
                        dashCounter++;
                        BossMethods.DashToward(npc, targetFixed, Main.expertMode ? 30f : 20f);
                        if (dashCounter > 90)
                        {
                            dash = false;
                        }

                    }
                    else {
                        BossMethods.MoveToward(npc, target, Main.expertMode ? 12f : 8f, 30f);
                    }
                    int randRotation = Main.rand.Next(0, 45);
                    if ((ai + 90) % 180 == 0)
                    {
                        BossMethods.ShootRing(Main.expertMode ? 12 : 8, ProjectileID.DeathLaser, 8f, 5f, npc.damage / 5, npc, randRotation);
                    }
                    else if ((ai + 120) % 180 == 0)
                    {
                        BossMethods.ShootRing(Main.expertMode ? 12 : 8, ProjectileID.DeathLaser, 8f, 5f, npc.damage / 5, npc, randRotation);
                    }
                    else if ((ai + 150) % 180 == 0 && Main.expertMode)
                    {
                        BossMethods.ShootRing(12, ProjectileID.DeathLaser, 8f, 5f, npc.damage / 4, npc, randRotation);
                    }
                    else if ((ai + 180) % 180 == 0 && Main.expertMode)
                    {
                        BossMethods.ShootRing(12, ProjectileID.DeathLaser, 8f, 5f, npc.damage / 5, npc, randRotation);
                    }
                }
                else if (npc.life > (Main.expertMode ? npc.lifeMax * 0.8f : npc.lifeMax * 0.6f))
                {
                    chaseTimer++;
                    //Choose direction
                    if (chaseTimer + 89 % 90 == 0) {
                        right = Main.rand.Next(0, 2) < 1 ? true : false;
                    }
                    if (chaseTimer <= 91)
                    {
                        BossMethods.MoveToward(npc, target, Main.expertMode ? 12f : 8f, 30f);
                        if (chaseTimer % 2 == 0)
                        {
                            if (right == true)
                            {
                                Projectile.NewProjectile(npc.Center, 8f * Vector2.Normalize(new Vector2(1, 0).RotatedBy(MathHelper.ToRadians(chaseTimer * 4))), ProjectileID.DeathLaser, npc.damage / 5, 5f);
                            } else if (right == false)
                            {
                                Projectile.NewProjectile(npc.Center, 8f * Vector2.Normalize(new Vector2(1, 0).RotatedBy(MathHelper.ToRadians(chaseTimer * -4))), ProjectileID.DeathLaser, npc.damage / 5, 5f);
                            }
                        }
                    }
                    else if (chaseTimer < 300)
                    {
                        BossMethods.MoveToward(npc, target, Main.expertMode ? 16f : 12f, 30f);
                        if (ai % (Main.expertMode ? 45 : 75) == 0) {
                            int attackSelect = Main.rand.Next(0, 3);
                            int randRotation = Main.rand.Next(0, 45);
                            if (attackSelect < 1)
                            {
                                BossMethods.ShootRing(16, ProjectileID.DeathLaser, 8f, 5f, npc.damage / 6, npc, randRotation);
                            }
                            else if (attackSelect < 2)
                            {
                                BossMethods.ShootRing(12, ProjectileID.DeathLaser, 8f, 5f, npc.damage / 5, npc, randRotation);
                            }
                            else
                            {
                                BossMethods.ShootRing(8, ProjectileID.DeathLaser, 8f, 5f, npc.damage / 4, npc, randRotation);
                            }
                        }
                        if (ai % 20 == 0) {
                            if (Main.rand.Next(0, 2) < 1) {
                                BossMethods.ShootAt(player, npc, ProjectileID.DeathLaser, 8f, 5f, npc.damage / 4, Main.expertMode ? 1 : 3);
                            }
                        }
                    }
                    else {
                        chaseTimer = 0;
                    }
                    
                }
            }
        }       
    }
}

