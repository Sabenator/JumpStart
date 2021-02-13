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
    }
    public class ItemCheck {
        public int i;
        public ItemCheck(int a) {
            int i = a;
        }
        public int Validate() {
            if (i == 0)
            {
                return (ItemID.IronBar);
            }
            else
            {
                return i;
            }
        }
    }
}
