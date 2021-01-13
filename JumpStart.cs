using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;
using System.Collections.Generic;

namespace JumpStart
{
	public class JumpStart : Mod
	{
		static Mod magicStorage => ModLoader.GetMod("MagicStorage");
		static Mod calamityMod => ModLoader.GetMod("CalamityMod");
		static Mod imkSushisMod => ModLoader.GetMod("imkSushisMod");



		Mod thoriumMod = ModLoader.GetMod("ThoriumMod");
		public override void AddRecipeGroups()
		{


			RecipeGroup lunarFragments = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Lunar Fragments", new int[]
			{
				ItemID.FragmentNebula,
				ItemID.FragmentSolar,
				ItemID.FragmentVortex,
				ItemID.FragmentStardust
			});
			RecipeGroup.RegisterGroup("JumpStart:LunarFragments", lunarFragments);


			if (calamityMod != null)
			{
				/** RecipeGroup Crabulon = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Crabulon Weapon", new int[] {

				});
				RecipeGroup.RegisterGroup("JumpStart:Crabulon", Crabulon); **/




				RecipeGroup DesertScourge = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Desert Scourge Weapon", new int[]
				{
					calamityMod.ItemType("SeaboundStaff"),
					calamityMod.ItemType("Barinade"),
					calamityMod.ItemType("StormSpray"),
					calamityMod.ItemType("AquaticDischarge"),
					calamityMod.ItemType("ScourgeoftheDesert")
				});
				RecipeGroup.RegisterGroup("JumpStart:DesertScourge", DesertScourge);

				RecipeGroup Crabulon = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Crabulon Weapon", new int[] {
					calamityMod.ItemType("Mycoroot"),
					calamityMod.ItemType("HyphaeRod"),
					calamityMod.ItemType("MycelialClaws"),
					calamityMod.ItemType("Fungicide")
				});
				RecipeGroup.RegisterGroup("JumpStart:Crabulon", Crabulon);

				RecipeGroup HiveMind = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Hive Mind Weapon", new int[] {
					calamityMod.ItemType("ShaderainStaff"),
					calamityMod.ItemType("LeechingDagger"),
					calamityMod.ItemType("PerfectDark"),
					calamityMod.ItemType("Shadethrower"),
					calamityMod.ItemType("ShadowdropStaff"),
					calamityMod.ItemType("DankStaff")
				});
				RecipeGroup.RegisterGroup("JumpStart:HiveMind", HiveMind);

				RecipeGroup Perforators = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Perforator Weapon", new int[] {
					calamityMod.ItemType("Aorta"),
					calamityMod.ItemType("SausageMaker"),
					calamityMod.ItemType("BloodyRupture"),
					calamityMod.ItemType("BloodBath"),
					calamityMod.ItemType("VeinBuster"),
					calamityMod.ItemType("Eviscerator"),
					calamityMod.ItemType("BloodClotStaff")

				});
				RecipeGroup.RegisterGroup("JumpStart:Perforators", Perforators);

				RecipeGroup SlimeGod = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Slime God Weapon", new int[] {
					calamityMod.ItemType("OverloadedBlaster"),
					calamityMod.ItemType("AbyssalTome"),
					calamityMod.ItemType("EldritchTome"),
					calamityMod.ItemType("CrimslimeStaff"),
					calamityMod.ItemType("CorroslimeStaff")
				});
				RecipeGroup.RegisterGroup("JumpStart:SlimeGod", SlimeGod);

				RecipeGroup Cryogen = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cryogen Weapon", new int[] {
					calamityMod.ItemType("BittercoldStaff"),
					calamityMod.ItemType("EffluviumBow"),
					calamityMod.ItemType("GlacialCrusher"),
					calamityMod.ItemType("Icebreaker"),
					calamityMod.ItemType("Avalanche"),
					calamityMod.ItemType("SnowstormStaff")
				});
				RecipeGroup.RegisterGroup("JumpStart:Cryogen", Cryogen);

				RecipeGroup AquaticScourge = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Aquatic Scourge Weapon", new int[] {
					calamityMod.ItemType("SubmarineShocker"),
					calamityMod.ItemType("Barinautical"),
					calamityMod.ItemType("Downpour"),
					calamityMod.ItemType("DeepseaStaff"),
					calamityMod.ItemType("ScourgeOfTheSeas")
				});
				RecipeGroup.RegisterGroup("JumpStart:AquaticScourge", AquaticScourge);

				RecipeGroup BrimstoneElemental = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Brimstone Elemental Weapon", new int[] {
					calamityMod.ItemType("Abaddon"),
					calamityMod.ItemType("Brimlance"),
					calamityMod.ItemType("SeethingDischarge"),
					calamityMod.ItemType("DormantBrimseeker")
				});
				RecipeGroup.RegisterGroup("JumpStart:BrimstoneElemental", BrimstoneElemental);

				RecipeGroup Calamitas = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Calamitas Weapon", new int[] {
					calamityMod.ItemType("Animosity"),
					calamityMod.ItemType("CalamitasInferno"),
					calamityMod.ItemType("TheEyeofCalamitas"),
					calamityMod.ItemType("BlightedEyeStaff")
				});
				RecipeGroup.RegisterGroup("JumpStart:Calamitas", Calamitas);

				RecipeGroup Leviathan = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") +"Leviathan Weapon", new int[] {
					calamityMod.ItemType("SirensSong"),
					calamityMod.ItemType("Atlantis"),
					calamityMod.ItemType("BrackishFlask"),
					calamityMod.ItemType("GastricBelcherStaff"),
					calamityMod.ItemType("LeviathanTeeth"),
					calamityMod.ItemType("Leviatitan")
				});
				RecipeGroup.RegisterGroup("JumpStart:Leviathan", Leviathan);

				RecipeGroup AstrumAureus = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Astrum Aureus Weapon", new int[] {
					calamityMod.ItemType("AlulaAustralis"),
					calamityMod.ItemType("AuroraBlazer"),
					calamityMod.ItemType("AuroradicalThrow"),
					calamityMod.ItemType("BorealisBomber"),
					calamityMod.ItemType("Nebulash")
				});
				RecipeGroup.RegisterGroup("JumpStart:AstrumAureus", AstrumAureus);

				RecipeGroup PlaguebringerGoliath = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Plaguebringer Goliath Weapon", new int[] {
					calamityMod.ItemType("TheHive"),
					calamityMod.ItemType("BlightSpewer"),
					calamityMod.ItemType("FuelCellBundle"),
					calamityMod.ItemType("Malevolence"),
					calamityMod.ItemType("InfectedRemote"),
					calamityMod.ItemType("Virulence"),
					calamityMod.ItemType("DiseasedPike"),
					calamityMod.ItemType("PlagueStaff"),
					calamityMod.ItemType("PestilentDefiler"),
					calamityMod.ItemType("ThePlagueBringer"),
					calamityMod.ItemType("TheSyringe")
				});
				RecipeGroup.RegisterGroup("JumpStart:PlaguebringerGoliath", PlaguebringerGoliath);

				RecipeGroup Ravager = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Ravager Weapon", new int[] {
					calamityMod.ItemType("UltimusCleaver"),
					calamityMod.ItemType("RealmRavage"),
					calamityMod.ItemType("Hematemesis"),
					calamityMod.ItemType("SpikecragStaff"),
					calamityMod.ItemType("CraniumSmasher")
				});
				RecipeGroup.RegisterGroup("JumpStart:Ravager", Ravager);

				RecipeGroup AstrumDeus = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Astrum Deus Weapon", new int[] {
					calamityMod.ItemType("TheMicrowave"),
					calamityMod.ItemType("StarSputter"),
					calamityMod.ItemType("Starfall"),
					calamityMod.ItemType("GodspawnHelixStaff"),
					calamityMod.ItemType("RegulusRiot")
				});
				RecipeGroup.RegisterGroup("JumpStart:AstrumDeus", AstrumDeus);

				RecipeGroup Dragonfolly = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Dragonfolly Weapon", new int[] {
					calamityMod.ItemType("RougeSlash"),
					calamityMod.ItemType("GildedProboscis"),
					calamityMod.ItemType("GoldenEagle")
				});
				RecipeGroup.RegisterGroup("JumpStart:Dragonfolly", Dragonfolly);

				RecipeGroup Providence = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Providence Weapon", new int[] {
					calamityMod.ItemType("BlissfulBombardier"),
					calamityMod.ItemType("DazzlingStabberStaff"),
					calamityMod.ItemType("HolyCollider"),
					calamityMod.ItemType("MoltenAmputator"),
					calamityMod.ItemType("PurgeGuzzler"),
					calamityMod.ItemType("TelluricGlare"),
					calamityMod.ItemType("SolarFlare")
				});
				RecipeGroup.RegisterGroup("JumpStart:Providence", Providence);

				RecipeGroup Polterghast = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Polterghast Weapon", new int[] {
					calamityMod.ItemType("BansheeHook"),
					calamityMod.ItemType("DaemonsFlare"),
					calamityMod.ItemType("EtherealSujugator"),
					calamityMod.ItemType("FatesReveal"),
					calamityMod.ItemType("GhastlyVisage"),
					calamityMod.ItemType("GhoulishGouger"),
					calamityMod.ItemType("TerrorBlade")
				});
				RecipeGroup.RegisterGroup("JumpStart:Polterghast", Polterghast);

				RecipeGroup OldDuke = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Old Duke Weapon", new int[] {
					calamityMod.ItemType("InsidiousImpaler"),
					calamityMod.ItemType("FetidEmesis"),
					calamityMod.ItemType("SepticSkewer"),
					calamityMod.ItemType("VitriolicViper"),
					calamityMod.ItemType("CadaverousCarrion"),
					calamityMod.ItemType("ToxicantTwister")
				});
				RecipeGroup.RegisterGroup("JumpStart:OldDuke", OldDuke);

				RecipeGroup DOG = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Devourer of Gods Weapon", new int[] {
					calamityMod.ItemType("Excelsus"),
					calamityMod.ItemType("TheObliterator"),
					calamityMod.ItemType("DeathhailStaff"),
					calamityMod.ItemType("Eradicator"),
					calamityMod.ItemType("Deathwind"),
					calamityMod.ItemType("StaffOfTheMechworm")
				});
				RecipeGroup.RegisterGroup("JumpStart:DOG", DOG);

				RecipeGroup Yharon = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Jungle Dragon Yharon Weapon", new int[] {
					calamityMod.ItemType("YharonsKindleStaff"),
					calamityMod.ItemType("TheFinalDawn"),
					calamityMod.ItemType("DragonsBreath"),
					calamityMod.ItemType("PhoenixFlameBarrage"),
					calamityMod.ItemType("TheBurningSky"),
					calamityMod.ItemType("InfernalSpear"),
					calamityMod.ItemType("DragonRage"),
					calamityMod.ItemType("ChickenCannon")
				});
				RecipeGroup.RegisterGroup("JumpStart:Yharon", Yharon);

				RecipeGroup SupremeCalamitas = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Supreme Calamitas Weapon", new int[] {
					calamityMod.ItemType("Animus"),
					calamityMod.ItemType("Azathoth"),
					calamityMod.ItemType("Contagion"),
					calamityMod.ItemType("CrystylCrusher"),
					calamityMod.ItemType("TheDanceOfLight"),
					calamityMod.ItemType("DraconicDestruction"),
					calamityMod.ItemType("Earth"),
					calamityMod.ItemType("EndoGenesis"),
					calamityMod.ItemType("Fabstaff"),
					calamityMod.ItemType("FlamsteedRing"),
					calamityMod.ItemType("IllustriousKnives"),
					calamityMod.ItemType("NanoblackReaper"),
					calamityMod.ItemType("RedSun"),
					calamityMod.ItemType("Voidragon"),
					calamityMod.ItemType("ScarletDevil"),
					calamityMod.ItemType("SomaPrime"),
					calamityMod.ItemType("BlushieStaff"),
					calamityMod.ItemType("Svantechnical"),
					calamityMod.ItemType("TemporalUmbrella"),
					calamityMod.ItemType("TriactisTruePaladinianMageHammerOfMight")
				});
				RecipeGroup.RegisterGroup("JumpStart:SupremeCalamitas", SupremeCalamitas);
			}














			List<int> preHardModeBarsList = new List<int>();

			preHardModeBarsList.Add(ItemID.CopperBar);
			preHardModeBarsList.Add(ItemID.TinBar);
			preHardModeBarsList.Add(ItemID.IronBar);
			preHardModeBarsList.Add(ItemID.LeadBar);
			preHardModeBarsList.Add(ItemID.SilverBar);
			preHardModeBarsList.Add(ItemID.TungstenBar);
			preHardModeBarsList.Add(ItemID.GoldBar);
			preHardModeBarsList.Add(ItemID.PlatinumBar);
			preHardModeBarsList.Add(ItemID.MeteoriteBar);
			preHardModeBarsList.Add(ItemID.DemoniteBar);
			preHardModeBarsList.Add(ItemID.CrimtaneBar);
			preHardModeBarsList.Add(ItemID.HellstoneBar);

			if (calamityMod != null)
			{
				preHardModeBarsList.Add(calamityMod.ItemType("SeaPrism"));
				preHardModeBarsList.Add(calamityMod.ItemType("AerialiteBar"));
				preHardModeBarsList.Add(calamityMod.ItemType("VictideBar"));
			}
			if (thoriumMod != null)
			{
				preHardModeBarsList.Add(thoriumMod.ItemType("SmoothCoal"));
				preHardModeBarsList.Add(thoriumMod.ItemType("LifeQuartz"));
				preHardModeBarsList.Add(thoriumMod.ItemType("ThoriumBar"));
				preHardModeBarsList.Add(thoriumMod.ItemType("MagmaBar"));
				preHardModeBarsList.Add(thoriumMod.ItemType("AquaiteBar"));
			}

			List<int> earlyHardModeBarsList = new List<int>();

			earlyHardModeBarsList.Add(ItemID.CobaltBar);
			earlyHardModeBarsList.Add(ItemID.PalladiumBar);
			earlyHardModeBarsList.Add(ItemID.MythrilBar);
			earlyHardModeBarsList.Add(ItemID.OrichalcumBar);
			earlyHardModeBarsList.Add(ItemID.TitaniumBar);
			earlyHardModeBarsList.Add(ItemID.AdamantiteBar);

			if (calamityMod != null)
			{
				earlyHardModeBarsList.Add(calamityMod.ItemType("CryonicBar"));
				earlyHardModeBarsList.Add(calamityMod.ItemType("UnholyCore"));
			}

			if (thoriumMod != null)
			{
				earlyHardModeBarsList.Add(thoriumMod.ItemType("LodeStoneIngot"));
				earlyHardModeBarsList.Add(thoriumMod.ItemType("ValadiumIngot"));
				earlyHardModeBarsList.Add(thoriumMod.ItemType("IllumiteIngot"));
			}



			RecipeGroup preHardmodeBars = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Pre-Hardmode Bars", preHardModeBarsList.ToArray());
			RecipeGroup HardmodeBars = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Pre-Hardmode Bars", earlyHardModeBarsList.ToArray());

		}
        public override void AddRecipes()
        {
			if (calamityMod != null && imkSushisMod != null) {

				//Desert Scourge
				ModRecipe DesertScourge1 = new ModRecipe(this);
				DesertScourge1.AddRecipeGroup("JumpStart:DesertScourge", 1);
				DesertScourge1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DesertScourge1.AddTile(TileID.TinkerersWorkbench);
				DesertScourge1.SetResult(calamityMod.ItemType("SeaboundStaff"), 1);
				DesertScourge1.AddRecipe();

				ModRecipe DesertScourge2 = new ModRecipe(this);
				DesertScourge2.AddRecipeGroup("JumpStart:DesertScourge");
				DesertScourge2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DesertScourge2.AddTile(TileID.TinkerersWorkbench);
				DesertScourge2.SetResult(calamityMod.ItemType("Barinade"), 1);
				DesertScourge2.AddRecipe();

				ModRecipe DesertScourge3 = new ModRecipe(this);
				DesertScourge3.AddRecipeGroup("JumpStart:DesertScourge", 1);
				DesertScourge3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DesertScourge3.AddTile(TileID.TinkerersWorkbench);
				DesertScourge3.SetResult(calamityMod.ItemType("StormSpray"), 1);
				DesertScourge3.AddRecipe();

				ModRecipe DesertScourge4 = new ModRecipe(this);
				DesertScourge4.AddRecipeGroup("JumpStart:DesertScourge", 1);
				DesertScourge4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DesertScourge4.AddTile(TileID.TinkerersWorkbench);
				DesertScourge4.SetResult(calamityMod.ItemType("AquaticDischarge"), 1);
				DesertScourge4.AddRecipe();

				ModRecipe DesertScourge5 = new ModRecipe(this);
				DesertScourge5.AddRecipeGroup("JumpStart:DesertScourge", 1);
				DesertScourge5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DesertScourge5.AddTile(TileID.TinkerersWorkbench);
				DesertScourge5.SetResult(calamityMod.ItemType("ScourgeoftheDesert"), 1);
				DesertScourge5.AddRecipe();

				//Crabulon
				ModRecipe Crabulon1 = new ModRecipe(this);
				Crabulon1.AddRecipeGroup("JumpStart:Crabulon", 1);
				Crabulon1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Crabulon1.AddTile(TileID.TinkerersWorkbench);
				Crabulon1.SetResult(calamityMod.ItemType("Mycoroot"), 1);
				Crabulon1.AddRecipe();

				ModRecipe Crabulon2 = new ModRecipe(this);
				Crabulon2.AddRecipeGroup("JumpStart:Crabulon", 1);
				Crabulon2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Crabulon2.AddTile(TileID.TinkerersWorkbench);
				Crabulon2.SetResult(calamityMod.ItemType("HyphaeRod"), 1);
				Crabulon2.AddRecipe();

				ModRecipe Crabulon3 = new ModRecipe(this);
				Crabulon3.AddRecipeGroup("JumpStart:Crabulon", 1);
				Crabulon3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Crabulon3.AddTile(TileID.TinkerersWorkbench);
				Crabulon3.SetResult(calamityMod.ItemType("MycelialClaws"), 1);
				Crabulon3.AddRecipe();

				ModRecipe Crabulon4 = new ModRecipe(this);
				Crabulon4.AddRecipeGroup("JumpStart:Crabulon", 1);
				Crabulon4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Crabulon4.AddTile(TileID.TinkerersWorkbench);
				Crabulon4.SetResult(calamityMod.ItemType("Fungicide"), 1);
				Crabulon4.AddRecipe();

				//Hive Mind
				ModRecipe HiveMind1 = new ModRecipe(this);
				HiveMind1.AddRecipeGroup("JumpStart:HiveMind", 1);
				HiveMind1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				HiveMind1.AddTile(TileID.TinkerersWorkbench);
				HiveMind1.SetResult(calamityMod.ItemType("ShaderainStaff"), 1);
				HiveMind1.AddRecipe();

				ModRecipe HiveMind2 = new ModRecipe(this);
				HiveMind2.AddRecipeGroup("JumpStart:HiveMind", 1);
				HiveMind2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				HiveMind2.AddTile(TileID.TinkerersWorkbench);
				HiveMind2.SetResult(calamityMod.ItemType("LeechingDagger"), 1);
				HiveMind2.AddRecipe();

				ModRecipe HiveMind3 = new ModRecipe(this);
				HiveMind3.AddRecipeGroup("JumpStart:HiveMind", 1);
				HiveMind3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				HiveMind3.AddTile(TileID.TinkerersWorkbench);
				HiveMind3.SetResult(calamityMod.ItemType("PerfectDark"), 1);
				HiveMind3.AddRecipe();

				ModRecipe HiveMind4 = new ModRecipe(this);
				HiveMind4.AddRecipeGroup("JumpStart:HiveMind", 1);
				HiveMind4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				HiveMind4.AddTile(TileID.TinkerersWorkbench);
				HiveMind4.SetResult(calamityMod.ItemType("Shadethrower"), 1);
				HiveMind4.AddRecipe();

				ModRecipe HiveMind5 = new ModRecipe(this);
				HiveMind5.AddRecipeGroup("JumpStart:HiveMind", 1);
				HiveMind5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				HiveMind5.AddTile(TileID.TinkerersWorkbench);
				HiveMind5.SetResult(calamityMod.ItemType("ShadowdropStaff"), 1);
				HiveMind5.AddRecipe();

				ModRecipe HiveMind6 = new ModRecipe(this);
				HiveMind6.AddRecipeGroup("JumpStart:HiveMind", 1);
				HiveMind6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				HiveMind6.AddTile(TileID.TinkerersWorkbench);
				HiveMind6.SetResult(calamityMod.ItemType("DankStaff"), 1);
				HiveMind6.AddRecipe();

				ModRecipe HiveMind7 = new ModRecipe(this);
				HiveMind7.AddRecipeGroup("JumpStart:HiveMind", 1);
				HiveMind7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				HiveMind7.AddTile(TileID.TinkerersWorkbench);
				HiveMind7.SetResult(calamityMod.ItemType("LeechingDagger"), 1);
				HiveMind7.AddRecipe();

				//Perforators
				ModRecipe Perforators1 = new ModRecipe(this);
				Perforators1.AddRecipeGroup("JumpStart:Perforators", 1);
				Perforators1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Perforators1.AddTile(TileID.TinkerersWorkbench);
				Perforators1.SetResult(calamityMod.ItemType("Aorta"), 1);
				Perforators1.AddRecipe();

				ModRecipe Perforators2 = new ModRecipe(this);
				Perforators2.AddRecipeGroup("JumpStart:Perforators", 1);
				Perforators2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Perforators2.AddTile(TileID.TinkerersWorkbench);
				Perforators2.SetResult(calamityMod.ItemType("SausageMaker"), 1);
				Perforators2.AddRecipe();

				ModRecipe Perforators3 = new ModRecipe(this);
				Perforators3.AddRecipeGroup("JumpStart:Perforators", 1);
				Perforators3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Perforators3.AddTile(TileID.TinkerersWorkbench);
				Perforators3.SetResult(calamityMod.ItemType("BloodyRupture"), 1);
				Perforators3.AddRecipe();

				ModRecipe Perforators4 = new ModRecipe(this);
				Perforators4.AddRecipeGroup("JumpStart:Perforators", 1);
				Perforators4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Perforators4.AddTile(TileID.TinkerersWorkbench);
				Perforators4.SetResult(calamityMod.ItemType("BloodBath"), 1);
				Perforators4.AddRecipe();

				ModRecipe Perforators5 = new ModRecipe(this);
				Perforators5.AddRecipeGroup("JumpStart:Perforators", 1);
				Perforators5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Perforators5.AddTile(TileID.TinkerersWorkbench);
				Perforators5.SetResult(calamityMod.ItemType("VeinBurster"), 1);
				Perforators5.AddRecipe();

				ModRecipe Perforators6 = new ModRecipe(this);
				Perforators6.AddRecipeGroup("JumpStart:Perforators", 1);
				Perforators6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Perforators6.AddTile(TileID.TinkerersWorkbench);
				Perforators6.SetResult(calamityMod.ItemType("Eviscerator"), 1);
				Perforators6.AddRecipe();

				ModRecipe Perforators7 = new ModRecipe(this);
				Perforators7.AddRecipeGroup("JumpStart:Perforators", 1);
				Perforators7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Perforators7.AddTile(TileID.TinkerersWorkbench);
				Perforators7.SetResult(calamityMod.ItemType("BloodClotStaff"), 1);
				Perforators7.AddRecipe();

				//Slime God
				ModRecipe SlimeGod1 = new ModRecipe(this);
				SlimeGod1.AddRecipeGroup("JumpStart:SlimeGod", 1);
				SlimeGod1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				SlimeGod1.AddTile(TileID.TinkerersWorkbench);
				SlimeGod1.SetResult(calamityMod.ItemType("OverloadedBlaster"), 1);
				SlimeGod1.AddRecipe();

				ModRecipe SlimeGod2 = new ModRecipe(this);
				SlimeGod2.AddRecipeGroup("JumpStart:SlimeGod", 1);
				SlimeGod2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				SlimeGod2.AddTile(TileID.TinkerersWorkbench);
				SlimeGod2.SetResult(calamityMod.ItemType("AbyssalTome"), 1);
				SlimeGod2.AddRecipe();

				ModRecipe SlimeGod3 = new ModRecipe(this);
				SlimeGod3.AddRecipeGroup("JumpStart:SlimeGod", 1);
				SlimeGod3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				SlimeGod3.AddTile(TileID.TinkerersWorkbench);
				SlimeGod3.SetResult(calamityMod.ItemType("EldritchTome"), 1);
				SlimeGod3.AddRecipe();

				ModRecipe SlimeGod4 = new ModRecipe(this);
				SlimeGod4.AddRecipeGroup("JumpStart:SlimeGod", 1);
				SlimeGod4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				SlimeGod4.AddTile(TileID.TinkerersWorkbench);
				SlimeGod4.SetResult(calamityMod.ItemType("CrimslimeStaff"), 1);
				SlimeGod4.AddRecipe();

				ModRecipe SlimeGod5 = new ModRecipe(this);
				SlimeGod5.AddRecipeGroup("JumpStart:SlimeGod", 1);
				SlimeGod5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				SlimeGod5.AddTile(TileID.TinkerersWorkbench);
				SlimeGod5.SetResult(calamityMod.ItemType("CorroslimeStaff"), 1);
				SlimeGod5.AddRecipe();

				//Cryogen
				ModRecipe Cryogen1 = new ModRecipe(this);
				Cryogen1.AddRecipeGroup("JumpStart:Cryogen", 1);
				Cryogen1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Cryogen1.AddTile(TileID.TinkerersWorkbench);
				Cryogen1.SetResult(calamityMod.ItemType("BittercoldStaff"), 1);
				Cryogen1.AddRecipe();

				ModRecipe Cryogen2 = new ModRecipe(this);
				Cryogen2.AddRecipeGroup("JumpStart:Cryogen", 1);
				Cryogen2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Cryogen2.AddTile(TileID.TinkerersWorkbench);
				Cryogen2.SetResult(calamityMod.ItemType("EffluviumBow"), 1);
				Cryogen2.AddRecipe();

				ModRecipe Cryogen3 = new ModRecipe(this);
				Cryogen3.AddRecipeGroup("JumpStart:Cryogen", 1);
				Cryogen3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Cryogen3.AddTile(TileID.TinkerersWorkbench);
				Cryogen3.SetResult(calamityMod.ItemType("GlacialCrusher"), 1);
				Cryogen3.AddRecipe();

				ModRecipe Cryogen4 = new ModRecipe(this);
				Cryogen4.AddRecipeGroup("JumpStart:Cryogen", 1);
				Cryogen4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Cryogen4.AddTile(TileID.TinkerersWorkbench);
				Cryogen4.SetResult(calamityMod.ItemType("Icebreaker"), 1);
				Cryogen4.AddRecipe();

				ModRecipe Cryogen5 = new ModRecipe(this);
				Cryogen5.AddRecipeGroup("JumpStart:Cryogen", 1);
				Cryogen5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Cryogen5.AddTile(TileID.TinkerersWorkbench);
				Cryogen5.SetResult(calamityMod.ItemType("Avalanche"), 1);
				Cryogen5.AddRecipe();

				ModRecipe Cryogen6 = new ModRecipe(this);
				Cryogen6.AddRecipeGroup("JumpStart:Cryogen", 1);
				Cryogen6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Cryogen6.AddTile(TileID.TinkerersWorkbench);
				Cryogen6.SetResult(calamityMod.ItemType("SnowstormStaff"), 1);
				Cryogen6.AddRecipe();

				//Aquatic Scourge
				ModRecipe AquaticScourge1 = new ModRecipe(this);
				AquaticScourge1.AddRecipeGroup("JumpStart:AquaticScourge", 1);
				AquaticScourge1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AquaticScourge1.AddTile(TileID.TinkerersWorkbench);
				AquaticScourge1.SetResult(calamityMod.ItemType("SubmarineShocker"), 1);
				AquaticScourge1.AddRecipe();

				ModRecipe AquaticScourge2 = new ModRecipe(this);
				AquaticScourge2.AddRecipeGroup("JumpStart:AquaticScourge", 1);
				AquaticScourge2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AquaticScourge2.AddTile(TileID.TinkerersWorkbench);
				AquaticScourge2.SetResult(calamityMod.ItemType("Barinautical"), 1);
				AquaticScourge2.AddRecipe();

				ModRecipe AquaticScourge3 = new ModRecipe(this);
				AquaticScourge3.AddRecipeGroup("JumpStart:AquaticScourge", 1);
				AquaticScourge3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AquaticScourge3.AddTile(TileID.TinkerersWorkbench);
				AquaticScourge3.SetResult(calamityMod.ItemType("Downpour"), 1);
				AquaticScourge3.AddRecipe();

				ModRecipe AquaticScourge4 = new ModRecipe(this);
				AquaticScourge4.AddRecipeGroup("JumpStart:AquaticScourge", 1);
				AquaticScourge4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AquaticScourge4.AddTile(TileID.TinkerersWorkbench);
				AquaticScourge4.SetResult(calamityMod.ItemType("DeepseaStaff"), 1);
				AquaticScourge4.AddRecipe();

				ModRecipe AquaticScourge5 = new ModRecipe(this);
				AquaticScourge5.AddRecipeGroup("JumpStart:AquaticScourge", 1);
				AquaticScourge5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AquaticScourge5.AddTile(TileID.TinkerersWorkbench);
				AquaticScourge5.SetResult(calamityMod.ItemType("ScourgeoftheSeas"), 1);
				AquaticScourge5.AddRecipe();

				//Brimstone Elemental
				ModRecipe BrimstoneElemental1 = new ModRecipe(this);
				BrimstoneElemental1.AddRecipeGroup("JumpStart:BrimstoneElemental", 1);
				BrimstoneElemental1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BrimstoneElemental1.AddTile(TileID.TinkerersWorkbench);
				BrimstoneElemental1.SetResult(calamityMod.ItemType("Abaddon"), 1);
				BrimstoneElemental1.AddRecipe();

				ModRecipe BrimstoneElemental2 = new ModRecipe(this);
				BrimstoneElemental2.AddRecipeGroup("JumpStart:BrimstoneElemental", 1);
				BrimstoneElemental2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BrimstoneElemental2.AddTile(TileID.TinkerersWorkbench);
				BrimstoneElemental2.SetResult(calamityMod.ItemType("Brimlance"), 1);
				BrimstoneElemental2.AddRecipe();

				ModRecipe BrimstoneElemental3 = new ModRecipe(this);
				BrimstoneElemental3.AddRecipeGroup("JumpStart:BrimstoneElemental", 1);
				BrimstoneElemental3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BrimstoneElemental3.AddTile(TileID.TinkerersWorkbench);
				BrimstoneElemental3.SetResult(calamityMod.ItemType("SeethingDischarge"), 1);
				BrimstoneElemental3.AddRecipe();

				ModRecipe BrimstoneElemental4 = new ModRecipe(this);
				BrimstoneElemental4.AddRecipeGroup("JumpStart:BrimstoneElemental", 1);
				BrimstoneElemental4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BrimstoneElemental4.AddTile(TileID.TinkerersWorkbench);
				BrimstoneElemental4.SetResult(calamityMod.ItemType("DormantBrimseeker"), 1);
				BrimstoneElemental4.AddRecipe();

				//Calamitas

				ModRecipe Calamitas1 = new ModRecipe(this);
				Calamitas1.AddRecipeGroup("JumpStart:Calamitas", 1);
				Calamitas1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Calamitas1.AddTile(TileID.TinkerersWorkbench);
				Calamitas1.SetResult(calamityMod.ItemType("Animosity"), 1);
				Calamitas1.AddRecipe();

				ModRecipe Calamitas2 = new ModRecipe(this);
				Calamitas2.AddRecipeGroup("JumpStart:Calamitas", 1);
				Calamitas2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Calamitas2.AddTile(TileID.TinkerersWorkbench);
				Calamitas2.SetResult(calamityMod.ItemType("CalamitasInferno"), 1);
				Calamitas2.AddRecipe();

				ModRecipe Calamitas3 = new ModRecipe(this);
				Calamitas3.AddRecipeGroup("JumpStart:Calamitas", 1);
				Calamitas3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Calamitas3.AddTile(TileID.TinkerersWorkbench);
				Calamitas3.SetResult(calamityMod.ItemType("TheEyeofCalamitas"), 1);
				Calamitas3.AddRecipe();

				ModRecipe Calamitas4 = new ModRecipe(this);
				Calamitas4.AddRecipeGroup("JumpStart:Calamitas", 1);
				Calamitas4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Calamitas4.AddTile(TileID.TinkerersWorkbench);
				Calamitas4.SetResult(calamityMod.ItemType("BlightedEyeStaff"), 1);
				Calamitas4.AddRecipe();

				//Leviathan and Anahita
				ModRecipe Leviathan1 = new ModRecipe(this);
				Leviathan1.AddRecipeGroup("JumpStart:Leviathan", 1);
				Leviathan1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Leviathan1.AddTile(TileID.TinkerersWorkbench);
				Leviathan1.SetResult(calamityMod.ItemType("SirensSong"), 1);
				Leviathan1.AddRecipe();

				ModRecipe Leviathan2 = new ModRecipe(this);
				Leviathan2.AddRecipeGroup("JumpStart:Leviathan", 1);
				Leviathan2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Leviathan2.AddTile(TileID.TinkerersWorkbench);
				Leviathan2.SetResult(calamityMod.ItemType("Atlantis"), 1);
				Leviathan2.AddRecipe();

				ModRecipe Leviathan3 = new ModRecipe(this);
				Leviathan3.AddRecipeGroup("JumpStart:Leviathan", 1);
				Leviathan3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Leviathan3.AddTile(TileID.TinkerersWorkbench);
				Leviathan3.SetResult(calamityMod.ItemType("BrackishFlask"), 1);
				Leviathan3.AddRecipe();

				ModRecipe Leviathan4 = new ModRecipe(this);
				Leviathan4.AddRecipeGroup("JumpStart:Leviathan", 1);
				Leviathan4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Leviathan4.AddTile(TileID.TinkerersWorkbench);
				Leviathan4.SetResult(calamityMod.ItemType("GastricBelcherStaff"), 1);
				Leviathan4.AddRecipe();

				ModRecipe Leviathan5 = new ModRecipe(this);
				Leviathan5.AddRecipeGroup("JumpStart:Leviathan", 1);
				Leviathan5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Leviathan5.AddTile(TileID.TinkerersWorkbench);
				Leviathan5.SetResult(calamityMod.ItemType("Greentide"), 1);
				Leviathan5.AddRecipe();

				ModRecipe Leviathan6 = new ModRecipe(this);
				Leviathan6.AddRecipeGroup("JumpStart:Leviathan", 1);
				Leviathan6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Leviathan6.AddTile(TileID.TinkerersWorkbench);
				Leviathan6.SetResult(calamityMod.ItemType("LeviathanTeeth"), 1);
				Leviathan6.AddRecipe();

				ModRecipe Leviathan7 = new ModRecipe(this);
				Leviathan7.AddRecipeGroup("JumpStart:Leviathan", 1);
				Leviathan7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Leviathan7.AddTile(TileID.TinkerersWorkbench);
				Leviathan7.SetResult(calamityMod.ItemType("Leviatitan"), 1);
				Leviathan7.AddRecipe();

				//Astrum Aureus
				ModRecipe AstrumAureus1 = new ModRecipe(this);
				AstrumAureus1.AddRecipeGroup("JumpStart:AstrumAureus", 1);
				AstrumAureus1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumAureus1.AddTile(TileID.TinkerersWorkbench);
				AstrumAureus1.SetResult(calamityMod.ItemType("AlulaAustralis"), 1);
				AstrumAureus1.AddRecipe();

				ModRecipe AstrumAureus2 = new ModRecipe(this);
				AstrumAureus2.AddRecipeGroup("JumpStart:AstrumAureus", 1);
				AstrumAureus2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumAureus2.AddTile(TileID.TinkerersWorkbench);
				AstrumAureus2.SetResult(calamityMod.ItemType("AuroraBlazer"), 1);
				AstrumAureus2.AddRecipe();

				ModRecipe AstrumAureus3 = new ModRecipe(this);
				AstrumAureus3.AddRecipeGroup("JumpStart:AstrumAureus", 1);
				AstrumAureus3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumAureus3.AddTile(TileID.TinkerersWorkbench);
				AstrumAureus3.SetResult(calamityMod.ItemType("AuroradicalThrow"), 1);
				AstrumAureus3.AddRecipe();

				ModRecipe AstrumAureus4 = new ModRecipe(this);
				AstrumAureus4.AddRecipeGroup("JumpStart:AstrumAureus", 1);
				AstrumAureus4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumAureus4.AddTile(TileID.TinkerersWorkbench);
				AstrumAureus4.SetResult(calamityMod.ItemType("BorealisBomber"), 1);
				AstrumAureus4.AddRecipe();

				ModRecipe AstrumAureus5 = new ModRecipe(this);
				AstrumAureus5.AddRecipeGroup("JumpStart:AstrumAureus", 1);
				AstrumAureus5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumAureus5.AddTile(TileID.TinkerersWorkbench);
				AstrumAureus5.SetResult(calamityMod.ItemType("Nebulash"), 1);
				AstrumAureus5.AddRecipe();


				//The Plaguebringer Goliath
				ModRecipe PlaguebringerGoliath1 = new ModRecipe(this);
				PlaguebringerGoliath1.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath1.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath1.SetResult(calamityMod.ItemType("TheHive"), 1);
				PlaguebringerGoliath1.AddRecipe();

				ModRecipe PlaguebringerGoliath2 = new ModRecipe(this);
				PlaguebringerGoliath2.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath2.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath2.SetResult(calamityMod.ItemType("BlightSpewer"), 1);
				PlaguebringerGoliath2.AddRecipe();

			/**
				ModRecipe PlaguebringerGoliath3 = new ModRecipe(this);
				PlaguebringerGoliath3.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath3.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath3.SetResult(calamityMod.ItemType("FuelCellBundle"), 1);
				PlaguebringerGoliath3.AddRecipe();
				

				ModRecipe PlaguebringerGoliath4 = new ModRecipe(this);
				PlaguebringerGoliath4.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath4.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath4.SetResult(calamityMod.ItemType("Malevolence"), 1);
				PlaguebringerGoliath4.AddRecipe();

				ModRecipe PlaguebringerGoliath5 = new ModRecipe(this);
				PlaguebringerGoliath5.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath5.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath5.SetResult(calamityMod.ItemType("InfectedRemote"), 1);
				PlaguebringerGoliath5.AddRecipe();

				ModRecipe PlaguebringerGoliath6 = new ModRecipe(this);
				PlaguebringerGoliath6.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath6.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath6.SetResult(calamityMod.ItemType("Virulence"), 1);
				PlaguebringerGoliath6.AddRecipe();

			
				ModRecipe PlaguebringerGoliath7 = new ModRecipe(this);
				PlaguebringerGoliath7.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath7.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath7.SetResult(calamityMod.ItemType("DiseasedPike"), 1);
				PlaguebringerGoliath7.AddRecipe();
			
				ModRecipe PlaguebringerGoliath8 = new ModRecipe(this);
				PlaguebringerGoliath8.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath8.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath8.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath8.SetResult(calamityMod.ItemType("PlagueStaff"), 1);
				PlaguebringerGoliath8.AddRecipe();

				ModRecipe PlaguebringerGoliath9 = new ModRecipe(this);
				PlaguebringerGoliath9.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath9.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath9.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath9.SetResult(calamityMod.ItemType("PestilentDefiler"), 1);
				PlaguebringerGoliath9.AddRecipe();

				ModRecipe PlaguebringerGoliath10 = new ModRecipe(this);
				PlaguebringerGoliath10.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath10.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath10.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath10.SetResult(calamityMod.ItemType("Pandemic"), 1);
				PlaguebringerGoliath10.AddRecipe();

				ModRecipe PlaguebringerGoliath12 = new ModRecipe(this);
				PlaguebringerGoliath12.AddRecipeGroup("JumpStart:PlaguebringerGoliath", 1);
				PlaguebringerGoliath12.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				PlaguebringerGoliath12.AddTile(TileID.TinkerersWorkbench);
				PlaguebringerGoliath12.SetResult(calamityMod.ItemType("TheSyringe"), 1);
				PlaguebringerGoliath12.AddRecipe();
			
				//Ravager
			
				ModRecipe Ravager1 = new ModRecipe(this);
				Ravager1.AddRecipeGroup("JumpStart:Ravager", 1);
				Ravager1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ravager1.AddTile(TileID.TinkerersWorkbench);
				Ravager1.SetResult(calamityMod.ItemType("UltimusCleaver"), 1);
				Ravager1.AddRecipe();

				ModRecipe Ravager2 = new ModRecipe(this);
				Ravager2.AddRecipeGroup("JumpStart:Ravager", 1);
				Ravager2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ravager2.AddTile(TileID.TinkerersWorkbench);
				Ravager2.SetResult(calamityMod.ItemType("RealmRavager"), 1);
				Ravager2.AddRecipe();

				ModRecipe Ravager3 = new ModRecipe(this);
				Ravager3.AddRecipeGroup("JumpStart:Ravager", 1);
				Ravager3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ravager3.AddTile(TileID.TinkerersWorkbench);
				Ravager3.SetResult(calamityMod.ItemType("Hematemesis"), 1);
				Ravager3.AddRecipe();

				ModRecipe Ravager4 = new ModRecipe(this);
				Ravager4.AddRecipeGroup("JumpStart:Ravager", 1);
				Ravager4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ravager4.AddTile(TileID.TinkerersWorkbench);
				Ravager4.SetResult(calamityMod.ItemType("SpikecragStaff"), 1);
				Ravager4.AddRecipe();

				ModRecipe Ravager5 = new ModRecipe(this);
				Ravager5.AddRecipeGroup("JumpStart:Ravager", 1);
				Ravager5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ravager5.AddTile(TileID.TinkerersWorkbench);
				Ravager5.SetResult(calamityMod.ItemType("CraniumSmasher"), 1);
				Ravager5.AddRecipe();
			
				//Astrum Deus
				ModRecipe AstrumDeus1 = new ModRecipe(this);
				AstrumDeus1.AddRecipeGroup("JumpStart:AstrumDeus", 1);
				AstrumDeus1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumDeus1.AddTile(TileID.TinkerersWorkbench);
				AstrumDeus1.SetResult(calamityMod.ItemType("TheMicrowave"), 1);
				AstrumDeus1.AddRecipe();

				ModRecipe AstrumDeus2 = new ModRecipe(this);
				AstrumDeus2.AddRecipeGroup("JumpStart:AstrumDeus", 1);
				AstrumDeus2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumDeus2.AddTile(TileID.TinkerersWorkbench);
				AstrumDeus2.SetResult(calamityMod.ItemType("StarSputter"), 1);
				AstrumDeus2.AddRecipe();

				ModRecipe AstrumDeus3 = new ModRecipe(this);
				AstrumDeus3.AddRecipeGroup("JumpStart:AstrumDeus", 1);
				AstrumDeus3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumDeus3.AddTile(TileID.TinkerersWorkbench);
				AstrumDeus3.SetResult(calamityMod.ItemType("Starfall"), 1);
				AstrumDeus3.AddRecipe();

				ModRecipe AstrumDeus4 = new ModRecipe(this);
				AstrumDeus4.AddRecipeGroup("JumpStart:AstrumDeus", 1);
				AstrumDeus4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumDeus4.AddTile(TileID.TinkerersWorkbench);
				AstrumDeus4.SetResult(calamityMod.ItemType("GodspawnHelixStaff"), 1);
				AstrumDeus4.AddRecipe();

				ModRecipe AstrumDeus5 = new ModRecipe(this);
				AstrumDeus5.AddRecipeGroup("JumpStart:AstrumDeus", 1);
				AstrumDeus5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AstrumDeus5.AddTile(TileID.TinkerersWorkbench);
				AstrumDeus5.SetResult(calamityMod.ItemType("RegulusRiot"), 1);
				AstrumDeus5.AddRecipe();

				//Dragonfolly
				ModRecipe Dragonfolly1 = new ModRecipe(this);
				Dragonfolly1.AddRecipeGroup("JumpStart:Dragonfolly", 1);
				Dragonfolly1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Dragonfolly1.AddTile(TileID.TinkerersWorkbench);
				Dragonfolly1.SetResult(calamityMod.ItemType("RougeSlash"), 1);
				Dragonfolly1.AddRecipe();

				ModRecipe Dragonfolly2 = new ModRecipe(this);
				Dragonfolly2.AddRecipeGroup("JumpStart:Dragonfolly", 1);
				Dragonfolly2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Dragonfolly2.AddTile(TileID.TinkerersWorkbench);
				Dragonfolly2.SetResult(calamityMod.ItemType("GildedProboscis"), 1);
				Dragonfolly2.AddRecipe();

				ModRecipe Dragonfolly3 = new ModRecipe(this);
				Dragonfolly3.AddRecipeGroup("JumpStart:Dragonfolly", 1);
				Dragonfolly3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Dragonfolly3.AddTile(TileID.TinkerersWorkbench);
				Dragonfolly3.SetResult(calamityMod.ItemType("GoldenEagle"), 1);
				Dragonfolly3.AddRecipe();

				//Providence
				ModRecipe Providence1 = new ModRecipe(this);
				Providence1.AddRecipeGroup("JumpStart:Providence", 1);
				Providence1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Providence1.AddTile(TileID.TinkerersWorkbench);
				Providence1.SetResult(calamityMod.ItemType("BlissfulBombardier"), 1);
				Providence1.AddRecipe();

				ModRecipe Providence2 = new ModRecipe(this);
				Providence2.AddRecipeGroup("JumpStart:Providence", 1);
				Providence2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Providence2.AddTile(TileID.TinkerersWorkbench);
				Providence2.SetResult(calamityMod.ItemType("DazzlingStabberStaff"), 1);
				Providence2.AddRecipe();

				ModRecipe Providence3 = new ModRecipe(this);
				Providence3.AddRecipeGroup("JumpStart:Providence", 1);
				Providence3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Providence3.AddTile(TileID.TinkerersWorkbench);
				Providence3.SetResult(calamityMod.ItemType("HolyCollider"), 1);
				Providence3.AddRecipe();

				ModRecipe Providence4 = new ModRecipe(this);
				Providence4.AddRecipeGroup("JumpStart:Providence", 1);
				Providence4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Providence4.AddTile(TileID.TinkerersWorkbench);
				Providence4.SetResult(calamityMod.ItemType("MoltenAmputator"), 1);
				Providence4.AddRecipe();

				ModRecipe Providence5 = new ModRecipe(this);
				Providence5.AddRecipeGroup("JumpStart:Providence", 1);
				Providence5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Providence5.AddTile(TileID.TinkerersWorkbench);
				Providence5.SetResult(calamityMod.ItemType("PurgeGuzzler"), 1);
				Providence5.AddRecipe();

				ModRecipe Providence6 = new ModRecipe(this);
				Providence6.AddRecipeGroup("JumpStart:Providence", 1);
				Providence6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Providence6.AddTile(TileID.TinkerersWorkbench);
				Providence6.SetResult(calamityMod.ItemType("TelluricGaze"), 1);
				Providence6.AddRecipe();

				ModRecipe Providence7 = new ModRecipe(this);
				Providence7.AddRecipeGroup("JumpStart:Providence", 1);
				Providence7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Providence7.AddTile(TileID.TinkerersWorkbench);
				Providence7.SetResult(calamityMod.ItemType("SolarFlare"), 1);
				Providence7.AddRecipe();

				//Polterghast
				ModRecipe Polterghast1 = new ModRecipe(this);
				Polterghast1.AddRecipeGroup("JumpStart:Polterghast", 1);
				Polterghast1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Polterghast1.AddTile(TileID.TinkerersWorkbench);
				Polterghast1.SetResult(calamityMod.ItemType("BansheeHook"), 1);
				Polterghast1.AddRecipe();

				ModRecipe Polterghast2 = new ModRecipe(this);
				Polterghast2.AddRecipeGroup("JumpStart:Polterghast", 1);
				Polterghast2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Polterghast2.AddTile(TileID.TinkerersWorkbench);
				Polterghast2.SetResult(calamityMod.ItemType("DaemonsFlame"), 1);
				Polterghast2.AddRecipe();

				ModRecipe Polterghast3 = new ModRecipe(this);
				Polterghast3.AddRecipeGroup("JumpStart:Polterghast", 1);
				Polterghast3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Polterghast3.AddTile(TileID.TinkerersWorkbench);
				Polterghast3.SetResult(calamityMod.ItemType("EtherealSubjugator"), 1);
				Polterghast3.AddRecipe();

				ModRecipe Polterghast4 = new ModRecipe(this);
				Polterghast4.AddRecipeGroup("JumpStart:Polterghast", 1);
				Polterghast4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Polterghast4.AddTile(TileID.TinkerersWorkbench);
				Polterghast4.SetResult(calamityMod.ItemType("FatesReveal"), 1);
				Polterghast4.AddRecipe();

				ModRecipe Polterghast5 = new ModRecipe(this);
				Polterghast5.AddRecipeGroup("JumpStart:Polterghast", 1);
				Polterghast5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Polterghast5.AddTile(TileID.TinkerersWorkbench);
				Polterghast5.SetResult(calamityMod.ItemType("BansheeHook"), 1);
				Polterghast5.AddRecipe();

				ModRecipe Polterghast6 = new ModRecipe(this);
				Polterghast6.AddRecipeGroup("JumpStart:Polterghast", 1);
				Polterghast6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Polterghast6.AddTile(TileID.TinkerersWorkbench);
				Polterghast6.SetResult(calamityMod.ItemType("GhastlyVisage"), 1);
				Polterghast6.AddRecipe();

				ModRecipe Polterghast7 = new ModRecipe(this);
				Polterghast7.AddRecipeGroup("JumpStart:Polterghast", 1);
				Polterghast7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Polterghast7.AddTile(TileID.TinkerersWorkbench);
				Polterghast7.SetResult(calamityMod.ItemType("GhoulishGouger"), 1);
				Polterghast7.AddRecipe();

				ModRecipe Polterghast8 = new ModRecipe(this);
				Polterghast8.AddRecipeGroup("JumpStart:Polterghast", 1);
				Polterghast8.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Polterghast8.AddTile(TileID.TinkerersWorkbench);
				Polterghast8.SetResult(calamityMod.ItemType("TerrorBlade"), 1);
				Polterghast8.AddRecipe();

				//Old Duke
				ModRecipe OldDuke1 = new ModRecipe(this);
				OldDuke1.AddRecipeGroup("JumpStart:OldDuke", 1);
				OldDuke1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				OldDuke1.AddTile(TileID.TinkerersWorkbench);
				OldDuke1.SetResult(calamityMod.ItemType("InsidiousImpaler"), 1);
				OldDuke1.AddRecipe();

				ModRecipe OldDuke2 = new ModRecipe(this);
				OldDuke2.AddRecipeGroup("JumpStart:OldDuke", 1);
				OldDuke2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				OldDuke2.AddTile(TileID.TinkerersWorkbench);
				OldDuke2.SetResult(calamityMod.ItemType("FetidEmesis"), 1);
				OldDuke2.AddRecipe();

				ModRecipe OldDuke3 = new ModRecipe(this);
				OldDuke3.AddRecipeGroup("JumpStart:OldDuke", 1);
				OldDuke3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				OldDuke3.AddTile(TileID.TinkerersWorkbench);
				OldDuke3.SetResult(calamityMod.ItemType("SepticSkewer"), 1);
				OldDuke3.AddRecipe();

				ModRecipe OldDuke4 = new ModRecipe(this);
				OldDuke4.AddRecipeGroup("JumpStart:OldDuke", 1);
				OldDuke4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				OldDuke4.AddTile(TileID.TinkerersWorkbench);
				OldDuke4.SetResult(calamityMod.ItemType("VitriolicViper"), 1);
				OldDuke4.AddRecipe();

				ModRecipe OldDuke5 = new ModRecipe(this);
				OldDuke5.AddRecipeGroup("JumpStart:OldDuke", 1);
				OldDuke5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				OldDuke5.AddTile(TileID.TinkerersWorkbench);
				OldDuke5.SetResult(calamityMod.ItemType("CadaverousCarrion"), 1);
				OldDuke5.AddRecipe();

				ModRecipe OldDuke6 = new ModRecipe(this);
				OldDuke6.AddRecipeGroup("JumpStart:OldDuke", 1);
				OldDuke6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				OldDuke6.AddTile(TileID.TinkerersWorkbench);
				OldDuke6.SetResult(calamityMod.ItemType("ToxicantTwister"), 1);
				OldDuke6.AddRecipe();

				//Devourer of Gods
				ModRecipe DOG1 = new ModRecipe(this);
				DOG1.AddRecipeGroup("JumpStart:DOG", 1);
				DOG1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DOG1.AddTile(TileID.TinkerersWorkbench);
				DOG1.SetResult(calamityMod.ItemType("Excelsus"), 1);
				DOG1.AddRecipe();

				ModRecipe DOG2 = new ModRecipe(this);
				DOG2.AddRecipeGroup("JumpStart:DOG", 1);
				DOG2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DOG2.AddTile(TileID.TinkerersWorkbench);
				DOG2.SetResult(calamityMod.ItemType("TheObliterator"), 1);
				DOG2.AddRecipe();

				ModRecipe DOG3 = new ModRecipe(this);
				DOG3.AddRecipeGroup("JumpStart:DOG", 1);
				DOG3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DOG3.AddTile(TileID.TinkerersWorkbench);
				DOG3.SetResult(calamityMod.ItemType("DeathhailStaff"), 1);
				DOG3.AddRecipe();

				ModRecipe DOG4 = new ModRecipe(this);
				DOG4.AddRecipeGroup("JumpStart:DOG", 1);
				DOG4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DOG4.AddTile(TileID.TinkerersWorkbench);
				DOG4.SetResult(calamityMod.ItemType("Eradicator"), 1);
				DOG4.AddRecipe();

				ModRecipe DOG5 = new ModRecipe(this);
				DOG5.AddRecipeGroup("JumpStart:DOG", 1);
				DOG5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DOG5.AddTile(TileID.TinkerersWorkbench);
				DOG5.SetResult(calamityMod.ItemType("Deathwind"), 1);
				DOG5.AddRecipe();

				ModRecipe DOG6 = new ModRecipe(this);
				DOG6.AddRecipeGroup("JumpStart:DOG", 1);
				DOG6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				DOG6.AddTile(TileID.TinkerersWorkbench);
				DOG6.SetResult(calamityMod.ItemType("StaffoftheMechworm"), 1);
				DOG6.AddRecipe();

				//Yharon
				ModRecipe Yharon1 = new ModRecipe(this);
				Yharon1.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon1.AddTile(TileID.TinkerersWorkbench);
				Yharon1.SetResult(calamityMod.ItemType("YharonsKindleStaff"), 1);
				Yharon1.AddRecipe();

				ModRecipe Yharon2 = new ModRecipe(this);
				Yharon2.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon2.AddTile(TileID.TinkerersWorkbench);
				Yharon2.SetResult(calamityMod.ItemType("TheFinalDawn"), 1);
				Yharon2.AddRecipe();

				ModRecipe Yharon3 = new ModRecipe(this);
				Yharon3.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon3.AddTile(TileID.TinkerersWorkbench);
				Yharon3.SetResult(calamityMod.ItemType("DragonsBreath"), 1);
				Yharon3.AddRecipe();

				ModRecipe Yharon4 = new ModRecipe(this);
				Yharon4.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon4.AddTile(TileID.TinkerersWorkbench);
				Yharon4.SetResult(calamityMod.ItemType("PhoenixFlameStaff"), 1);
				Yharon4.AddRecipe();

				ModRecipe Yharon5 = new ModRecipe(this);
				Yharon5.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon5.AddTile(TileID.TinkerersWorkbench);
				Yharon5.SetResult(calamityMod.ItemType("TheBurningSky"), 1);
				Yharon5.AddRecipe();

				ModRecipe Yharon6 = new ModRecipe(this);
				Yharon6.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon6.AddTile(TileID.TinkerersWorkbench);
				Yharon6.SetResult(calamityMod.ItemType("InfernalSpear"), 1);
				Yharon6.AddRecipe();

				ModRecipe Yharon7 = new ModRecipe(this);
				Yharon7.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon7.AddTile(TileID.TinkerersWorkbench);
				Yharon7.SetResult(calamityMod.ItemType("DragonRage"), 1);
				Yharon7.AddRecipe();

				ModRecipe Yharon8 = new ModRecipe(this);
				Yharon8.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon8.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon8.AddTile(TileID.TinkerersWorkbench);
				Yharon8.SetResult(calamityMod.ItemType("ChickenCannon"), 1);
				Yharon8.AddRecipe();
			**/
			}
        }





    }
}