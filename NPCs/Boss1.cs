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
    [AutoloadBossHead]
    class Boss1 : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boss1");

        }
        public override void SetDefaults()
        {
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath3;
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
            npc.scale = 2f;

        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax + 100000) + ((numPlayers - 1) * 50000);
            npc.damage = (int)(npc.damage * 0.4f);
        }

        public bool stunned = false;
        public int stunCoolDown = 0;
        public int ai = 0;
        public bool dash = false;
        public Vector2 target;
        public Vector2 start;
        public int dashCounter = 0;
        public Vector2 targetFixed;
        public int chaseTimer = 0;
        public bool right = false;
        public int spiralRotation = 0;
        public bool dontDamage = false;
        Random rand = new Random();


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
        }
           
        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }

        public override bool StrikeNPC(ref double damage, int defense, ref float knockback, int hitDirection, ref bool crit)
        {
            if (dontDamage)
            {
                damage = 0;
                crit = true;
                dontDamage = false;
                Main.PlaySound(npc.HitSound, npc.position);
                return false;
            }
            return true;
        }

        public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            if (Main.expertMode || Main.rand.NextBool())
            {
                player.AddBuff(BuffID.Bleeding, 300, true);
            }
        }
        public override void SendExtraAI(BinaryWriter writer)
        {
            writer.Write((npc.life < npc.lifeMax * 0.1f) ? true : false);
        }
    }
}

