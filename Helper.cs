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
        
        public bool Validate(int[] array) {
            if (array.Contains(0) == false)
            {
                return true;
            }
            else {
                return false;
            }
        }
        public rg(Mod m, String Name, String a1, String a2)
        {
            //if (m.ItemType(a1) != 0 && m.ItemType(a2) != 0)
           // {
            int[] arr = { m.ItemType(a1), m.ItemType(a2) };
            if (Validate(arr) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
           // }
          //  else
           // {

           // }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3)
        {
            //  if (m.ItemType(a1) != 0 && m.ItemType(a2) != 0 && m.ItemType(a3) != 0)
            //   {

            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3)};
            if (Validate(arr) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
           // }
           // else
           // {

            //}
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4)
        {
           // if (m.ItemType(a1) != 0 && m.ItemType(a2) != 0 && m.ItemType(a3) != 0 && m.ItemType(a4) != 0)
           // {
            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4) };
            if (Validate(arr) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
          //  }
           // else
         //   {

          //  }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5)
        {
           // if (m.ItemType(a1) != 0 && m.ItemType(a2) != 0 && m.ItemType(a3) != 0 && m.ItemType(a4) != 0 && m.ItemType(a5) != 0)
          //  {
            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5) };
            if (Validate(arr) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
           // }
          //  else
          //  {

          //  }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5, String a6)
        {
           // if (m.ItemType(a1) != 0 && m.ItemType(a2) != 0 && m.ItemType(a3) != 0 && m.ItemType(a4) != 0 && m.ItemType(a5) != 0 && m.ItemType(a6) != 0)
          //  {
            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5), m.ItemType(a6) };
            if (Validate(arr) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
           // }
           // else
           // {

           // }
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5, String a6, String a7)
        {
           // if (m.ItemType(a1) != 0 && m.ItemType(a2) != 0 && m.ItemType(a3) != 0 && m.ItemType(a4) != 0 && m.ItemType(a5) != 0 && m.ItemType(a6) != 0 && m.ItemType(a7) != 0)
           // {
            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5), m.ItemType(a6), m.ItemType(a7) };
            if (Validate(arr) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
            //}
          //  else
           // {

            //}
        }
        public rg(Mod m, String Name, String a1, String a2, String a3, String a4, String a5, String a6, String a7, String a8)
        {
           // if (m.ItemType(a1) != 0 && m.ItemType(a2) != 0 && m.ItemType(a3) != 0 && m.ItemType(a4) != 0 && m.ItemType(a5) != 0 && m.ItemType(a6) != 0 && m.ItemType(a7) != 0 && m.ItemType(a8) != 0)
           // {
            int[] arr = { m.ItemType(a1), m.ItemType(a2), m.ItemType(a3), m.ItemType(a4), m.ItemType(a5), m.ItemType(a6), m.ItemType(a7), m.ItemType(a8) };
            if (Validate(arr) == true)
            {
                _RecipeGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Name + " Weapon", arr);
            }
           // }
          //  else
            //{

           // }

        }
    }
}
