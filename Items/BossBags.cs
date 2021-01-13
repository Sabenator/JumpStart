using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AllTheMods.Items
{
	public class BossBags : GlobalItem
	{
		static Mod magicStorage => ModLoader.GetMod("MagicStorage");
		static Mod imkSushisMod => ModLoader.GetMod("imkSushisMod");
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "bossBag" && arg == ItemID.KingSlimeBossBag && magicStorage != null)
			{
				int a = Main.rand.Next(6);
				player.QuickSpawnItem(magicStorage.ItemType("StorageUnit"), Main.rand.Next(4, 12));
				player.QuickSpawnItem(magicStorage.ItemType("StorageHeart"), 1);
				if (a == 0)
				{
					player.QuickSpawnItem(magicStorage.ItemType("CraftingAccess"), 1);
				}
				else if (a == 1)
				{
					player.QuickSpawnItem(magicStorage.ItemType("StorageAccess"), 1);
				}
				else if (a == 2)
				{
					player.QuickSpawnItem(magicStorage.ItemType("CraftingAccess"), 1);
					player.QuickSpawnItem(magicStorage.ItemType("StorageAccess"), 1);
				}
				else if (a == 3)
				{
					player.QuickSpawnItem(magicStorage.ItemType("CraftingAccess"), 1);
					player.QuickSpawnItem(magicStorage.ItemType("StorageAccess"), 1);
					player.QuickSpawnItem(magicStorage.ItemType("StorageUnit"), Main.rand.Next(2, 6));
				}
				else
				{
					player.QuickSpawnItem(ItemID.Diamond, Main.rand.Next(13, 20));
					player.QuickSpawnItem(magicStorage.ItemType("StorageComponent"), Main.rand.Next(4, 8));
				}

			}
			if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag && magicStorage != null)
			{

				if (WorldGen.crimson) {
					player.QuickSpawnItem(magicStorage.ItemType("UpgradeCrimtane"), Main.rand.Next(4, 9));
					
				}
				if (!WorldGen.crimson)
				{
					player.QuickSpawnItem(magicStorage.ItemType("UpgradeDemonite"), Main.rand.Next(4, 9));
				}
			}
			if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag && imkSushisMod != null)
			{
                    player.QuickSpawnItem(imkSushisMod.ItemType("MeteoritePotion"), 1);
			}
		}

	}
}