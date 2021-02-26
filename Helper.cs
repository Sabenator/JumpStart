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
    public class rg
    {
        public bool valid = false;
        public RecipeGroup _RecipeGroup = null;
        
        public rg(Mod m, String Name, String a1, String a2)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2) };
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error in " + Name, new int[]{ItemID.IronBar });
            }

        }
        public rg(Mod m, String Name, String a1, String a2, String a3)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3)};
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4) };
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5) };
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5, String a6)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5), m.ItemType(a6) };
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5, String a6, String a7)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5), m.ItemType(a6), m.ItemType(a7) };
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5, String a6, String a7, String a8)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5), m.ItemType(a6), m.ItemType(a7), m.ItemType(a8) };
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }

        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5, String a6, String a7, String a8, String a9)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5), m.ItemType(a6), m.ItemType(a7), m.ItemType(a8), m.ItemType(a9) };
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }

        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5, String a6, String a7, String a8, String a9, String a10)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5), m.ItemType(a6), m.ItemType(a7), m.ItemType(a8), m.ItemType(a9), m.ItemType(a10)};
            if (arr.Contains(0) == false)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }

        }
    }
    public class ItemCheck {
        public int b;
        public ItemCheck(int a) {
            b = a;
        }
        public int Validate() {
            int i = b;
            if (i == 0)
            {
                return (ItemID.IronBar);
            }
            else
            {
                return b;
            }
        }
    }
    public class BossMethods {
        public static void MoveToward(NPC npc, Vector2 playerTarget, float speed, float turnResistance)
        {
            Vector2 move = playerTarget - npc.Center;
            float length = move.Length();
            if (length > speed) {
                move *= speed / length;
            }
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            length = move.Length();
            if (length > speed) {
                move *= speed / length;
            }
            npc.velocity = move;
        }
        public static void DashToward(Vector2 npcStart, Vector2 playerTarget, float speed, NPC npc)
        {
            Vector2 move = playerTarget - npcStart;
            if (move.Length() < 0.9f * speed) {
            } else if (move.Length() > speed) 
            { 
                move *= speed / move.Length();
            }
            npc.velocity = move;
        }
        public static void ShootRing(int count, int type, float velocity, float kb, int damage, Vector2 pos) {
            for (int i = 0; i < count; i++) {
                Projectile.NewProjectile(pos, new Vector2(velocity, 0).RotatedBy(MathHelper.ToRadians((360 / count) * i)), type, damage, kb);
            }
        }
        public static void ShootRing(int count, int type, float velocity, float kb, int damage, Vector2 pos, int initRotation)
        {
            for (int i = 0; i < count; i++)
            {
                Projectile.NewProjectile(pos, new Vector2(velocity, 0).RotatedBy(MathHelper.ToRadians(initRotation)).RotatedBy(MathHelper.ToRadians((360 / count) * i)), type, damage, kb);
            }
        }
        public static void ShootAt(Player player, NPC npc, int type, float velocity, float kb, int damage, int inaccuracy) {
            Vector2 angle = player.Center - npc.Center;
            angle.Normalize();
            int rotation = Main.rand.Next(-inaccuracy, inaccuracy);
            angle.RotatedBy(MathHelper.ToRadians(rotation));
            Projectile.NewProjectile(npc.Center, velocity * angle, type, damage, kb);
        }
    }
}
