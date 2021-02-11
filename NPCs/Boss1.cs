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
        private int tpCoordX;
        private int tpCoordY;


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
                if (npc.life > npc.lifeMax * 0.75 && timer % 360 == 0) {
                    int tpCoordX = Main.rand.Next(0, 480);
                    int tpCoordY = Main.rand.Next(0, 1000);

                    NPC.NewNPC(tpCoordX, tpCoordY, mod.NPCType("Boss1Marker"),0, 0, 0, 0);
                
                }
            }





            timer++;
            }
        }
    }

