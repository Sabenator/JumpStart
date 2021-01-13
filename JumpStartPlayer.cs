using System;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;
using System.Collections.Generic;
using JumpStart.Items;

namespace JumpStart
{
	public class JumpStartPlayer : ModPlayer
	{
		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
		{
			if (mediumcoreDeath == true) {
				Item item1 = new Item();
				item1.SetDefaults(ItemID.IronBroadsword);
				item1.Prefix(-1);
				item1.stack = 1;
				items.Add(item1);
			}

			Item item2 = new Item();
			item2.SetDefaults(ModContent.ItemType<PrebossLootBag>());
			item2.Prefix(-1);
			item2.stack = 1;
			items.Add(item2);

		}


	}

}
