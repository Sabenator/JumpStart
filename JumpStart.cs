using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using JumpStart;
using System;

namespace JumpStart
{
	public class JumpStart : Mod
	{
		static Mod magicStorage => ModLoader.GetMod("MagicStorage");
		static Mod calamityMod => ModLoader.GetMod("CalamityMod");
		static Mod imkSushisMod => ModLoader.GetMod("imkSushisMod");
		static Mod thoriumMod => ModLoader.GetMod("ThoriumMod");
		static Mod spiritMod => ModLoader.GetMod("SpiritMod");
		static Mod redemptionMod => ModLoader.GetMod("Redemption");
		static Mod sacredToolsMod => ModLoader.GetMod("SacredTools");
		static Mod ultraniumMod => ModLoader.GetMod("Ultranium");

		public List<string> RecipeGroups = new List<string>();
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

				RecipeGroup Leviathan = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Leviathan Weapon", new int[] {
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
					calamityMod.ItemType("MepheticSprayer"),
					calamityMod.ItemType("FuelCellBundle"),
					calamityMod.ItemType("Malevolence"),
					calamityMod.ItemType("InfectedRemote"),
					calamityMod.ItemType("VirulentKatana"),
					calamityMod.ItemType("DiseasedPike"),
					calamityMod.ItemType("PlagueStaff"),
					calamityMod.ItemType("PestilentDefiler"),
					calamityMod.ItemType("ThePlaguebringer"),
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
					calamityMod.ItemType("AngryChickenStaff"),
					calamityMod.ItemType("FinalDawn"),
					calamityMod.ItemType("DragonsBreath"),
					calamityMod.ItemType("PhoenixFlameBarrage"),
					calamityMod.ItemType("TheBurningSky"),
					calamityMod.ItemType("ProfanedTrident"),
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

			if (spiritMod != null) {


				//Scarabeus
				rg Scarabeus = new rg(spiritMod, "Scarabeus", "ScarabSword", "ScarabBow", "OrnateStaff");
				if (Scarabeus._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:Scarabeus", Scarabeus._RecipeGroup);
					RecipeGroups.Add("Scarabeus");
				}

				//Moon Jelly Wizard
				rg MoonJellyWizard = new rg(spiritMod, "Moon Jelly Wizard", "Moonshot", "Moonburst", "MoonjellySummonStaff", "JellynautBubble");
				if (MoonJellyWizard._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:MoonJellyWizard", MoonJellyWizard._RecipeGroup);
					RecipeGroups.Add("MoonJellyWizard");
				}

				//Vinewrath Bane
				rg VinewrathBane = new rg(spiritMod, "Vinewrath Bane", "ReachBossSword", "ThornBow", "SunbeamStaff", "ReachVineStaff", "ReachKnife");
				if (VinewrathBane._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:Vinewrath", VinewrathBane._RecipeGroup);
					RecipeGroups.Add("Vinewrath");
				}


				//AncientAvian
				rg AncientAvian = new rg(spiritMod, "Ancient Avian", "Talonginus", "SkeletalonStaff", "TalonBlade", "SoaringScapula", "TalonPiercer");
				if (AncientAvian._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:AncientAvian", AncientAvian._RecipeGroup);
					RecipeGroups.Add("AncientAvian");
				}


				//Snow Monger
				rg SnowMonger = new rg(spiritMod, "Snow Monger", "BlizzardEdge", "ShiverWind", "Chillrend", "Bauble");
				if (SnowMonger._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:SnowMonger", SnowMonger._RecipeGroup);
					RecipeGroups.Add("SnowMonger");
				}

				//Lavavent Elemental
				rg LavaventElemental = new rg(spiritMod, "Lavavent Elemental", "FierySoul", "LavaStaff", "LavaSpear");
				if (LavaventElemental._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:LavaventElemental", LavaventElemental._RecipeGroup);
					RecipeGroups.Add("LavaventElemental");
				}

				//Infernon
				rg Infernon = new rg(spiritMod, "Infernon", "InfernalSword", "SevenSins", "InfernalStaff", "EyeOfTheInferno", "InfernalJavelin", "EyeOfTheInferno", "InfernalShield");
				if (Infernon._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:Infernon", Infernon._RecipeGroup);
					RecipeGroups.Add("Infernon");
				}

				//Dusking
				rg Dusking = new rg(spiritMod, "Dusking", "ShadowflameSword", "Shadowmoor", "UmbraStaff", "ShadowSphere");
				RecipeGroup.RegisterGroup("JumpStart:Dusking", Dusking._RecipeGroup);
				RecipeGroups.Add("Dusking");


				//Atlas
				rg Atlas = new rg(spiritMod, "Atlas", "Mountain", "Earthshatter", "QuakeFist", "CragboundStaff", "KingRock", "TitanboundBulwark");
				if (Atlas._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:Atlas", Atlas._RecipeGroup);
					RecipeGroups.Add("Atlas");
				}

				//Overseer
				rg Overseer = new rg(spiritMod, "Overseer", "EssenseTearer", "Eternity", "SoulExpulsor", "AeonRipper");
				if (Overseer._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:Overseer", Overseer._RecipeGroup);
					RecipeGroups.Add("Overseer");
				}

				//R'lyehian
				rg Rlyehian = new rg(spiritMod, "Rlyehian", "TomeOfRylien", "TentacleChain");
				if (Rlyehian._RecipeGroup != null)
				{
					RecipeGroup.RegisterGroup("JumpStart:Rlyehian", Rlyehian._RecipeGroup);
					RecipeGroups.Add("Rlyehian");
				}
			}
			if (redemptionMod != null) {

				//Thorn, Bane of the Forest
				rg Thorn = new rg(redemptionMod, "Thorn, Bane of the Forest", "CursedGrassSword", "RootTendril", "CursedThornBow", "ThornSeedBag");
				RecipeGroup.RegisterGroup("JumpStart:Thorn", Thorn._RecipeGroup);
				RecipeGroups.Add("Thorn");


				//The Keeper
				rg Keeper = new rg(redemptionMod, "Keeper", "KeepersBow", "KeepersSummon", "KeepersKnife", "KeepersClaw", "KeepersStaff");
				RecipeGroup.RegisterGroup("JumpStart:Keeper", Keeper._RecipeGroup);
				RecipeGroups.Add("Keeper");

				//Seed of Infection
				rg SeedOfInfection = new rg(redemptionMod, "Seed of Infection", "XenoCanister", "XenomiteGlaive", "XenomiteYoyo");
				RecipeGroup.RegisterGroup("JumpStart:SeedOfInfection", SeedOfInfection._RecipeGroup);
				RecipeGroups.Add("SeedOfInfection");

				//Infected Eye
				rg InfectedEye = new rg(redemptionMod, "Infected Eye", "XenomiteStaff", "TheInfectedEye", "InfectousJavelin");
				RecipeGroup.RegisterGroup("JumpStart:InfectedEye", InfectedEye._RecipeGroup);
				RecipeGroups.Add("InfectedEye");


				//King Slayer III
				rg KingSlayerIII = new rg(redemptionMod, "King Slayer III", "SlayerFlamethrower", "SlayerNanogun", "SlayerFist", "SlayerGun");
				RecipeGroup.RegisterGroup("JumpStart:KingSlayerIII", KingSlayerIII._RecipeGroup);
				RecipeGroups.Add("KingSlayerIII");

				//Vlitch Cleaver
				rg VlitchCleaver = new rg(redemptionMod, "Vlitch Cleaver", "GirusLance", "GirusDagger", "GirusDaggerThrown");
				RecipeGroup.RegisterGroup("JumpStart:VlitchCleaver", VlitchCleaver._RecipeGroup);
				RecipeGroups.Add("VlitchCleaver");

				//Vlitch Gigapede
				rg VlitchGigapede = new rg(redemptionMod, "Vlitch Gigapede", "CorruptedDoubleRifle", "CorruptedRocketLauncher");
				RecipeGroup.RegisterGroup("JumpStart:VlitchGigapede", VlitchGigapede._RecipeGroup);
				RecipeGroups.Add("VlitchGigapede");

				//Omega Obliterator
				rg OmegaObliterator = new rg(redemptionMod, "Omega Obliterator", "PlasmaJawser", "OmegaClaw", "GloopContainer");
				RecipeGroup.RegisterGroup("JumpStart:OmegaObliterator", OmegaObliterator._RecipeGroup);
				RecipeGroups.Add("OmegaObliterator");

				//Patient Zero
				rg PatientZero = new rg(redemptionMod, "Patient Zero", "PZGauntlet", "SwarmerGun", "XeniumSaber");
				RecipeGroup.RegisterGroup("JumpStart:PatientZero", PatientZero._RecipeGroup);
				RecipeGroups.Add("PatientZero");

				//Ancient Deity Duo
				rg AncientDeityDuo = new rg(redemptionMod, "Ancient Deity Duo", "CursedThornFlail", "CursedThornBow2", "EaglecrestGlove", "StonePuppet", "AncientPowerStave");
				RecipeGroup.RegisterGroup("JumpStart:AncientDeityDuo", AncientDeityDuo._RecipeGroup);
				RecipeGroups.Add("AncientDeityDuo");

				//Nebuleus
				rg Nebuleus = new rg(redemptionMod, "Nebuleus", "CosmosChainWeapon", "FreedomStarN", "StarfruitSeedbag", "ConstellationsBook");
				RecipeGroup.RegisterGroup("JumpStart:Nebuleus", Nebuleus._RecipeGroup);
				RecipeGroups.Add("Nebuleus");
			}
			if (sacredToolsMod != null) {
				rg FlamingPumpkin = new rg(sacredToolsMod, "Flaming Pumpkin", "PumpGlove", "PumpYoyo", "MoodSummon");
				RecipeGroup.RegisterGroup("JumpStart:FlamingPumpkin", FlamingPumpkin._RecipeGroup);
				RecipeGroups.Add("FlamingPumpkin");

				rg ZombiePiglinBrute = new rg(sacredToolsMod, "Zombie Piglin Brute", "Sausbow", "Ribarang", "DeadVoxel", "MissingFury");
				RecipeGroup.RegisterGroup("JumpStart:ZombiePiglinBrute", ZombiePiglinBrute._RecipeGroup);
				RecipeGroups.Add("ZombiePiglinBrute");

				rg Araneas = new rg(sacredToolsMod, "Araneas", "ArachnesGaze", "HoariHemonga", "RazorfangDagger", "SanguineumVirgam");
				RecipeGroup.RegisterGroup("JumpStart:Araneas", Araneas._RecipeGroup);
				RecipeGroups.Add("Araneas");

				rg TheLostSiblings = new rg(sacredToolsMod, "The Lost Siblings", "BlindJustice", "StarScourge", "CosmicCloudBracelet", "LightningRifle", "AsteroidShower");
				RecipeGroup.RegisterGroup("JumpStart:TheLostSiblings", TheLostSiblings._RecipeGroup);
				RecipeGroups.Add("TheLostSiblings");
			}
            if (thoriumMod != null)
            {
                rg GrandThunderBird = new rg(thoriumMod, "Grand Thunder Bird", "HatchlingStaff", "ThunderTalon", "Didgeridoo", "TalonBurst");
                RecipeGroup.RegisterGroup("JumpStart:GrandThunderBird", GrandThunderBird._RecipeGroup);
                RecipeGroups.Add("GrandThunderBird");

                rg QueenJellyfish = new rg(thoriumMod, "Queen Jellyfish", "SparkingJellyBall", "BlunderBuss", "GiantGlowstick", "JellyPondWand", "ConchShell");
                RecipeGroup.RegisterGroup("JumpStart:QueenJellyfish", QueenJellyfish._RecipeGroup);
                RecipeGroups.Add("QueenJellyfish");

                rg Viscount = new rg(thoriumMod, "Viscount", "BatWing", "GuanoGunner", "VampireScepter", "ViscountCane", "BatScythe", "SonarCannon");
                RecipeGroup.RegisterGroup("JumpStart:Viscount", Viscount._RecipeGroup);
                RecipeGroups.Add("Viscount");

				rg GraniteEnergyStorm = new rg(thoriumMod, "Granite Energy Storm", "EnergyStormPartisan", "EnergyStormBolter", "EnergyProjector", "BoulderProbe", "BatScythe", "ShockAbsorber");
				RecipeGroup.RegisterGroup("JumpStart:GraniteEnergyStorm", GraniteEnergyStorm._RecipeGroup);
				RecipeGroups.Add("GraniteEnergyStorm");

				rg BuriedChampion = new rg(thoriumMod, "Buried Champion", "ChampionBlade", "HeroTripleBow", "ChampionBomberStaff", "ChampionsGodHand", "ChampionsBarrier");
				RecipeGroup.RegisterGroup("JumpStart:BuriedChampion", BuriedChampion._RecipeGroup);
				RecipeGroups.Add("BuriedChampion");

				rg StarScouter = new rg(thoriumMod, "Star Scouter", "StarTrail", "GaussSpark", "HitScanner", "DistressCaller", "GaussKnife", "StarRod", "Roboboe");
				RecipeGroup.RegisterGroup("JumpStart:StarScouter", StarScouter._RecipeGroup);
				RecipeGroups.Add("StarScouter");

				rg BoreanStrider = new rg(thoriumMod, "Borean Strider", "GlacialSting", "GlacierFang", "FrostFang", "FreezeRay", "CryoFang");
				RecipeGroup.RegisterGroup("JumpStart:BoreanStrider", BoreanStrider._RecipeGroup);
				RecipeGroups.Add("BoreanStrider");

				rg FallenBeholder = new rg(thoriumMod, "Fallen Beholder", "ThermogenicImpaler", "Obliterator", "DemonFireBlastWand", "DevilPauldron", "BeholderStaff", "VoidPlanter");
				RecipeGroup.RegisterGroup("JumpStart:FallenBeholder", FallenBeholder._RecipeGroup);
				RecipeGroups.Add("FallenBeholder");

				rg Lich = new rg(thoriumMod, "Lich", "SoulRender", "WitherStaff", "CryptWand", "SoulCleaver", "CadaverCornet");
				RecipeGroup.RegisterGroup("JumpStart:Lich", Lich._RecipeGroup);
				RecipeGroups.Add("Lich");

				rg Abyssion = new rg(thoriumMod, "Abyssion", "TheIncubator", "MantisPunch", "TrenchSpitter", "OldGodGrasp", "SirensAllure");
				RecipeGroup.RegisterGroup("JumpStart:Abyssion", Abyssion._RecipeGroup);
				RecipeGroups.Add("Abyssion");
			}
			if (ultraniumMod != null)
			{
				rg ZephyrSquid = new rg(ultraniumMod, "Zephyr Squid", "ZephyrBlade", "ZephyrKnife", "ZephyrTrident");
				RecipeGroup.RegisterGroup("JumpStart:ZephyrSquid", ZephyrSquid._RecipeGroup);
				RecipeGroups.Add("ZephyrSquid");

				rg Glacieron = new rg(ultraniumMod, "Glacieron", "GlacialFlail", "GlacialGun", "GlacialWand");
				RecipeGroup.RegisterGroup("JumpStart:Glacieron", Glacieron._RecipeGroup);
				RecipeGroups.Add("Glacieron");

				rg Dread = new rg(ultraniumMod, "Dread", "DreadBow", "DreadStaff", "DreadSummon", "DreadSword");
				RecipeGroup.RegisterGroup("JumpStart:Dread", Dread._RecipeGroup);
				RecipeGroups.Add("Dread");

				rg Xenanis = new rg(ultraniumMod, "Xenanis", "EtherealBow", "EtherealDidgeridoo", "EtherealSummon", "EtherealSword", "EtherealTome");
				RecipeGroup.RegisterGroup("JumpStart:Xenanis", Xenanis._RecipeGroup);
				RecipeGroups.Add("Xenanis");

				rg Ultrum = new rg(ultraniumMod, "Ultrum", "UltraniumSword", "UltraniumSword", "UltraTome", "UltraniumKunai", "UltraniumBow", "UltraFlail");
				RecipeGroup.RegisterGroup("JumpStart:Ultrum", Ultrum._RecipeGroup);
				RecipeGroups.Add("Ultrum");

				rg Ignodium = new rg(ultraniumMod, "Ignodium", "HellThrow", "HellFlail", "HellTome", "HellGun", "HellStaff", "HellJavelin");
				RecipeGroup.RegisterGroup("JumpStart:Ignodium", Ignodium._RecipeGroup);
				RecipeGroups.Add("Ignodium");

				rg AbsoluteDread = new rg(ultraniumMod, "Absolute Dread", "DreadDisc", "DreadScepter", "DreadFlameBlaster", "DreadSpear", "DreadTome", "FearStaff", "DreadYoyo");
				RecipeGroup.RegisterGroup("JumpStart:AbsoluteDread", AbsoluteDread._RecipeGroup);
				RecipeGroups.Add("AbsoluteDread");

				rg Erebus = new rg(ultraniumMod, "Erebus", "Caliginus", "CavumNigrum", "Crepus", "ErebusGuitar", "Exitium", "Inanis", "Nihil", "Noctis", "SolibusOrba", "Umbra");
				RecipeGroup.RegisterGroup("JumpStart:Erebus", Erebus._RecipeGroup);
				RecipeGroups.Add("Erebus");
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
            if (ultraniumMod != null && imkSushisMod != null) {
				ModRecipe ZephyrSquid1 = new ModRecipe(this);
				ZephyrSquid1.AddRecipeGroup("JumpStart:ZephyrSquid", 1);
				ZephyrSquid1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				ZephyrSquid1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ze1 = new ItemCheck(ultraniumMod.ItemType("ZephyrBlade"));
				ZephyrSquid1.SetResult(Ze1.Validate(), 1);
				ZephyrSquid1.AddRecipe();

				ModRecipe ZephyrSquid2 = new ModRecipe(this);
				ZephyrSquid2.AddRecipeGroup("JumpStart:ZephyrSquid", 1);
				ZephyrSquid2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				ZephyrSquid2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ze2 = new ItemCheck(ultraniumMod.ItemType("ZephyrKnife"));
				ZephyrSquid2.SetResult(Ze2.Validate(), 1);
				ZephyrSquid2.AddRecipe();

				ModRecipe ZephyrSquid3 = new ModRecipe(this);
				ZephyrSquid3.AddRecipeGroup("JumpStart:ZephyrSquid", 1);
				ZephyrSquid3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				ZephyrSquid3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ze3 = new ItemCheck(ultraniumMod.ItemType("ZephyrTrident"));
				ZephyrSquid3.SetResult(Ze3.Validate(), 1);
				ZephyrSquid3.AddRecipe();

				ModRecipe Glacieron1 = new ModRecipe(this);
				Glacieron1.AddRecipeGroup("JumpStart:Glacieron", 1);
				Glacieron1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Glacieron1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Gl1 = new ItemCheck(ultraniumMod.ItemType("GlacialFlail"));
				Glacieron1.SetResult(Gl1.Validate(), 1);
				Glacieron1.AddRecipe();

				ModRecipe Glacieron2 = new ModRecipe(this);
				Glacieron2.AddRecipeGroup("JumpStart:Glacieron", 1);
				Glacieron2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Glacieron2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Gl2 = new ItemCheck(ultraniumMod.ItemType("GlacialGun"));
				Glacieron2.SetResult(Gl2.Validate(), 1);
				Glacieron2.AddRecipe();

				ModRecipe Glacieron3 = new ModRecipe(this);
				Glacieron3.AddRecipeGroup("JumpStart:Glacieron", 1);
				Glacieron3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Glacieron3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Gl3 = new ItemCheck(ultraniumMod.ItemType("GlacialWand"));
				Glacieron3.SetResult(Gl3.Validate(), 1);
				Glacieron3.AddRecipe();

				ModRecipe Dread1 = new ModRecipe(this);
				Dread1.AddRecipeGroup("JumpStart:Dread", 1);
				Dread1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Dread1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Dr1 = new ItemCheck(ultraniumMod.ItemType("DreadBow"));
				Dread1.SetResult(Dr1.Validate(), 1);
				Dread1.AddRecipe();

				ModRecipe Dread2 = new ModRecipe(this);
				Dread2.AddRecipeGroup("JumpStart:Dread", 1);
				Dread2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Dread2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Dr2 = new ItemCheck(ultraniumMod.ItemType("DreadStaff"));
				Dread2.SetResult(Dr2.Validate(), 1);
				Dread2.AddRecipe();

				ModRecipe Dread3 = new ModRecipe(this);
				Dread3.AddRecipeGroup("JumpStart:Dread", 1);
				Dread3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Dread3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Dr3 = new ItemCheck(ultraniumMod.ItemType("DreadSummon"));
				Dread3.SetResult(Dr3.Validate(), 1);
				Dread3.AddRecipe();

				ModRecipe Dread4 = new ModRecipe(this);
				Dread4.AddRecipeGroup("JumpStart:Dread", 1);
				Dread4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Dread4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Dr4 = new ItemCheck(ultraniumMod.ItemType("DreadSword"));
				Dread4.SetResult(Dr4.Validate(), 1);
				Dread4.AddRecipe();

				ModRecipe Xenanis1 = new ModRecipe(this);
				Xenanis1.AddRecipeGroup("JumpStart:Xenanis", 1);
				Xenanis1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Xenanis1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Xe1 = new ItemCheck(ultraniumMod.ItemType("EtherealBow"));
				Xenanis1.SetResult(Xe1.Validate(), 1);
				Xenanis1.AddRecipe();

				ModRecipe Xenanis2 = new ModRecipe(this);
				Xenanis2.AddRecipeGroup("JumpStart:Xenanis", 1);
				Xenanis2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Xenanis2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Xe2 = new ItemCheck(ultraniumMod.ItemType("EtherealDidgeridoo"));
				Xenanis2.SetResult(Xe2.Validate(), 1);
				Xenanis2.AddRecipe();

				ModRecipe Xenanis3 = new ModRecipe(this);
				Xenanis3.AddRecipeGroup("JumpStart:Xenanis", 1);
				Xenanis3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Xenanis3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Xe3 = new ItemCheck(ultraniumMod.ItemType("EtherealSummon"));
				Xenanis3.SetResult(Xe3.Validate(), 1);
				Xenanis3.AddRecipe();

				ModRecipe Xenanis4 = new ModRecipe(this);
				Xenanis4.AddRecipeGroup("JumpStart:Xenanis", 1);
				Xenanis4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Xenanis4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Xe4 = new ItemCheck(ultraniumMod.ItemType("EtherealSword"));
				Xenanis4.SetResult(Xe4.Validate(), 1);
				Xenanis4.AddRecipe();

				ModRecipe Xenanis5 = new ModRecipe(this);
				Xenanis5.AddRecipeGroup("JumpStart:Xenanis", 1);
				Xenanis5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Xenanis5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Xe5 = new ItemCheck(ultraniumMod.ItemType("EtherealTome"));
				Xenanis5.SetResult(Xe5.Validate(), 1);
				Xenanis5.AddRecipe();

				ModRecipe Ultrum1 = new ModRecipe(this);
				Ultrum1.AddRecipeGroup("JumpStart:Ultrum", 1);
				Ultrum1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ultrum1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ul1 = new ItemCheck(ultraniumMod.ItemType("UltraniumSword"));
				Ultrum1.SetResult(Ul1.Validate(), 1);
				Ultrum1.AddRecipe();

				ModRecipe Ultrum2 = new ModRecipe(this);
				Ultrum2.AddRecipeGroup("JumpStart:Ultrum", 1);
				Ultrum2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ultrum2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ul2 = new ItemCheck(ultraniumMod.ItemType("UltraniumStaff"));
				Ultrum2.SetResult(Ul2.Validate(), 1);
				Ultrum2.AddRecipe();

				ModRecipe Ultrum3 = new ModRecipe(this);
				Ultrum3.AddRecipeGroup("JumpStart:Ultrum", 1);
				Ultrum3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ultrum3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ul3 = new ItemCheck(ultraniumMod.ItemType("UltraTome"));
				Ultrum3.SetResult(Ul3.Validate(), 1);
				Ultrum3.AddRecipe();

				ModRecipe Ultrum4 = new ModRecipe(this);
				Ultrum4.AddRecipeGroup("JumpStart:Ultrum", 1);
				Ultrum4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ultrum4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ul4 = new ItemCheck(ultraniumMod.ItemType("UltraniumKunai"));
				Ultrum4.SetResult(Ul4.Validate(), 1);
				Ultrum4.AddRecipe();

				ModRecipe Ultrum5 = new ModRecipe(this);
				Ultrum5.AddRecipeGroup("JumpStart:Ultrum", 1);
				Ultrum5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ultrum5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ul5 = new ItemCheck(ultraniumMod.ItemType("UltraniumBow"));
				Ultrum5.SetResult(Ul5.Validate(), 1);
				Ultrum5.AddRecipe();

				ModRecipe Ultrum6 = new ModRecipe(this);
				Ultrum6.AddRecipeGroup("JumpStart:Ultrum", 1);
				Ultrum6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ultrum6.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ul6 = new ItemCheck(ultraniumMod.ItemType("UltraFlail"));
				Ultrum6.SetResult(Ul6.Validate(), 1);
				Ultrum6.AddRecipe();

				ModRecipe Ignodium1 = new ModRecipe(this);
				Ignodium1.AddRecipeGroup("JumpStart:Ignodium", 1);
				Ignodium1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ignodium1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ig1 = new ItemCheck(ultraniumMod.ItemType("HellThrow"));
				Ignodium1.SetResult(Ig1.Validate(), 1);
				Ignodium1.AddRecipe();

				ModRecipe Ignodium2 = new ModRecipe(this);
				Ignodium2.AddRecipeGroup("JumpStart:Ignodium", 1);
				Ignodium2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ignodium2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ig2 = new ItemCheck(ultraniumMod.ItemType("HellFlail"));
				Ignodium2.SetResult(Ig2.Validate(), 1);
				Ignodium2.AddRecipe();

				ModRecipe Ignodium3 = new ModRecipe(this);
				Ignodium3.AddRecipeGroup("JumpStart:Ignodium", 1);
				Ignodium3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ignodium3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ig3 = new ItemCheck(ultraniumMod.ItemType("HellTome"));
				Ignodium3.SetResult(Ig3.Validate(), 1);
				Ignodium3.AddRecipe();

				ModRecipe Ignodium4 = new ModRecipe(this);
				Ignodium4.AddRecipeGroup("JumpStart:Ignodium", 1);
				Ignodium4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ignodium4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ig4 = new ItemCheck(ultraniumMod.ItemType("HellGun"));
				Ignodium4.SetResult(Ig4.Validate(), 1);
				Ignodium4.AddRecipe();

				ModRecipe Ignodium5 = new ModRecipe(this);
				Ignodium5.AddRecipeGroup("JumpStart:Ignodium", 1);
				Ignodium5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ignodium5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ig5 = new ItemCheck(ultraniumMod.ItemType("HellStaff"));
				Ignodium5.SetResult(Ig5.Validate(), 1);
				Ignodium5.AddRecipe();

				ModRecipe Ignodium6 = new ModRecipe(this);
				Ignodium6.AddRecipeGroup("JumpStart:Ignodium", 1);
				Ignodium6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Ignodium6.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ig6 = new ItemCheck(ultraniumMod.ItemType("HellJavelin"));
				Ignodium6.SetResult(Ig6.Validate(), 1);
				Ignodium6.AddRecipe();

				ModRecipe AbsoluteDread1 = new ModRecipe(this);
				AbsoluteDread1.AddRecipeGroup("JumpStart:AbsoluteDread", 1);
				AbsoluteDread1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AbsoluteDread1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab1 = new ItemCheck(ultraniumMod.ItemType("DreadDisc"));
				AbsoluteDread1.SetResult(Ab1.Validate(), 1);
				AbsoluteDread1.AddRecipe();

				ModRecipe AbsoluteDread2 = new ModRecipe(this);
				AbsoluteDread2.AddRecipeGroup("JumpStart:AbsoluteDread", 1);
				AbsoluteDread2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AbsoluteDread2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab2 = new ItemCheck(ultraniumMod.ItemType("DreadScepter"));
				AbsoluteDread2.SetResult(Ab2.Validate(), 1);
				AbsoluteDread2.AddRecipe();

				ModRecipe AbsoluteDread3 = new ModRecipe(this);
				AbsoluteDread3.AddRecipeGroup("JumpStart:AbsoluteDread", 1);
				AbsoluteDread3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AbsoluteDread3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab3 = new ItemCheck(ultraniumMod.ItemType("DreadScepter"));
				AbsoluteDread3.SetResult(Ab3.Validate(), 1);
				AbsoluteDread3.AddRecipe();

				ModRecipe AbsoluteDread4 = new ModRecipe(this);
				AbsoluteDread4.AddRecipeGroup("JumpStart:AbsoluteDread", 1);
				AbsoluteDread4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AbsoluteDread4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab4 = new ItemCheck(ultraniumMod.ItemType("DreadFlameBlaster"));
				AbsoluteDread4.SetResult(Ab4.Validate(), 1);
				AbsoluteDread4.AddRecipe();

				ModRecipe AbsoluteDread5 = new ModRecipe(this);
				AbsoluteDread5.AddRecipeGroup("JumpStart:AbsoluteDread", 1);
				AbsoluteDread5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AbsoluteDread5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab5 = new ItemCheck(ultraniumMod.ItemType("DreadSpear"));
				AbsoluteDread5.SetResult(Ab5.Validate(), 1);
				AbsoluteDread5.AddRecipe();

				ModRecipe AbsoluteDread6 = new ModRecipe(this);
				AbsoluteDread6.AddRecipeGroup("JumpStart:AbsoluteDread", 1);
				AbsoluteDread6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AbsoluteDread6.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab6 = new ItemCheck(ultraniumMod.ItemType("DreadTome"));
				AbsoluteDread6.SetResult(Ab6.Validate(), 1);
				AbsoluteDread6.AddRecipe();

				ModRecipe AbsoluteDread7 = new ModRecipe(this);
				AbsoluteDread7.AddRecipeGroup("JumpStart:AbsoluteDread", 1);
				AbsoluteDread7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AbsoluteDread7.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab7 = new ItemCheck(ultraniumMod.ItemType("FearStaff"));
				AbsoluteDread7.SetResult(Ab7.Validate(), 1);
				AbsoluteDread7.AddRecipe();

				ModRecipe AbsoluteDread8 = new ModRecipe(this);
				AbsoluteDread8.AddRecipeGroup("JumpStart:AbsoluteDread", 1);
				AbsoluteDread8.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				AbsoluteDread8.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab8 = new ItemCheck(ultraniumMod.ItemType("DreadYoyo"));
				AbsoluteDread8.SetResult(Ab8.Validate(), 1);
				AbsoluteDread8.AddRecipe();

				ModRecipe Erebus1 = new ModRecipe(this);
				Erebus1.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er1 = new ItemCheck(ultraniumMod.ItemType("Caliginus"));
				Erebus1.SetResult(Er1.Validate(), 1);
				Erebus1.AddRecipe();

				ModRecipe Erebus2 = new ModRecipe(this);
				Erebus2.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er2 = new ItemCheck(ultraniumMod.ItemType("CavumNigrum"));
				Erebus2.SetResult(Er2.Validate(), 1);
				Erebus2.AddRecipe();

				ModRecipe Erebus3 = new ModRecipe(this);
				Erebus3.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er3 = new ItemCheck(ultraniumMod.ItemType("Cepus"));
				Erebus3.SetResult(Er3.Validate(), 1);
				Erebus3.AddRecipe();

				ModRecipe Erebus4 = new ModRecipe(this);
				Erebus4.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er4 = new ItemCheck(ultraniumMod.ItemType("ErebusGuitar"));
				Erebus4.SetResult(Er4.Validate(), 1);
				Erebus4.AddRecipe();

				ModRecipe Erebus5 = new ModRecipe(this);
				Erebus5.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er5 = new ItemCheck(ultraniumMod.ItemType("Exitium"));
				Erebus5.SetResult(Er5.Validate(), 1);
				Erebus5.AddRecipe();

				ModRecipe Erebus6 = new ModRecipe(this);
				Erebus6.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus6.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er6 = new ItemCheck(ultraniumMod.ItemType("Inanis"));
				Erebus6.SetResult(Er6.Validate(), 1);
				Erebus6.AddRecipe();

				ModRecipe Erebus7 = new ModRecipe(this);
				Erebus7.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus7.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er7 = new ItemCheck(ultraniumMod.ItemType("Nihil"));
				Erebus7.SetResult(Er7.Validate(), 1);
				Erebus7.AddRecipe();

				ModRecipe Erebus8 = new ModRecipe(this);
				Erebus8.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus8.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus8.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er8 = new ItemCheck(ultraniumMod.ItemType("Noctis"));
				Erebus8.SetResult(Er8.Validate(), 1);
				Erebus8.AddRecipe();

				ModRecipe Erebus9 = new ModRecipe(this);
				Erebus9.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus9.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus9.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er9 = new ItemCheck(ultraniumMod.ItemType("SolibusOrba"));
				Erebus9.SetResult(Er9.Validate(), 1);
				Erebus9.AddRecipe();

				ModRecipe Erebus10 = new ModRecipe(this);
				Erebus10.AddRecipeGroup("JumpStart:Erebus", 1);
				Erebus10.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Erebus10.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Er10 = new ItemCheck(ultraniumMod.ItemType("Umbra"));
				Erebus10.SetResult(Er10.Validate(), 1);
				Erebus10.AddRecipe();

			}
			if (thoriumMod != null && imkSushisMod != null) {
				ModRecipe GrandThunderBird1 = new ModRecipe(this);
				GrandThunderBird1.AddRecipeGroup("JumpStart:GrandThunderBird", 1);
				GrandThunderBird1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GrandThunderBird1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Gr1 = new ItemCheck(thoriumMod.ItemType("HatchlingStaff"));
				GrandThunderBird1.SetResult(Gr1.Validate(), 1);
				GrandThunderBird1.AddRecipe();

				ModRecipe GrandThunderBird2 = new ModRecipe(this);
				GrandThunderBird2.AddRecipeGroup("JumpStart:GrandThunderBird", 1);
				GrandThunderBird2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GrandThunderBird2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Gr2 = new ItemCheck(thoriumMod.ItemType("ThunderTalon"));
				GrandThunderBird2.SetResult(Gr2.Validate(), 1);
				GrandThunderBird2.AddRecipe();

				ModRecipe GrandThunderBird3 = new ModRecipe(this);
				GrandThunderBird3.AddRecipeGroup("JumpStart:GrandThunderBird", 1);
				GrandThunderBird3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GrandThunderBird3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Gr3 = new ItemCheck(thoriumMod.ItemType("Didgeridoo"));
				GrandThunderBird3.SetResult(Gr3.Validate(), 1);
				GrandThunderBird3.AddRecipe();

				ModRecipe GrandThunderBird4 = new ModRecipe(this);
				GrandThunderBird4.AddRecipeGroup("JumpStart:GrandThunderBird", 1);
				GrandThunderBird4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GrandThunderBird4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Gr4 = new ItemCheck(thoriumMod.ItemType("TalonBurst"));
				GrandThunderBird4.SetResult(Gr4.Validate(), 1);
				GrandThunderBird4.AddRecipe();

				ModRecipe QueenJellyfish1 = new ModRecipe(this);
				QueenJellyfish1.AddRecipeGroup("JumpStart:QueenJellyfish", 1);
				QueenJellyfish1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				QueenJellyfish1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Qu1 = new ItemCheck(thoriumMod.ItemType("SparkingJellyBall"));
				QueenJellyfish1.SetResult(Qu1.Validate(), 1);
				QueenJellyfish1.AddRecipe();

				ModRecipe QueenJellyfish2 = new ModRecipe(this);
				QueenJellyfish2.AddRecipeGroup("JumpStart:QueenJellyfish", 1);
				QueenJellyfish2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				QueenJellyfish2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Qu2 = new ItemCheck(thoriumMod.ItemType("BlunderBuss"));
				QueenJellyfish2.SetResult(Qu2.Validate(), 1);
				QueenJellyfish2.AddRecipe();

				ModRecipe QueenJellyfish3 = new ModRecipe(this);
				QueenJellyfish3.AddRecipeGroup("JumpStart:QueenJellyfish", 1);
				QueenJellyfish3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				QueenJellyfish3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Qu3 = new ItemCheck(thoriumMod.ItemType("GiantGlowstick"));
				QueenJellyfish3.SetResult(Qu3.Validate(), 1);
				QueenJellyfish3.AddRecipe();

				ModRecipe QueenJellyfish4 = new ModRecipe(this);
				QueenJellyfish4.AddRecipeGroup("JumpStart:QueenJellyfish", 1);
				QueenJellyfish4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				QueenJellyfish4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Qu4 = new ItemCheck(thoriumMod.ItemType("JellyPondWand"));
				QueenJellyfish4.SetResult(Qu4.Validate(), 1);
				QueenJellyfish4.AddRecipe();

				ModRecipe QueenJellyfish5 = new ModRecipe(this);
				QueenJellyfish5.AddRecipeGroup("JumpStart:QueenJellyfish", 1);
				QueenJellyfish5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				QueenJellyfish5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Qu5 = new ItemCheck(thoriumMod.ItemType("ConchShell"));
				QueenJellyfish5.SetResult(Qu5.Validate(), 1);
				QueenJellyfish5.AddRecipe();

				ModRecipe Viscount1 = new ModRecipe(this);
				Viscount1.AddRecipeGroup("JumpStart:Viscount", 1);
				Viscount1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Viscount1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vi1 = new ItemCheck(thoriumMod.ItemType("BatWing"));
				Viscount1.SetResult(Vi1.Validate(), 1);
				Viscount1.AddRecipe();

				ModRecipe Viscount2 = new ModRecipe(this);
				Viscount2.AddRecipeGroup("JumpStart:Viscount", 1);
				Viscount2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Viscount2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vi2 = new ItemCheck(thoriumMod.ItemType("GuanoGunner"));
				Viscount2.SetResult(Vi2.Validate(), 1);
				Viscount2.AddRecipe();

				ModRecipe Viscount3 = new ModRecipe(this);
				Viscount3.AddRecipeGroup("JumpStart:Viscount", 1);
				Viscount3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Viscount3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vi3 = new ItemCheck(thoriumMod.ItemType("VampireScepter"));
				Viscount3.SetResult(Vi3.Validate(), 1);
				Viscount3.AddRecipe();

				ModRecipe Viscount4 = new ModRecipe(this);
				Viscount4.AddRecipeGroup("JumpStart:Viscount", 1);
				Viscount4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Viscount4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vi4 = new ItemCheck(thoriumMod.ItemType("ViscountCane"));
				Viscount4.SetResult(Vi4.Validate(), 1);
				Viscount4.AddRecipe();

				ModRecipe Viscount5 = new ModRecipe(this);
				Viscount5.AddRecipeGroup("JumpStart:Viscount", 1);
				Viscount5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Viscount5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vi5 = new ItemCheck(thoriumMod.ItemType("BatScythe"));
				Viscount5.SetResult(Vi5.Validate(), 1);
				Viscount5.AddRecipe();

				ModRecipe Viscount6 = new ModRecipe(this);
				Viscount6.AddRecipeGroup("JumpStart:Viscount", 1);
				Viscount6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Viscount6.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vi6 = new ItemCheck(thoriumMod.ItemType("SonarCannon"));
				Viscount6.SetResult(Vi6.Validate(), 1);
				Viscount6.AddRecipe();

				ModRecipe GraniteEnergyStorm1 = new ModRecipe(this);
				GraniteEnergyStorm1.AddRecipeGroup("JumpStart:GraniteEnergyStorm", 1);
				GraniteEnergyStorm1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GraniteEnergyStorm1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ga1 = new ItemCheck(thoriumMod.ItemType("EnergyStormPartisan"));
				GraniteEnergyStorm1.SetResult(Ga1.Validate(), 1);
				GraniteEnergyStorm1.AddRecipe();

				ModRecipe GraniteEnergyStorm2 = new ModRecipe(this);
				GraniteEnergyStorm2.AddRecipeGroup("JumpStart:GraniteEnergyStorm", 1);
				GraniteEnergyStorm2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GraniteEnergyStorm2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ga2 = new ItemCheck(thoriumMod.ItemType("EnergyStormBolter"));
				GraniteEnergyStorm2.SetResult(Ga2.Validate(), 1);
				GraniteEnergyStorm2.AddRecipe();

				ModRecipe GraniteEnergyStorm3 = new ModRecipe(this);
				GraniteEnergyStorm3.AddRecipeGroup("JumpStart:GraniteEnergyStorm", 1);
				GraniteEnergyStorm3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GraniteEnergyStorm3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ga3 = new ItemCheck(thoriumMod.ItemType("EnergyProjector"));
				GraniteEnergyStorm3.SetResult(Ga3.Validate(), 1);
				GraniteEnergyStorm3.AddRecipe();

				ModRecipe GraniteEnergyStorm4 = new ModRecipe(this);
				GraniteEnergyStorm4.AddRecipeGroup("JumpStart:GraniteEnergyStorm", 1);
				GraniteEnergyStorm4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GraniteEnergyStorm4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ga4 = new ItemCheck(thoriumMod.ItemType("BoulderProbe"));
				GraniteEnergyStorm4.SetResult(Ga4.Validate(), 1);
				GraniteEnergyStorm4.AddRecipe();

				ModRecipe GraniteEnergyStorm5 = new ModRecipe(this);
				GraniteEnergyStorm5.AddRecipeGroup("JumpStart:GraniteEnergyStorm", 1);
				GraniteEnergyStorm5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				GraniteEnergyStorm5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ga5 = new ItemCheck(thoriumMod.ItemType("ShockAbsorber"));
				GraniteEnergyStorm5.SetResult(Ga5.Validate(), 1);
				GraniteEnergyStorm5.AddRecipe();

				ModRecipe BuriedChampion1 = new ModRecipe(this);
				BuriedChampion1.AddRecipeGroup("JumpStart:BuriedChampion", 1);
				BuriedChampion1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BuriedChampion1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bu1 = new ItemCheck(thoriumMod.ItemType("ChampionBlade"));
				BuriedChampion1.SetResult(Bu1.Validate(), 1);
				BuriedChampion1.AddRecipe();

				ModRecipe BuriedChampion2 = new ModRecipe(this);
				BuriedChampion2.AddRecipeGroup("JumpStart:BuriedChampion", 1);
				BuriedChampion2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BuriedChampion2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bu2 = new ItemCheck(thoriumMod.ItemType("HeroTripleBow"));
				BuriedChampion2.SetResult(Bu2.Validate(), 1);
				BuriedChampion2.AddRecipe();

				ModRecipe BuriedChampion3 = new ModRecipe(this);
				BuriedChampion3.AddRecipeGroup("JumpStart:BuriedChampion", 1);
				BuriedChampion3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BuriedChampion3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bu3 = new ItemCheck(thoriumMod.ItemType("ChampionBomberStaff"));
				BuriedChampion3.SetResult(Bu3.Validate(), 1);
				BuriedChampion3.AddRecipe();

				ModRecipe BuriedChampion4 = new ModRecipe(this);
				BuriedChampion4.AddRecipeGroup("JumpStart:BuriedChampion", 1);
				BuriedChampion4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BuriedChampion4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bu4 = new ItemCheck(thoriumMod.ItemType("ChampionsGodHand"));
				BuriedChampion4.SetResult(Bu4.Validate(), 1);
				BuriedChampion4.AddRecipe();

				ModRecipe BuriedChampion5 = new ModRecipe(this);
				BuriedChampion5.AddRecipeGroup("JumpStart:BuriedChampion", 1);
				BuriedChampion5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BuriedChampion5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bu5 = new ItemCheck(thoriumMod.ItemType("ChampionsBarrier"));
				BuriedChampion5.SetResult(Bu5.Validate(), 1);
				BuriedChampion5.AddRecipe();

				ModRecipe StarScouter1 = new ModRecipe(this);
				StarScouter1.AddRecipeGroup("JumpStart:StarScouter", 1);
				StarScouter1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				StarScouter1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck St1 = new ItemCheck(thoriumMod.ItemType("Roboboe"));
				StarScouter1.SetResult(St1.Validate(), 1);
				StarScouter1.AddRecipe();

				ModRecipe StarScouter2 = new ModRecipe(this);
				StarScouter2.AddRecipeGroup("JumpStart:StarScouter", 1);
				StarScouter2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				StarScouter2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck St2 = new ItemCheck(thoriumMod.ItemType("StarRod"));
				StarScouter2.SetResult(St2.Validate(), 1);
				StarScouter2.AddRecipe();

				ModRecipe StarScouter3 = new ModRecipe(this);
				StarScouter3.AddRecipeGroup("JumpStart:StarScouter", 1);
				StarScouter3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				StarScouter3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck St3 = new ItemCheck(thoriumMod.ItemType("GaussKnife"));
				StarScouter3.SetResult(St3.Validate(), 1);
				StarScouter3.AddRecipe();

				ModRecipe StarScouter4 = new ModRecipe(this);
				StarScouter4.AddRecipeGroup("JumpStart:StarScouter", 1);
				StarScouter4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				StarScouter4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck St4 = new ItemCheck(thoriumMod.ItemType("DistressCaller"));
				StarScouter4.SetResult(St4.Validate(), 1);
				StarScouter4.AddRecipe();

				ModRecipe StarScouter5 = new ModRecipe(this);
				StarScouter5.AddRecipeGroup("JumpStart:StarScouter", 1);
				StarScouter5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				StarScouter5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck St5 = new ItemCheck(thoriumMod.ItemType("HitScanner"));
				StarScouter5.SetResult(St5.Validate(), 1);
				StarScouter5.AddRecipe();

				ModRecipe StarScouter6 = new ModRecipe(this);
				StarScouter6.AddRecipeGroup("JumpStart:StarScouter", 1);
				StarScouter6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				StarScouter6.AddTile(TileID.TinkerersWorkbench);
				ItemCheck St6 = new ItemCheck(thoriumMod.ItemType("GaussSpark"));
				StarScouter6.SetResult(St6.Validate(), 1);
				StarScouter6.AddRecipe();

				ModRecipe StarScouter7 = new ModRecipe(this);
				StarScouter7.AddRecipeGroup("JumpStart:StarScouter", 1);
				StarScouter7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				StarScouter7.AddTile(TileID.TinkerersWorkbench);
				ItemCheck St7 = new ItemCheck(thoriumMod.ItemType("StarTrail"));
				StarScouter7.SetResult(St7.Validate(), 1);
				StarScouter7.AddRecipe();

				ModRecipe BoreanStrider1 = new ModRecipe(this);
				BoreanStrider1.AddRecipeGroup("JumpStart:BoreanStrider", 1);
				BoreanStrider1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BoreanStrider1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bo1 = new ItemCheck(thoriumMod.ItemType("CryoFang"));
				BoreanStrider1.SetResult(Bo1.Validate(), 1);
				BoreanStrider1.AddRecipe();

				ModRecipe BoreanStrider2 = new ModRecipe(this);
				BoreanStrider2.AddRecipeGroup("JumpStart:BoreanStrider", 1);
				BoreanStrider2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BoreanStrider2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bo2 = new ItemCheck(thoriumMod.ItemType("FreezeRay"));
				BoreanStrider2.SetResult(Bo2.Validate(), 1);
				BoreanStrider2.AddRecipe();

				ModRecipe BoreanStrider3 = new ModRecipe(this);
				BoreanStrider3.AddRecipeGroup("JumpStart:BoreanStrider", 1);
				BoreanStrider3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BoreanStrider3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bo3 = new ItemCheck(thoriumMod.ItemType("FrostFang"));
				BoreanStrider3.SetResult(Bo3.Validate(), 1);
				BoreanStrider3.AddRecipe();

				ModRecipe BoreanStrider4 = new ModRecipe(this);
				BoreanStrider4.AddRecipeGroup("JumpStart:BoreanStrider", 1);
				BoreanStrider4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BoreanStrider4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bo4 = new ItemCheck(thoriumMod.ItemType("GlacierFang"));
				BoreanStrider4.SetResult(Bo4.Validate(), 1);
				BoreanStrider4.AddRecipe();

				ModRecipe BoreanStrider5 = new ModRecipe(this);
				BoreanStrider5.AddRecipeGroup("JumpStart:BoreanStrider", 1);
				BoreanStrider5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				BoreanStrider5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Bo5 = new ItemCheck(thoriumMod.ItemType("GlacialSting"));
				BoreanStrider5.SetResult(Bo5.Validate(), 1);
				BoreanStrider5.AddRecipe();

				ModRecipe FallenBeholder1 = new ModRecipe(this);
				FallenBeholder1.AddRecipeGroup("JumpStart:FallenBeholder", 1);
				FallenBeholder1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FallenBeholder1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fa1 = new ItemCheck(thoriumMod.ItemType("VoidPlanter"));
				FallenBeholder1.SetResult(Fa1.Validate(), 1);
				FallenBeholder1.AddRecipe();

				ModRecipe FallenBeholder2 = new ModRecipe(this);
				FallenBeholder2.AddRecipeGroup("JumpStart:FallenBeholder", 1);
				FallenBeholder2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FallenBeholder2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fa2 = new ItemCheck(thoriumMod.ItemType("BeholderStaff"));
				FallenBeholder2.SetResult(Fa2.Validate(), 1);
				FallenBeholder2.AddRecipe();

				ModRecipe FallenBeholder3 = new ModRecipe(this);
				FallenBeholder3.AddRecipeGroup("JumpStart:FallenBeholder", 1);
				FallenBeholder3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FallenBeholder3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fa3 = new ItemCheck(thoriumMod.ItemType("DevilPauldron"));
				FallenBeholder3.SetResult(Fa3.Validate(), 1);
				FallenBeholder3.AddRecipe();

				ModRecipe FallenBeholder4 = new ModRecipe(this);
				FallenBeholder4.AddRecipeGroup("JumpStart:FallenBeholder", 1);
				FallenBeholder4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FallenBeholder4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fa4 = new ItemCheck(thoriumMod.ItemType("DemonFireBlastWand"));
				FallenBeholder4.SetResult(Fa4.Validate(), 1);
				FallenBeholder4.AddRecipe();

				ModRecipe FallenBeholder5 = new ModRecipe(this);
				FallenBeholder5.AddRecipeGroup("JumpStart:FallenBeholder", 1);
				FallenBeholder5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FallenBeholder5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fa5 = new ItemCheck(thoriumMod.ItemType("Obliterator"));
				FallenBeholder5.SetResult(Fa5.Validate(), 1);
				FallenBeholder5.AddRecipe();

				ModRecipe FallenBeholder6 = new ModRecipe(this);
				FallenBeholder6.AddRecipeGroup("JumpStart:FallenBeholder", 1);
				FallenBeholder6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FallenBeholder6.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fa6 = new ItemCheck(thoriumMod.ItemType("ThermogenicImpaler"));
				FallenBeholder6.SetResult(Fa6.Validate(), 1);
				FallenBeholder6.AddRecipe();

				ModRecipe Lich1 = new ModRecipe(this);
				Lich1.AddRecipeGroup("JumpStart:Lich", 1);
				Lich1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Lich1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Li1 = new ItemCheck(thoriumMod.ItemType("SoulRender"));
				Lich1.SetResult(Li1.Validate(), 1);
				Lich1.AddRecipe();

				ModRecipe Lich2 = new ModRecipe(this);
				Lich2.AddRecipeGroup("JumpStart:Lich", 1);
				Lich2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Lich2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Li2 = new ItemCheck(thoriumMod.ItemType("WitherStaff"));
				Lich2.SetResult(Li2.Validate(), 1);
				Lich2.AddRecipe();

				ModRecipe Lich3 = new ModRecipe(this);
				Lich3.AddRecipeGroup("JumpStart:Lich", 1);
				Lich3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Lich3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Li3 = new ItemCheck(thoriumMod.ItemType("CryptWand"));
				Lich3.SetResult(Li3.Validate(), 1);
				Lich3.AddRecipe();

				ModRecipe Lich4 = new ModRecipe(this);
				Lich4.AddRecipeGroup("JumpStart:Lich", 1);
				Lich4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Lich4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Li4 = new ItemCheck(thoriumMod.ItemType("SoulCleaver"));
				Lich4.SetResult(Li4.Validate(), 1);
				Lich4.AddRecipe();

				ModRecipe Lich5 = new ModRecipe(this);
				Lich5.AddRecipeGroup("JumpStart:Lich", 1);
				Lich5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Lich5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Li5 = new ItemCheck(thoriumMod.ItemType("CadaverCornet"));
				Lich5.SetResult(Li5.Validate(), 1);
				Lich5.AddRecipe();

				ModRecipe Abyssion1 = new ModRecipe(this);
				Abyssion1.AddRecipeGroup("JumpStart:Abyssion", 1);
				Abyssion1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Abyssion1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab1 = new ItemCheck(thoriumMod.ItemType("SirensAllure"));
				Abyssion1.SetResult(Ab1.Validate(), 1);
				Abyssion1.AddRecipe();

				ModRecipe Abyssion2 = new ModRecipe(this);
				Abyssion2.AddRecipeGroup("JumpStart:Abyssion", 1);
				Abyssion2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Abyssion2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab2 = new ItemCheck(thoriumMod.ItemType("OldGodGrasp"));
				Abyssion2.SetResult(Ab2.Validate(), 1);
				Abyssion2.AddRecipe();

				ModRecipe Abyssion3 = new ModRecipe(this);
				Abyssion3.AddRecipeGroup("JumpStart:Abyssion", 1);
				Abyssion3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Abyssion3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab3 = new ItemCheck(thoriumMod.ItemType("TrenchSpitter"));
				Abyssion3.SetResult(Ab3.Validate(), 1);
				Abyssion3.AddRecipe();

				ModRecipe Abyssion4 = new ModRecipe(this);
				Abyssion4.AddRecipeGroup("JumpStart:Abyssion", 1);
				Abyssion4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Abyssion4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab4 = new ItemCheck(thoriumMod.ItemType("MantisPunch"));
				Abyssion4.SetResult(Ab4.Validate(), 1);
				Abyssion4.AddRecipe();

				ModRecipe Abyssion5 = new ModRecipe(this);
				Abyssion5.AddRecipeGroup("JumpStart:Abyssion", 1);
				Abyssion5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Abyssion5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ab5 = new ItemCheck(thoriumMod.ItemType("TheIncubator"));
				Abyssion5.SetResult(Ab5.Validate(), 1);
				Abyssion5.AddRecipe();

			}
			if (sacredToolsMod != null && imkSushisMod != null) {
				
				ModRecipe FlamingPumpkin1 = new ModRecipe(this);
				FlamingPumpkin1.AddRecipeGroup("JumpStart:FlamingPumpkin", 1);
				FlamingPumpkin1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FlamingPumpkin1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fl1 = new ItemCheck(sacredToolsMod.ItemType("PumpGlove"));
				FlamingPumpkin1.SetResult(Fl1.Validate(), 1);
				FlamingPumpkin1.AddRecipe();

				ModRecipe FlamingPumpkin2 = new ModRecipe(this);
				FlamingPumpkin2.AddRecipeGroup("JumpStart:FlamingPumpkin", 1);
				FlamingPumpkin2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FlamingPumpkin2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fl2 = new ItemCheck(sacredToolsMod.ItemType("PumpYoyo"));
				FlamingPumpkin2.SetResult(Fl2.Validate(), 1);
				FlamingPumpkin2.AddRecipe();

				ModRecipe FlamingPumpkin3 = new ModRecipe(this);
				FlamingPumpkin3.AddRecipeGroup("JumpStart:FlamingPumpkin", 1);
				FlamingPumpkin3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				FlamingPumpkin3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Fl3 = new ItemCheck(sacredToolsMod.ItemType("MoodSummon"));
				FlamingPumpkin3.SetResult(Fl3.Validate(), 1);
				FlamingPumpkin3.AddRecipe();


				ModRecipe ZombiePiglinBrute1 = new ModRecipe(this);
				ZombiePiglinBrute1.AddRecipeGroup("JumpStart:ZombiePiglinBrute", 1);
				ZombiePiglinBrute1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				ZombiePiglinBrute1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Zo1 = new ItemCheck(sacredToolsMod.ItemType("Sausbow"));
				ZombiePiglinBrute1.SetResult(Zo1.Validate(), 1);
				ZombiePiglinBrute1.AddRecipe();

				ModRecipe ZombiePiglinBrute2 = new ModRecipe(this);
				ZombiePiglinBrute2.AddRecipeGroup("JumpStart:ZombiePiglinBrute", 1);
				ZombiePiglinBrute2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				ZombiePiglinBrute2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Zo2 = new ItemCheck(sacredToolsMod.ItemType("Ribarang"));
				ZombiePiglinBrute2.SetResult(Zo2.Validate(), 1);
				ZombiePiglinBrute2.AddRecipe();

				ModRecipe ZombiePiglinBrute3 = new ModRecipe(this);
				ZombiePiglinBrute3.AddRecipeGroup("JumpStart:ZombiePiglinBrute", 1);
				ZombiePiglinBrute3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				ZombiePiglinBrute3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Zo3 = new ItemCheck(sacredToolsMod.ItemType("DeadVoxel"));
				ZombiePiglinBrute3.SetResult(Zo3.Validate(), 1);
				ZombiePiglinBrute3.AddRecipe();

				ModRecipe ZombiePiglinBrute4 = new ModRecipe(this);
				ZombiePiglinBrute4.AddRecipeGroup("JumpStart:ZombiePiglinBrute", 1);
				ZombiePiglinBrute4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				ZombiePiglinBrute4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Zo4 = new ItemCheck(sacredToolsMod.ItemType("MissingFury"));
				ZombiePiglinBrute4.SetResult(Zo4.Validate(), 1);
				ZombiePiglinBrute4.AddRecipe();

				
				ModRecipe Araneas1 = new ModRecipe(this);
				Araneas1.AddRecipeGroup("JumpStart:Araneas", 1);
				Araneas1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Araneas1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ar1 = new ItemCheck(sacredToolsMod.ItemType("ArachnesGaze"));
				Araneas1.SetResult(Ar1.Validate(), 1);
				Araneas1.AddRecipe();

				ModRecipe Araneas2 = new ModRecipe(this);
				Araneas2.AddRecipeGroup("JumpStart:Araneas", 1);
				Araneas2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Araneas2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ar2 = new ItemCheck(sacredToolsMod.ItemType("HoariHemonga"));
				Araneas2.SetResult(Ar2.Validate(), 1);
				Araneas2.AddRecipe();

				ModRecipe Araneas3 = new ModRecipe(this);
				Araneas3.AddRecipeGroup("JumpStart:Araneas", 1);
				Araneas3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Araneas3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ar3 = new ItemCheck(sacredToolsMod.ItemType("RazorfangDagger"));
				Araneas3.SetResult(Ar3.Validate(), 1);
				Araneas3.AddRecipe();

				ModRecipe Araneas4 = new ModRecipe(this);
				Araneas4.AddRecipeGroup("JumpStart:Araneas", 1);
				Araneas4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Araneas4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ar4 = new ItemCheck(sacredToolsMod.ItemType("SanguineumVirgam"));
				Araneas4.SetResult(Ar4.Validate(), 1);
				Araneas4.AddRecipe();


				ModRecipe TheLostSiblings1 = new ModRecipe(this);
				TheLostSiblings1.AddRecipeGroup("JumpStart:TheLostSiblings", 1);
				TheLostSiblings1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				TheLostSiblings1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th1 = new ItemCheck(sacredToolsMod.ItemType("BlindJustice"));
				TheLostSiblings1.SetResult(Th1.Validate(), 1);
				TheLostSiblings1.AddRecipe();

				ModRecipe TheLostSiblings2 = new ModRecipe(this);
				TheLostSiblings2.AddRecipeGroup("JumpStart:TheLostSiblings", 1);
				TheLostSiblings2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				TheLostSiblings2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th2 = new ItemCheck(sacredToolsMod.ItemType("StarScourge"));
				TheLostSiblings2.SetResult(Th2.Validate(), 1);
				TheLostSiblings2.AddRecipe();

				ModRecipe TheLostSiblings3 = new ModRecipe(this);
				TheLostSiblings3.AddRecipeGroup("JumpStart:TheLostSiblings", 1);
				TheLostSiblings3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				TheLostSiblings3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th3 = new ItemCheck(sacredToolsMod.ItemType("CosmicCloudBracelet"));
				TheLostSiblings3.SetResult(Th3.Validate(), 1);
				TheLostSiblings3.AddRecipe();

				ModRecipe TheLostSiblings4 = new ModRecipe(this);
				TheLostSiblings4.AddRecipeGroup("JumpStart:TheLostSiblings", 1);
				TheLostSiblings4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				TheLostSiblings4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th4 = new ItemCheck(sacredToolsMod.ItemType("LightningRifle"));
				TheLostSiblings4.SetResult(Th4.Validate(), 1);
				TheLostSiblings4.AddRecipe();

				ModRecipe TheLostSiblings5 = new ModRecipe(this);
				TheLostSiblings5.AddRecipeGroup("JumpStart:TheLostSiblings", 1);
				TheLostSiblings5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				TheLostSiblings5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th5 = new ItemCheck(sacredToolsMod.ItemType("AsteroidShower"));
				TheLostSiblings5.SetResult(Th5.Validate(), 1);
				TheLostSiblings5.AddRecipe();
			}
			if (redemptionMod != null && imkSushisMod != null) {
				
				
				ModRecipe Thorn1 = new ModRecipe(this);
				Thorn1.AddRecipeGroup("JumpStart:Thorn", 1);
				Thorn1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Thorn1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th1 = new ItemCheck(redemptionMod.ItemType("CursedGrassSword"));
				Thorn1.SetResult(Th1.Validate(), 1);
				Thorn1.AddRecipe();

				ModRecipe Thorn2 = new ModRecipe(this);
				Thorn2.AddRecipeGroup("JumpStart:Thorn", 1);
				Thorn2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Thorn2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th2 = new ItemCheck(redemptionMod.ItemType("CursedThornBow"));
				Thorn2.SetResult(Th2.Validate(), 1);
				Thorn2.AddRecipe();
					
				ModRecipe Thorn3 = new ModRecipe(this);
				Thorn3.AddRecipeGroup("JumpStart:Thorn", 1);
				Thorn3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Thorn3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th3 = new ItemCheck(redemptionMod.ItemType("RootTendril"));
				Thorn3.SetResult(Th3.Validate(), 1);
				Thorn3.AddRecipe();
					
				ModRecipe Thorn4 = new ModRecipe(this);
				Thorn4.AddRecipeGroup("JumpStart:Thorn", 1);
				Thorn4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Thorn4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Th4 = new ItemCheck(redemptionMod.ItemType("ThornSeedBag"));
				Thorn4.SetResult(Th4.Validate(), 1);
				Thorn4.AddRecipe();

					
				ModRecipe Keeper1 = new ModRecipe(this);
				Keeper1.AddRecipeGroup("JumpStart:Keeper", 1);
				Keeper1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Keeper1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ke1 = new ItemCheck(redemptionMod.ItemType("KeepersBow"));
				Keeper1.SetResult(Ke1.Validate(), 1);
				Keeper1.AddRecipe();
					
				ModRecipe Keeper2 = new ModRecipe(this);
				Keeper2.AddRecipeGroup("JumpStart:Keeper", 1);
				Keeper2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Keeper2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ke2 = new ItemCheck(redemptionMod.ItemType("KeepersSummon"));
				Keeper2.SetResult(Ke2.Validate(), 1);
				Keeper2.AddRecipe();

				ModRecipe Keeper3 = new ModRecipe(this);
				Keeper3.AddRecipeGroup("JumpStart:Keeper", 1);
				Keeper3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Keeper3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ke3 = new ItemCheck(redemptionMod.ItemType("KeepersKnife"));
				Keeper3.SetResult(Ke3.Validate(), 1);
				Keeper3.AddRecipe();

				ModRecipe Keeper4 = new ModRecipe(this);
				Keeper4.AddRecipeGroup("JumpStart:Keeper", 1);
				Keeper4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Keeper4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ke4 = new ItemCheck(redemptionMod.ItemType("KeepersClaw"));
				Keeper4.SetResult(Ke4.Validate(), 1);
				Keeper4.AddRecipe();

				ModRecipe Keeper5 = new ModRecipe(this);
				Keeper5.AddRecipeGroup("JumpStart:Keeper", 1);
				Keeper5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Keeper5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ke5 = new ItemCheck(redemptionMod.ItemType("KeepersStaff"));
				Keeper5.SetResult(Ke5.Validate(), 1);
				Keeper5.AddRecipe();
					
				
				ModRecipe SeedOfInfection1 = new ModRecipe(this);
				SeedOfInfection1.AddRecipeGroup("JumpStart:SeedOfInfection", 1);
				SeedOfInfection1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				SeedOfInfection1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Se1 = new ItemCheck(redemptionMod.ItemType("XenoCanister"));
				SeedOfInfection1.SetResult(Se1.Validate(), 1);
				SeedOfInfection1.AddRecipe();
					
				ModRecipe SeedOfInfection2 = new ModRecipe(this);
				SeedOfInfection2.AddRecipeGroup("JumpStart:SeedOfInfection", 1);
				SeedOfInfection2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				SeedOfInfection2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Se2 = new ItemCheck(redemptionMod.ItemType("XenomiteGlaive"));
				SeedOfInfection2.SetResult(Se2.Validate(), 1);
				SeedOfInfection2.AddRecipe();
					
				ModRecipe SeedOfInfection3 = new ModRecipe(this);
				SeedOfInfection3.AddRecipeGroup("JumpStart:SeedOfInfection", 1);
				SeedOfInfection3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				SeedOfInfection3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Se3 = new ItemCheck(redemptionMod.ItemType("XenomiteYoyo"));
				SeedOfInfection3.SetResult(Se3.Validate(), 1);
				SeedOfInfection3.AddRecipe();
					
				
				ModRecipe InfectedEye1 = new ModRecipe(this);
				InfectedEye1.AddRecipeGroup("JumpStart:InfectedEye", 1);
				InfectedEye1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				InfectedEye1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck In1 = new ItemCheck(redemptionMod.ItemType("TheInfectedEye"));
				InfectedEye1.SetResult(In1.Validate(), 1);
				InfectedEye1.AddRecipe();

				ModRecipe InfectedEye2 = new ModRecipe(this);
				InfectedEye2.AddRecipeGroup("JumpStart:InfectedEye", 1);
				InfectedEye2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				InfectedEye2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck In2 = new ItemCheck(redemptionMod.ItemType("XenomiteStaff"));
				InfectedEye2.SetResult(In2.Validate(), 1);
				InfectedEye2.AddRecipe();

				ModRecipe InfectedEye3 = new ModRecipe(this);
				InfectedEye3.AddRecipeGroup("JumpStart:InfectedEye", 1);
				InfectedEye3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				InfectedEye3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck In3 = new ItemCheck(redemptionMod.ItemType("InfectousJavelin"));
				InfectedEye3.SetResult(In3.Validate(), 1);
				InfectedEye3.AddRecipe();
				
				ModRecipe KingSlayerIII1 = new ModRecipe(this);
				KingSlayerIII1.AddRecipeGroup("JumpStart:KingSlayerIII", 1);
				KingSlayerIII1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				KingSlayerIII1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ki1 = new ItemCheck(redemptionMod.ItemType("SlayerFlamethrower"));
				KingSlayerIII1.SetResult(Ki1.Validate(), 1);
				KingSlayerIII1.AddRecipe();

				ModRecipe KingSlayerIII2 = new ModRecipe(this);
				KingSlayerIII2.AddRecipeGroup("JumpStart:KingSlayerIII", 1);
				KingSlayerIII2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				KingSlayerIII2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ki2 = new ItemCheck(redemptionMod.ItemType("SlayerNanogun"));
				KingSlayerIII2.SetResult(Ki2.Validate(), 1);
				KingSlayerIII2.AddRecipe();

				ModRecipe KingSlayerIII3 = new ModRecipe(this);
				KingSlayerIII3.AddRecipeGroup("JumpStart:KingSlayerIII", 1);
				KingSlayerIII3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				KingSlayerIII3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ki3 = new ItemCheck(redemptionMod.ItemType("SlayerFist"));
				KingSlayerIII3.SetResult(Ki3.Validate(), 1);
				KingSlayerIII3.AddRecipe();

				ModRecipe KingSlayerIII4 = new ModRecipe(this);
				KingSlayerIII4.AddRecipeGroup("JumpStart:KingSlayerIII", 1);
				KingSlayerIII4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				KingSlayerIII4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ki4 = new ItemCheck(redemptionMod.ItemType("SlayerGun"));
				KingSlayerIII4.SetResult(Ki4.Validate(), 1);
				KingSlayerIII4.AddRecipe();
				
				ModRecipe VlitchCleaver1 = new ModRecipe(this);
				VlitchCleaver1.AddRecipeGroup("JumpStart:VlitchCleaver", 1);
				VlitchCleaver1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				VlitchCleaver1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vl1 = new ItemCheck(redemptionMod.ItemType("GirusLance"));
				VlitchCleaver1.SetResult(Vl1.Validate(), 1);
				VlitchCleaver1.AddRecipe();

				ModRecipe VlitchCleaver2 = new ModRecipe(this);
				VlitchCleaver2.AddRecipeGroup("JumpStart:VlitchCleaver", 1);
				VlitchCleaver2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				VlitchCleaver2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vl2 = new ItemCheck(redemptionMod.ItemType("GirusDagger"));
				VlitchCleaver2.SetResult(Vl2.Validate(), 1);
				VlitchCleaver2.AddRecipe();

				ModRecipe VlitchCleaver3 = new ModRecipe(this);
				VlitchCleaver3.AddRecipeGroup("JumpStart:VlitchCleaver", 1);
				VlitchCleaver3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				VlitchCleaver3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vl3 = new ItemCheck(redemptionMod.ItemType("GirusDaggerThrown"));
				VlitchCleaver3.SetResult(Vl3.Validate(), 1);
				VlitchCleaver3.AddRecipe();
				
				ModRecipe VlitchGigapede1 = new ModRecipe(this);
				VlitchGigapede1.AddRecipeGroup("JumpStart:VlitchGigapede", 1);
				VlitchGigapede1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				VlitchGigapede1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vl4 = new ItemCheck(redemptionMod.ItemType("CorruptedDoubleRifle"));
				VlitchGigapede1.SetResult(Vl4.Validate(), 1);
				VlitchGigapede1.AddRecipe();

				ModRecipe VlitchGigapede2 = new ModRecipe(this);
				VlitchGigapede2.AddRecipeGroup("JumpStart:VlitchGigapede", 1);
				VlitchGigapede2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				VlitchGigapede2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Vl5 = new ItemCheck(redemptionMod.ItemType("CorruptedRocketLauncher"));
				VlitchGigapede2.SetResult(Vl5.Validate(), 1);
				VlitchGigapede2.AddRecipe();
				
				ModRecipe OmegaObliterator1 = new ModRecipe(this);
				OmegaObliterator1.AddRecipeGroup("JumpStart:OmegaObliterator", 1);
				OmegaObliterator1.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				OmegaObliterator1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Om1 = new ItemCheck(redemptionMod.ItemType("PlasmaJawser"));
				OmegaObliterator1.SetResult(Om1.Validate(), 1);
				OmegaObliterator1.AddRecipe();

				ModRecipe OmegaObliterator2 = new ModRecipe(this);
				OmegaObliterator2.AddRecipeGroup("JumpStart:OmegaObliterator", 1);
				OmegaObliterator2.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				OmegaObliterator2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Om2 = new ItemCheck(redemptionMod.ItemType("OmegaClaw"));
				OmegaObliterator2.SetResult(Om2.Validate(), 1);
				OmegaObliterator2.AddRecipe();

				ModRecipe OmegaObliterator3 = new ModRecipe(this);
				OmegaObliterator3.AddRecipeGroup("JumpStart:OmegaObliterator", 1);
				OmegaObliterator3.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				OmegaObliterator3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Om3 = new ItemCheck(redemptionMod.ItemType("GloopContainer"));
				OmegaObliterator3.SetResult(Om3.Validate(), 1);
				OmegaObliterator3.AddRecipe();
				
				ModRecipe PatientZero1 = new ModRecipe(this);
				PatientZero1.AddRecipeGroup("JumpStart:PatientZero", 1);
				PatientZero1.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				PatientZero1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Pa1 = new ItemCheck(redemptionMod.ItemType("PZGauntlet"));
				PatientZero1.SetResult(Pa1.Validate(), 1);
				PatientZero1.AddRecipe();

				ModRecipe PatientZero2 = new ModRecipe(this);
				PatientZero2.AddRecipeGroup("JumpStart:PatientZero", 1);
				PatientZero2.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				PatientZero2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Pa2 = new ItemCheck(redemptionMod.ItemType("SwarmerGun"));
				PatientZero2.SetResult(Pa2.Validate(), 1);
				PatientZero2.AddRecipe();

				ModRecipe PatientZero3 = new ModRecipe(this);
				PatientZero3.AddRecipeGroup("JumpStart:PatientZero", 1);
				PatientZero3.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				PatientZero3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Pa3 = new ItemCheck(redemptionMod.ItemType("XeniumSaber"));
				PatientZero3.SetResult(Pa3.Validate(), 1);
				PatientZero3.AddRecipe();
				
				ModRecipe AncientDeityDuo1 = new ModRecipe(this);
				AncientDeityDuo1.AddRecipeGroup("JumpStart:AncientDeityDuo", 1);
				AncientDeityDuo1.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				AncientDeityDuo1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck An1 = new ItemCheck(redemptionMod.ItemType("CursedThornFlail"));
				AncientDeityDuo1.SetResult(An1.Validate(), 1);
				AncientDeityDuo1.AddRecipe();

				ModRecipe AncientDeityDuo2 = new ModRecipe(this);
				AncientDeityDuo2.AddRecipeGroup("JumpStart:AncientDeityDuo", 1);
				AncientDeityDuo2.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				AncientDeityDuo2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck An2 = new ItemCheck(redemptionMod.ItemType("CursedThornBow2"));
				AncientDeityDuo2.SetResult(An2.Validate(), 1);
				AncientDeityDuo2.AddRecipe();

				ModRecipe AncientDeityDuo3 = new ModRecipe(this);
				AncientDeityDuo3.AddRecipeGroup("JumpStart:AncientDeityDuo", 1);
				AncientDeityDuo3.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				AncientDeityDuo3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck An3 = new ItemCheck(redemptionMod.ItemType("EaglecrestGlove"));
				AncientDeityDuo3.SetResult(An3.Validate(), 1);
				AncientDeityDuo3.AddRecipe();

				ModRecipe AncientDeityDuo4 = new ModRecipe(this);
				AncientDeityDuo4.AddRecipeGroup("JumpStart:AncientDeityDuo", 1);
				AncientDeityDuo4.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				AncientDeityDuo4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck An4 = new ItemCheck(redemptionMod.ItemType("StonePuppet"));
				AncientDeityDuo4.SetResult(An4.Validate(), 1);
				AncientDeityDuo4.AddRecipe();

				ModRecipe AncientDeityDuo5 = new ModRecipe(this);
				AncientDeityDuo5.AddRecipeGroup("JumpStart:AncientDeityDuo", 1);
				AncientDeityDuo5.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				AncientDeityDuo5.AddTile(TileID.TinkerersWorkbench);
				ItemCheck An5 = new ItemCheck(redemptionMod.ItemType("AncientPowerStave"));
				AncientDeityDuo5.SetResult(An5.Validate(), 1);
				AncientDeityDuo5.AddRecipe();
				
		
				ModRecipe Nebuleus1 = new ModRecipe(this);
				Nebuleus1.AddRecipeGroup("JumpStart:Nebuleus", 1);
				Nebuleus1.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				Nebuleus1.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ne1 = new ItemCheck(redemptionMod.ItemType("CosmosChainWeapon"));
				Nebuleus1.SetResult(Ne1.Validate(), 1);
				Nebuleus1.AddRecipe();

				ModRecipe Nebuleus2 = new ModRecipe(this);
				Nebuleus2.AddRecipeGroup("JumpStart:Nebuleus", 1);
				Nebuleus2.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				Nebuleus2.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ne2 = new ItemCheck(redemptionMod.ItemType("FreedomStarN"));
				Nebuleus2.SetResult(Ne2.Validate(), 1);
				Nebuleus2.AddRecipe();

				ModRecipe Nebuleus3 = new ModRecipe(this);
				Nebuleus3.AddRecipeGroup("JumpStart:Nebuleus", 1);
				Nebuleus3.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				Nebuleus3.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ne3 = new ItemCheck(redemptionMod.ItemType("StarfruitSeedbag"));
				Nebuleus3.SetResult(Ne3.Validate(), 1);
				Nebuleus3.AddRecipe();

				ModRecipe Nebuleus4 = new ModRecipe(this);
				Nebuleus4.AddRecipeGroup("JumpStart:Nebuleus", 1);
				Nebuleus4.AddIngredient(imkSushisMod.ItemType("SwapToken"));
				Nebuleus4.AddTile(TileID.TinkerersWorkbench);
				ItemCheck Ne4 = new ItemCheck(redemptionMod.ItemType("ConstellationsBook"));
				Nebuleus4.SetResult(Ne4.Validate(), 1);
				Nebuleus4.AddRecipe();
			}

			if (spiritMod != null && imkSushisMod != null) {

				//Scarabeus
				if (RecipeGroups.Contains("Scarabeus"))
				{
					ModRecipe Scarabeus1 = new ModRecipe(this);
					Scarabeus1.AddRecipeGroup("JumpStart:Scarabeus", 1);
					Scarabeus1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Scarabeus1.AddTile(TileID.TinkerersWorkbench);
					Scarabeus1.SetResult(spiritMod.ItemType("ScarabSword"), 1);
					Scarabeus1.AddRecipe();

					ModRecipe Scarabeus2 = new ModRecipe(this);
					Scarabeus2.AddRecipeGroup("JumpStart:Scarabeus", 1);
					Scarabeus2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Scarabeus2.AddTile(TileID.TinkerersWorkbench);
					Scarabeus2.SetResult(spiritMod.ItemType("ScarabBow"), 1);
					Scarabeus2.AddRecipe();

					ModRecipe Scarabeus3 = new ModRecipe(this);
					Scarabeus3.AddRecipeGroup("JumpStart:Scarabeus", 1);
					Scarabeus3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Scarabeus3.AddTile(TileID.TinkerersWorkbench);
					Scarabeus3.SetResult(spiritMod.ItemType("OrnateStaff"), 1);
					Scarabeus3.AddRecipe();
				}
				
				if (RecipeGroups.Contains("MoonJellyWizard"))
				{
					//Moon Jelly Wizard
					ModRecipe MoonJellyWizard1 = new ModRecipe(this);
					MoonJellyWizard1.AddRecipeGroup("JumpStart:MoonJellyWizard", 1);
					MoonJellyWizard1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					MoonJellyWizard1.AddTile(TileID.TinkerersWorkbench);
					MoonJellyWizard1.SetResult(spiritMod.ItemType("Moonshot"), 1);
					MoonJellyWizard1.AddRecipe();

					ModRecipe MoonJellyWizard2 = new ModRecipe(this);
					MoonJellyWizard2.AddRecipeGroup("JumpStart:MoonJellyWizard", 1);
					MoonJellyWizard2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					MoonJellyWizard2.AddTile(TileID.TinkerersWorkbench);
					MoonJellyWizard2.SetResult(spiritMod.ItemType("Moonburst"), 1);
					MoonJellyWizard2.AddRecipe();

					ModRecipe MoonJellyWizard3 = new ModRecipe(this);
					MoonJellyWizard3.AddRecipeGroup("JumpStart:MoonJellyWizard", 1);
					MoonJellyWizard3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					MoonJellyWizard3.AddTile(TileID.TinkerersWorkbench);
					MoonJellyWizard3.SetResult(spiritMod.ItemType("MoonjellySummonStaff"), 1);
					MoonJellyWizard3.AddRecipe();

					ModRecipe MoonJellyWizard4 = new ModRecipe(this);
					MoonJellyWizard4.AddRecipeGroup("JumpStart:MoonJellyWizard", 1);
					MoonJellyWizard4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					MoonJellyWizard4.AddTile(TileID.TinkerersWorkbench);
					MoonJellyWizard4.SetResult(spiritMod.ItemType("JellynautBubble"), 1);
					MoonJellyWizard4.AddRecipe();
				}
				
				if (RecipeGroups.Contains("Vinewrath"))
				{
					//Vinewrath Bane
					ModRecipe VinewrathBane1 = new ModRecipe(this);
					VinewrathBane1.AddRecipeGroup("JumpStart:Vinewrath");
					VinewrathBane1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					VinewrathBane1.AddTile(TileID.TinkerersWorkbench);
					VinewrathBane1.SetResult(spiritMod.ItemType("ReachBossSword"), 1);
					VinewrathBane1.AddRecipe();

					ModRecipe VinewrathBane2 = new ModRecipe(this);
					VinewrathBane2.AddRecipeGroup("JumpStart:Vinewrath");
					VinewrathBane2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					VinewrathBane2.AddTile(TileID.TinkerersWorkbench);
					VinewrathBane2.SetResult(spiritMod.ItemType("ThornBow"), 1);
					VinewrathBane2.AddRecipe();

					ModRecipe VinewrathBane3 = new ModRecipe(this);
					VinewrathBane3.AddRecipeGroup("JumpStart:Vinewrath");
					VinewrathBane3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					VinewrathBane3.AddTile(TileID.TinkerersWorkbench);
					VinewrathBane3.SetResult(spiritMod.ItemType("SunbeamStaff"), 1);
					VinewrathBane3.AddRecipe();

					ModRecipe VinewrathBane4 = new ModRecipe(this);
					VinewrathBane4.AddRecipeGroup("JumpStart:Vinewrath");
					VinewrathBane4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					VinewrathBane4.AddTile(TileID.TinkerersWorkbench);
					VinewrathBane4.SetResult(spiritMod.ItemType("ReachVineStaff"), 1);
					VinewrathBane4.AddRecipe();

					ModRecipe VinewrathBane5 = new ModRecipe(this);
					VinewrathBane5.AddRecipeGroup("JumpStart:Vinewrath", 1);
					VinewrathBane5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					VinewrathBane5.AddTile(TileID.TinkerersWorkbench);
					VinewrathBane5.SetResult(spiritMod.ItemType("ReachKnife"), 1);
					VinewrathBane5.AddRecipe();
				}
				

				if (RecipeGroups.Contains("AncientAvian"))
				{
					//Ancient Avian
					ModRecipe AncientAvian1 = new ModRecipe(this);
					AncientAvian1.AddRecipeGroup("JumpStart:AncientAvian", 1);
					AncientAvian1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					AncientAvian1.AddTile(TileID.TinkerersWorkbench);
					AncientAvian1.SetResult(spiritMod.ItemType("TalonPiercer"), 1);
					AncientAvian1.AddRecipe();

					ModRecipe AncientAvian2 = new ModRecipe(this);
					AncientAvian2.AddRecipeGroup("JumpStart:AncientAvian", 1);
					AncientAvian2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					AncientAvian2.AddTile(TileID.TinkerersWorkbench);
					AncientAvian2.SetResult(spiritMod.ItemType("Talonginus"), 1);
					AncientAvian2.AddRecipe();

					ModRecipe AncientAvian3 = new ModRecipe(this);
					AncientAvian3.AddRecipeGroup("JumpStart:AncientAvian", 1);
					AncientAvian3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					AncientAvian3.AddTile(TileID.TinkerersWorkbench);
					AncientAvian3.SetResult(spiritMod.ItemType("SkeletalonStaff"), 1);
					AncientAvian3.AddRecipe();

					ModRecipe AncientAvian4 = new ModRecipe(this);
					AncientAvian4.AddRecipeGroup("JumpStart:AncientAvian", 1);
					AncientAvian4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					AncientAvian4.AddTile(TileID.TinkerersWorkbench);
					AncientAvian4.SetResult(spiritMod.ItemType("TalonBlade"), 1);
					AncientAvian4.AddRecipe();

					ModRecipe AncientAvian5 = new ModRecipe(this);
					AncientAvian5.AddRecipeGroup("JumpStart:AncientAvian", 1);
					AncientAvian5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					AncientAvian5.AddTile(TileID.TinkerersWorkbench);
					AncientAvian5.SetResult(spiritMod.ItemType("SoaringScapula"), 1);
					AncientAvian5.AddRecipe();
				}
				if (RecipeGroups.Contains("SnowMonger"))
				{
					//Snow Monger
					ModRecipe SnowMonger1 = new ModRecipe(this);
					SnowMonger1.AddRecipeGroup("JumpStart:SnowMonger", 1);
					SnowMonger1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					SnowMonger1.AddTile(TileID.TinkerersWorkbench);
					SnowMonger1.SetResult(spiritMod.ItemType("BlizzardEdge"), 1);
					SnowMonger1.AddRecipe();

					ModRecipe SnowMonger2 = new ModRecipe(this);
					SnowMonger2.AddRecipeGroup("JumpStart:SnowMonger", 1);
					SnowMonger2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					SnowMonger2.AddTile(TileID.TinkerersWorkbench);
					SnowMonger2.SetResult(spiritMod.ItemType("ShiverWind"), 1);
					SnowMonger2.AddRecipe();

					ModRecipe SnowMonger3 = new ModRecipe(this);
					SnowMonger3.AddRecipeGroup("JumpStart:SnowMonger", 1);
					SnowMonger3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					SnowMonger3.AddTile(TileID.TinkerersWorkbench);
					SnowMonger3.SetResult(spiritMod.ItemType("Chillrend"), 1);
					SnowMonger3.AddRecipe();

					ModRecipe SnowMonger4 = new ModRecipe(this);
					SnowMonger4.AddRecipeGroup("JumpStart:SnowMonger", 1);
					SnowMonger4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					SnowMonger4.AddTile(TileID.TinkerersWorkbench);
					SnowMonger4.SetResult(spiritMod.ItemType("Bauble"), 1);
					SnowMonger4.AddRecipe();
				}
				if (RecipeGroups.Contains("LavaventElemental"))
				{
					//Lavavent Elemental
					ModRecipe LavaventElemental1 = new ModRecipe(this);
					LavaventElemental1.AddRecipeGroup("JumpStart:LavaventElemental", 1);
					LavaventElemental1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					LavaventElemental1.AddTile(TileID.TinkerersWorkbench);
					LavaventElemental1.SetResult(spiritMod.ItemType("FierySoul"), 1);
					LavaventElemental1.AddRecipe();

					ModRecipe LavaventElemental2 = new ModRecipe(this);
					LavaventElemental2.AddRecipeGroup("JumpStart:LavaventElemental", 1);
					LavaventElemental2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					LavaventElemental2.AddTile(TileID.TinkerersWorkbench);
					LavaventElemental2.SetResult(spiritMod.ItemType("LavaStaff"), 1);
					LavaventElemental2.AddRecipe();

					ModRecipe LavaventElemental3 = new ModRecipe(this);
					LavaventElemental3.AddRecipeGroup("JumpStart:LavaventElemental", 1);
					LavaventElemental3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					LavaventElemental3.AddTile(TileID.TinkerersWorkbench);
					LavaventElemental3.SetResult(spiritMod.ItemType("LavaSpear"), 1);
					LavaventElemental3.AddRecipe();
				}
				if (RecipeGroups.Contains("Infernon"))
				{
					//Infernon
					ModRecipe Infernon1 = new ModRecipe(this);
					Infernon1.AddRecipeGroup("JumpStart:Infernon", 1);
					Infernon1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Infernon1.AddTile(TileID.TinkerersWorkbench);
					Infernon1.SetResult(spiritMod.ItemType("InfernalSword"), 1);
					Infernon1.AddRecipe();

					ModRecipe Infernon2 = new ModRecipe(this);
					Infernon2.AddRecipeGroup("JumpStart:Infernon", 1);
					Infernon2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Infernon2.AddTile(TileID.TinkerersWorkbench);
					Infernon2.SetResult(spiritMod.ItemType("SevenSins"), 1);
					Infernon2.AddRecipe();

					ModRecipe Infernon3 = new ModRecipe(this);
					Infernon3.AddRecipeGroup("JumpStart:Infernon", 1);
					Infernon3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Infernon3.AddTile(TileID.TinkerersWorkbench);
					Infernon3.SetResult(spiritMod.ItemType("InfernalStaff"), 1);
					Infernon3.AddRecipe();

					ModRecipe Infernon4 = new ModRecipe(this);
					Infernon4.AddRecipeGroup("JumpStart:Infernon", 1);
					Infernon4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Infernon4.AddTile(TileID.TinkerersWorkbench);
					Infernon4.SetResult(spiritMod.ItemType("EyeOfTheInferno"), 1);
					Infernon4.AddRecipe();

					ModRecipe Infernon5 = new ModRecipe(this);
					Infernon5.AddRecipeGroup("JumpStart:Infernon", 1);
					Infernon5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Infernon5.AddTile(TileID.TinkerersWorkbench);
					Infernon5.SetResult(spiritMod.ItemType("InfernalJavelin"), 1);
					Infernon5.AddRecipe();

					ModRecipe Infernon6 = new ModRecipe(this);
					Infernon6.AddRecipeGroup("JumpStart:Infernon", 1);
					Infernon6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Infernon6.AddTile(TileID.TinkerersWorkbench);
					Infernon6.SetResult(spiritMod.ItemType("InfernalShield"), 1);
					Infernon6.AddRecipe();

					ModRecipe Infernon7 = new ModRecipe(this);
					Infernon7.AddRecipeGroup("JumpStart:Infernon", 1);
					Infernon7.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Infernon7.AddTile(TileID.TinkerersWorkbench);
					Infernon7.SetResult(spiritMod.ItemType("DiabolicHorn"), 1);
					Infernon7.AddRecipe();
				}
				if (RecipeGroups.Contains("Dusking"))
				{
					//Dusking
					ModRecipe Dusking1 = new ModRecipe(this);
					Dusking1.AddRecipeGroup("JumpStart:Dusking", 1);
					Dusking1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Dusking1.AddTile(TileID.TinkerersWorkbench);
					Dusking1.SetResult(spiritMod.ItemType("ShadowflameSword"), 1);
					Dusking1.AddRecipe();

					ModRecipe Dusking2 = new ModRecipe(this);
					Dusking2.AddRecipeGroup("JumpStart:Dusking", 1);
					Dusking2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Dusking2.AddTile(TileID.TinkerersWorkbench);
					Dusking2.SetResult(spiritMod.ItemType("Shadowmoor"), 1);
					Dusking2.AddRecipe();

					ModRecipe Dusking3 = new ModRecipe(this);
					Dusking3.AddRecipeGroup("JumpStart:Dusking", 1);
					Dusking3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Dusking3.AddTile(TileID.TinkerersWorkbench);
					Dusking3.SetResult(spiritMod.ItemType("UmbraStaff"), 1);
					Dusking3.AddRecipe();

					ModRecipe Dusking4 = new ModRecipe(this);
					Dusking4.AddRecipeGroup("JumpStart:Dusking", 1);
					Dusking4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Dusking4.AddTile(TileID.TinkerersWorkbench);
					Dusking4.SetResult(spiritMod.ItemType("ShadowSphere"), 1);
					Dusking4.AddRecipe();
				}
				if (RecipeGroups.Contains("Atlas"))
				{
					//Atlas
					ModRecipe Atlas1 = new ModRecipe(this);
					Atlas1.AddRecipeGroup("JumpStart:Atlas", 1);
					Atlas1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Atlas1.AddTile(TileID.TinkerersWorkbench);
					Atlas1.SetResult(spiritMod.ItemType("Mountain"), 1);
					Atlas1.AddRecipe();

					ModRecipe Atlas2 = new ModRecipe(this);
					Atlas2.AddRecipeGroup("JumpStart:Atlas", 1);
					Atlas2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Atlas2.AddTile(TileID.TinkerersWorkbench);
					Atlas2.SetResult(spiritMod.ItemType("Earthshatter"), 1);
					Atlas2.AddRecipe();

					ModRecipe Atlas3 = new ModRecipe(this);
					Atlas3.AddRecipeGroup("JumpStart:Atlas", 1);
					Atlas3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Atlas3.AddTile(TileID.TinkerersWorkbench);
					Atlas3.SetResult(spiritMod.ItemType("QuakeFist"), 1);
					Atlas3.AddRecipe();

					ModRecipe Atlas4 = new ModRecipe(this);
					Atlas4.AddRecipeGroup("JumpStart:Atlas", 1);
					Atlas4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Atlas4.AddTile(TileID.TinkerersWorkbench);
					Atlas4.SetResult(spiritMod.ItemType("CragboundStaff"), 1);
					Atlas4.AddRecipe();

					ModRecipe Atlas5 = new ModRecipe(this);
					Atlas5.AddRecipeGroup("JumpStart:Atlas", 1);
					Atlas5.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Atlas5.AddTile(TileID.TinkerersWorkbench);
					Atlas5.SetResult(spiritMod.ItemType("KingRock"), 1);
					Atlas5.AddRecipe();

					ModRecipe Atlas6 = new ModRecipe(this);
					Atlas6.AddRecipeGroup("JumpStart:Atlas", 1);
					Atlas6.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Atlas6.AddTile(TileID.TinkerersWorkbench);
					Atlas6.SetResult(spiritMod.ItemType("TitanboundBulwark"), 1);
					Atlas6.AddRecipe();
				}
				if (RecipeGroups.Contains("Overseer"))
				{
					//Overseer
					ModRecipe Overseer1 = new ModRecipe(this);
					Overseer1.AddRecipeGroup("JumpStart:Overseer", 1);
					Overseer1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Overseer1.AddTile(TileID.TinkerersWorkbench);
					Overseer1.SetResult(spiritMod.ItemType("EssenseTearer"), 1);
					Overseer1.AddRecipe();

					ModRecipe Overseer2 = new ModRecipe(this);
					Overseer2.AddRecipeGroup("JumpStart:Overseer", 1);
					Overseer2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Overseer2.AddTile(TileID.TinkerersWorkbench);
					Overseer2.SetResult(spiritMod.ItemType("Eternity"), 1);
					Overseer2.AddRecipe();

					ModRecipe Overseer3 = new ModRecipe(this);
					Overseer3.AddRecipeGroup("JumpStart:Overseer", 1);
					Overseer3.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Overseer3.AddTile(TileID.TinkerersWorkbench);
					Overseer3.SetResult(spiritMod.ItemType("SoulExpulsor"), 1);
					Overseer3.AddRecipe();

					ModRecipe Overseer4 = new ModRecipe(this);
					Overseer4.AddRecipeGroup("JumpStart:Overseer", 1);
					Overseer4.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Overseer4.AddTile(TileID.TinkerersWorkbench);
					Overseer4.SetResult(spiritMod.ItemType("AeonRipper"), 1);
					Overseer4.AddRecipe();
				}
				if (RecipeGroups.Contains("Rlyehian"))
				{
					//Rlyehian
					ModRecipe Rlyehian1 = new ModRecipe(this);
					Rlyehian1.AddRecipeGroup("JumpStart:Rlyehian", 1);
					Rlyehian1.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Rlyehian1.AddTile(TileID.TinkerersWorkbench);
					Rlyehian1.SetResult(spiritMod.ItemType("TomeOfRylien"), 1);
					Rlyehian1.AddRecipe();

					ModRecipe Rlyehian2 = new ModRecipe(this);
					Rlyehian2.AddRecipeGroup("JumpStart:Rlyehian", 1);
					Rlyehian2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
					Rlyehian2.AddTile(TileID.TinkerersWorkbench);
					Rlyehian2.SetResult(spiritMod.ItemType("TentacleChain"), 1);
					Rlyehian2.AddRecipe();
				}
			}

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


				//Hard mode
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
				PlaguebringerGoliath2.SetResult(calamityMod.ItemType("MepheticSprayer"), 1);
				PlaguebringerGoliath2.AddRecipe();

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
				PlaguebringerGoliath6.SetResult(calamityMod.ItemType("VirulentKatana"), 1);
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
				PlaguebringerGoliath10.SetResult(calamityMod.ItemType("ThePlaguebringer"), 1);
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
				Providence6.SetResult(calamityMod.ItemType("TelluricGlare"), 1);
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
				Yharon1.SetResult(calamityMod.ItemType("AngryChickenStaff"), 1);
				Yharon1.AddRecipe();

				ModRecipe Yharon2 = new ModRecipe(this);
				Yharon2.AddRecipeGroup("JumpStart:Yharon", 1);
				Yharon2.AddIngredient(imkSushisMod.ItemType("SwapToken"), 1);
				Yharon2.AddTile(TileID.TinkerersWorkbench);
				Yharon2.SetResult(calamityMod.ItemType("FinalDawn"), 1);
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
				Yharon4.SetResult(calamityMod.ItemType("PhoenixFlameBarrage"), 1);
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
				Yharon6.SetResult(calamityMod.ItemType("ProfanedTrident"), 1);
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
			
			}
        }
    }
}