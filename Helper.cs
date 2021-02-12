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
        
        public bool Validate(int[] array, int a) {
            if (array.Contains(a))
            {
                return false;
            }
            else {
                return true;
            }
        }
        public rg(Mod m, String Name, String a1, String a2)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2) };
            if (Validate(arr, 0) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[]{ItemID.IronBar });
            }

        }
        public rg(Mod m, String Name, String a1, String a2, String a3)
        {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3)};
            if (Validate(arr, 0) == true)
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
            if (Validate(arr, 0) == true)
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
            if (Validate(arr, 0) == true)
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
            if (Validate(arr, 0) == true)
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
            if (Validate(arr, 0) == true)
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
            if (Validate(arr, 0) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            else
            {
                _RecipeGroup = new RecipeGroup(() => "Recipe Group Error", new int[] { ItemID.IronBar });
            }

        }
    }
}
