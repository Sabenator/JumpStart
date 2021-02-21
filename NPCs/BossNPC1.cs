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
    
    class BossNPC1 : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boss1NPC");
            Main.npcFrameCount[npc.type] = 10;
        }
        public override void SetDefaults()
        {
            npc.boss = false;
            npc.damage = 50;
            npc.defense = 30;
            npc.lifeMax = 500;
            npc.height = 18;
            npc.width = 10;
            npc.knockBackResist = 0.1f;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.scale = 2f;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath3;
            npc.aiStyle = -1;
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = npc.lifeMax + 500;
            npc.damage = (int)(npc.damage * 0.4f);
        }
        public int counter = 0;
        public bool BossDowned = false;
        public override void AI()
        {
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];
            counter++;
            if (counter % 300 == 10) {

                BossMethods.ShootAt(player, npc, ProjectileID.DeathLaser, 8f, 2f, npc.damage / 5, Main.expertMode ? 1 : 3);
            }
            BossMethods.MoveToward(npc, player.Center, 5f, 40f);
            if (BossDowned == true) {
                npc.life = 0;
            }
            if (npc.velocity.X < 0) { 
            }
        }
        public override void FindFrame(int frameHeight)
        {
            npc.spriteDirection = npc.direction;
            if (counter % 300 > 10 || counter % 300 < 2)
            {
                npc.frame.Y = 0;
            }
            else {
                npc.frame.Y = frameHeight * ((counter - 1) % 300);
            }
        }

        public override void ReceiveExtraAI(BinaryReader reader)
        {
            BossDowned = reader.ReadBoolean();
        }
    }
}
