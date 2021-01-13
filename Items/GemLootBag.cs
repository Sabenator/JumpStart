using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;
using System.Collections.Generic;


namespace JumpStart.Items
{
	public class GemLootBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gemstone Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}\nCan Contain a Multitude of Gemstones.");
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
		static Mod ThoriumMod => ModLoader.GetMod("ThoriumMod");
		public override void OnConsumeItem(Player player)
		{
			List<int> gemstones = new List<int>();

			gemstones.Add(ItemID.Amber);
			gemstones.Add(ItemID.Diamond);
			gemstones.Add(ItemID.Topaz);
			gemstones.Add(ItemID.Ruby);
			gemstones.Add(ItemID.Sapphire);
			gemstones.Add(ItemID.Emerald);
			gemstones.Add(ItemID.Amethyst);
			if (ThoriumMod != null) {
				gemstones.Add(ThoriumMod.ItemType("Opal"));
				gemstones.Add(ThoriumMod.ItemType("Onyx"));
				gemstones.Add(ThoriumMod.ItemType("Pearl"));
			}
			int[] gemstonearray = gemstones.ToArray();

			player.QuickSpawnItem(gemstonearray[Main.rand.Next(gemstonearray.Length - 1)], Main.rand.Next(4));
			player.QuickSpawnItem(gemstonearray[Main.rand.Next(gemstonearray.Length - 1)], Main.rand.Next(2, 6));
			player.QuickSpawnItem(gemstonearray[Main.rand.Next(gemstonearray.Length - 1)], Main.rand.Next(4, 8));
			player.QuickSpawnItem(gemstonearray[Main.rand.Next(2, gemstonearray.Length - 1)], Main.rand.Next(6, 10));

		}
		
	}
}
