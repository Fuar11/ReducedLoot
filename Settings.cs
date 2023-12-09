using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedLoot
{
    internal class CustomSettings : JsonModSettings
    {

        [Section("Gear Despawn Percentages")]

        [Name("Hatchet")]
        [Description("Percent chance to despawn hatchets when they are spawned in.")]
        [Slider(0, 100)]
        public int HatchetChance = 75;

        [Name("Hunting Knife")]
        [Description("Percent chance to despawn hunting knives when they are spawned in.")]
        [Slider(0, 100)]
        public int KnifeChance = 75;

        [Name("Storm Lantern")]
        [Description("Percent chance to despawn storm lanterns when they are spawned in.")]
        [Slider(0, 100)]
        public int LanternChance = 75;

        [Name("Lantern Fuel")]
        [Description("Percent chance to despawn lantern fuel canisters when they are spawned in.")]
        [Slider(0, 100)]
        public int LanternFuelChance = 40;

        [Name("Jerry Can")]
        [Description("Percent chance to despawn jerry cans when they are spawned in.")]
        [Slider(0, 100)]
        public int JerryCanChance = 50;

        [Name("Prybar")]
        [Description("Percent chance to despawn prybars when they are spawned in.")]
        [Slider(0, 100)]
        public int PrybarChance = 55;

        [Name("Revolver")]
        [Description("Percent chance to despawn revolvers when they are spawned in.")]
        [Slider(0, 100)]
        public int RevolverChance = 75;

        [Name("Revolver Ammo Box")]
        [Description("Percent chance to despawn revolver ammunition boxes when they are spawned in.")]
        [Slider(0, 100)]
        public int RevolverAmmoBoxChance = 85;

        [Name("Revolver Ammo")]
        [Description("Percent chance to despawn revolver rounds when they are spawned in.")]
        [Slider(0, 100)]
        public int RevolverAmmoChance = 11;

        [Name("Hunting Rifle")]
        [Description("Percent chance to despawn rifles when they are spawned in.")]
        [Slider(0, 100)]
        public int RifleChance = 40;

        [Name("Rifle Ammo Box")]
        [Description("Percent chance to despawn rifle ammo boxes when they are spawned in.")]
        [Slider(0, 100)]
        public int RifleAmmoBoxChance = 45;

        [Name("Rifle Ammo")]
        [Description("Percent chance to despawn rifle rounds when they are spawned in.")]
        [Slider(0, 100)]
        public int RifleAmmoChance = 15;

        [Name("Vaughn's Rifle")]
        [Description("Percent chance to despawn Vaughn's rifle when it is spawned in.")]
        [Slider(0, 100)]
        public int VaughnRifleChance = 70;

        [Name("Curator's Rifle")]
        [Description("Percent chance to despawn Curator's rifle when it is spawned in.")]
        [Slider(0, 100)]
        public int CuratorRifleChance = 50;

        [Name("Barb's Rifle")]
        [Description("Percent chance to despawn Barb's rifle when it is spawned in.")]
        [Slider(0, 100)]
        public int BarbRifleChance = 50;

        [Name("Distress Pistol")]
        [Description("Percent chance to despawn flare guns when they are spawned in.")]
        [Slider(0, 100)]
        public int FlareGunChance = 75;

        [Name("Flare Shell")]
        [Description("NOT IMPLEMENTED YET")]
        [Slider(0, 100)]
        public int FlareShellChance = 65;

        [Name("Flare")]
        [Description("Percent chance to despawn flares when they are spawned in.")]
        [Slider(0, 100)]
        public int FlareChance = 65;

        [Name("Marine Flare")]
        [Description("Percent chance to despawn marine flares when they are spawned in.")]
        [Slider(0, 100)]
        public int MarineFlareChance = 45;

        [Name("Survival Bow")]
        [Description("Percent chance to despawn bows when they are spawned in.")]
        [Slider(0, 100)]
        public int BowChance = 60;

        [Name("Simple Arrow")]
        [Description("Percent chance to despawn arrows when they are spawned in.")]
        [Slider(0, 100)]
        public int ArrowChance = 75;

        [Name("Whetstone")]
        [Description("Percent chance to despawn whetstones when they are spawned in.")]
        [Slider(0, 100)]
        public int WhetstoneChance = 55;

        [Name("Sewing Kit")]
        [Description("Percent chance to despawn sewing kits when they are spawned in.")]
        [Slider(0, 100)]
        public int SewingKitChance = 40;

        [Name("Firearm Cleaning Kit")]
        [Description("Percent chance to despawn gun cleaning kits when they are spawned in.")]
        [Slider(0, 100)]
        public int CleaningKitChance = 60;

        [Name("Wood Matches")]
        [Description("Percent chance to despawn wood matches when they are spawned in.")]
        [Slider(0, 100)]
        public int WoodMatchesChance = 30;

        [Name("Cardboard Matches")]
        [Description("Percent chance to despawn cardboard matches when they are spawned in.")]
        [Slider(0, 100)]
        public int CardboardMatchesChance = 40;

        [Name("MRE")]
        [Description("Percent chance to despawn MREs when they are spawned in.")]
        [Slider(0, 100)]
        public int MREChance = 80;

        [Name("Energy Bar")]
        [Description("Percent chance to despawn energy bars when they are spawned in.")]
        [Slider(0, 100)]
        public int EnergyBarChance = 30;

        [Name("Emergency Stim")]
        [Description("Percent chance to despawn stims when they are spawned in.")]
        [Slider(0, 100)]
        public int StimChance = 40;

        [Name("Painkillers")]
        [Description("Percent chance to despawn painkillers when they are spawned in.")]
        [Slider(0, 100)]
        public int PainkillerChance = 75;

        [Name("Antibiotics")]
        [Description("Percent chance to despawn antibiotics when they are spawned in.")]
        [Slider(0, 100)]
        public int AntibioticChance = 60;

        [Name("Antiseptic")]
        [Description("Percent chance to despawn antiseptic when they are spawned in.")]
        [Slider(0, 100)]
        public int AntisepticChance = 40;

        [Name("Accelerant")]
        [Description("Percent chance to despawn accelerants when they are spawned in.")]
        [Slider(0, 100)]
        public int AccelerantChance = 30;

        [Name("Coffee Tin")]
        [Description("Percent chance to despawn coffee tins when they are spawned in.")]
        [Slider(0, 100)]
        public int CoffeeTinChance = 45;

        [Name("Coffee Cup")]
        [Description("Percent chance to despawn coffee cups when they are spawned in.")]
        [Slider(0, 100)]
        public int CoffeeCupChance = 30;

        [Name("Herbal Tea")]
        [Description("Percent chance to despawn tea packages when they are spawned in.")]
        [Slider(0, 100)]
        public int TeaChance = 10;

        [Name("Oats")]
        [Description("Percent chance to despawn oats when they are spawned in.")]
        [Slider(0, 100)]
        public int OatsChance = 50;

        [Name("Spray Paint")]
        [Description("Percent chance to despawn spray paint cans when they are spawned in.")]
        [Slider(0, 100)]
        public int PaintChance = 50;

        [Name("Expedition Parka")]
        [Description("Percent chance to despawn expedition parkas when they are spawned in.")]
        [Slider(0, 100)]
        public int ExpeditionParkaChance = 85;

        [Name("Rabbitskin Hat")]
        [Description("Percent chance to despawn rabbitskin hat when they are spawned in.")]
        [Slider(0, 100)]
        public int RabbitskinHatChance = 90;

        [Name("Rabbitskin Mitts")]
        [Description("Percent chance to despawn rabbitskin mittens when they are spawned in.")]
        [Slider(0, 100)]
        public int RabbitskinMittsChance = 85;

        [Name("Flight Jacket")]
        [Description("Percent chance to despawn flight jackets when they are spawned in.")]
        [Slider(0, 100)]
        public int FlightJacketChance = 80;

        [Name("Aviator Cap")]
        [Description("Percent chance to despawn aviator caps when they are spawned in.")]
        [Slider(0, 100)]
        public int AviatorCapChance = 87;

        [Name("Gauntlets")]
        [Description("Percent chance to despawn gauntlets when they are spawned in.")]
        [Slider(0, 100)]
        public int GauntletsChance = 80;

        [Name("Heavy Wool Sweater")]
        [Description("Percent chance to despawn heavy wool sweaters when they are spawned in.")]
        [Slider(0, 100)]
        public int HeavyWoolSweaterChance = 40;

        [Name("Thin Wool Sweater")]
        [Description("Percent chance to despawn thin wool sweaters when they are spawned in.")]
        [Slider(0, 100)]
        public int ThinWoolSweaterChance = 40;

        [Name("Fisherman's Sweater")]
        [Description("Percent chance to despawn fisherman's sweaters when they are spawned in.")]
        [Slider(0, 100)]
        public int FishermanSweaterChance = 70;

        [Name("Climbing Socks")]
        [Description("Percent chance to despawn climbing socks when they are spawned in.")]
        [Slider(0, 100)]
        public int ClimbingSocksChance = 65;

        [Name("Wool Socks")]
        [Description("Percent chance to despawn wool socks when they are spawned in.")]
        [Slider(0, 100)]
        public int WoolSocksChance = 40;

        [Name("Combat Pants")]
        [Description("Percent chance to despawn combat pants when they are spawned in.")]
        [Slider(0, 100)]
        public int CombatPantsChance = 70;

        [Name("Wool Toque")]
        [Description("Percent chance to despawn wool toques when they are spawned in.")]
        [Slider(0, 100)]
        public int ToqueChance = 70;

        [Name("Insulated Boots")]
        [Description("Percent chance to despawn insulated boots when they are spawned in.")]
        [Slider(0, 100)]
        public int InsulatedBootsChance = 70;

        [Name("Cargo Pants")]
        [Description("Percent chance to despawn cargo pants when they are spawned in.")]
        [Slider(0, 100)]
        public int CargoPantsChance = 75;

        [Name("Snow Pants")]
        [Description("Percent chance to despawn snow pants when they are spawned in.")]
        [Slider(0, 100)]
        public int SnowPantsChance = 80;

        [Name("Simple Parka")]
        [Description("Percent chance to despawn simple parkas when they are spawned in.")]
        [Slider(0, 100)]
        public int SimpleParkaChance = 60;
    }
    static class Settings
    {
        internal static CustomSettings settings;
        internal static void OnLoad()
        {
            settings = new CustomSettings();
            settings.AddToModSettings("Reduced Loot");
        }
    }

}
