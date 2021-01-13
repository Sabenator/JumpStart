using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;
using System.Collections.Generic;

namespace JumpStart.Items
{
	public class PrebossLootBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pre-Boss Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}\nContains some gear to get you off to a faster start.");
		}
		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Purple;
			item.expert = true;
		}
		public override bool CanRightClick()
		{
			return true;
		}
		static Mod calamityMod => ModLoader.GetMod("CalamityMod");
		static Mod imkSushisMod => ModLoader.GetMod("imkSushisMod");
		public override void OnConsumeItem(Player player)
		{
			player.QuickSpawnItem(ItemID.IronPickaxe);
			player.QuickSpawnItem(ItemID.IronAxe);
			player.QuickSpawnItem(ItemID.LesserHealingPotion, 10);
			player.QuickSpawnItem(ItemID.Bomb, 10);
			player.QuickSpawnItem(ItemID.WoodenArrow, 100);
			player.QuickSpawnItem(ItemID.Torch, 50);

			if (Main.expertMode)
			{
				player.QuickSpawnItem(ItemID.SpelunkerPotion, 2);
				player.QuickSpawnItem(ItemID.CloudinaBottle);
				player.QuickSpawnItem(ItemID.HermesBoots);
				player.QuickSpawnItem(ItemID.GrapplingHook);
				player.QuickSpawnItem(ItemID.RecallPotion, 3);
				player.QuickSpawnItem(ItemID.ManaCrystal);
				player.QuickSpawnItem(ItemID.CopperBow);

				if (calamityMod == null)
				{
					player.QuickSpawnItem(ItemID.AmethystStaff);
					player.QuickSpawnItem(ItemID.SlimeCrown);
				}

			}
		}
	}
}