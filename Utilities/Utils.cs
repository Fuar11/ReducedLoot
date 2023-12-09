namespace ReducedLoot
{
    internal class Utils
    {
       public static float GetDespawnChance(string itemName)
        {
            switch (itemName)
            {
                case "GEAR_Hatchet":
                    return Settings.settings.HatchetChance;
                case "GEAR_Knife":
                    return Settings.settings.KnifeChance;
                case "GEAR_KeroseneLampB":
                    return Settings.settings.LanternChance;
                case "GEAR_Prybar":
                    return Settings.settings.PrybarChance;
                case "GEAR_SimpleTools":
                    return 35;
                case "GEAR_HighQualityTools":
                    return 45;
                case "GEAR_RifleCleaningKit":
                    return Settings.settings.CleaningKitChance; 
                case "GEAR_SharpeningStone":
                    return Settings.settings.WhetstoneChance;
                case "GEAR_SewingKit":
                    return Settings.settings.SewingKitChance;
                case "GEAR_LampFuel":
                    return Settings.settings.LanternFuelChance;
                case "GEAR_LampFuelFull":
                    return Settings.settings.JerryCanChance;
                //case "GEAR_FlareGunAmmoSingle":
              //   return 65;
                case "GEAR_Revolver":
                    return Settings.settings.RevolverChance;
                case "GEAR_RevolverAmmoBox":
                    return Settings.settings.RevolverAmmoBoxChance;
                case "GEAR_RevolverAmmoSingle":
                    return Settings.settings.RevolverAmmoChance;
                case "GEAR_Rifle":
                    return Settings.settings.RifleChance; 
                case "GEAR_RifleAmmoBox":
                    return Settings.settings.RifleAmmoBoxChance;
                case "GEAR_RifleAmmoSingle":
                    return Settings.settings.RifleAmmoChance;
                case "GEAR_Rifle_Vaughns":
                    return Settings.settings.VaughnRifleChance;
                case "GEAR_Rifle_Curators":
                    return Settings.settings.CuratorRifleChance;
                case "GEAR_Rifle_Barbs":
                    return Settings.settings.BarbRifleChance;
                case "GEAR_FlareGun":
                    return Settings.settings.FlareGunChance;
                case "GEAR_FlareA":
                    return Settings.settings.FlareChance;
                case "GEAR_BlueFlare":
                    return Settings.settings.MarineFlareChance;
                case "GEAR_Bow":
                    return Settings.settings.BowChance;
                case "GEAR_Arrow":
                    return Settings.settings.ArrowChance;
                case "GEAR_PackMatches":
                    return Settings.settings.CardboardMatchesChance;
                case "GEAR_WoodMatches":
                    return Settings.settings.WoodMatchesChance;
                case "GEAR_MRE":
                    return Settings.settings.MREChance;
                case "GEAR_EnergyBar":
                    return Settings.settings.EnergyBarChance;
                case "GEAR_EmergencyStim":
                    return Settings.settings.StimChance;
                case "GEAR_BottlePainKillers":
                    return Settings.settings.PainkillerChance;
                case "GEAR_BottleAntibiotics":
                    return Settings.settings.AntibioticChance;
                case "GEAR_BottleHydrogenPeroxide":
                    return Settings.settings.AntisepticChance;
                case "GEAR_Accelerant":
                    return Settings.settings.AccelerantChance;
                case "GEAR_CoffeeTin":
                    return Settings.settings.CoffeeTinChance;
                case "GEAR_CoffeeCup":
                    return Settings.settings.CoffeeCupChance;
                case "GEAR_GreenTeaPackage":
                    return Settings.settings.TeaChance;
                case "GEAR_OatsTin":
                    return Settings.settings.OatsChance;
                case "GEAR_SprayPaintCan":
                    return 50;
                case "GEAR_PremiumWinterCoat":
                    return Settings.settings.ExpeditionParkaChance;
                case "GEAR_RabbitskinHat":
                    return Settings.settings.RabbitskinHatChance;
                case "GEAR_RabbitskinMittens":
                    return Settings.settings.RabbitskinMittsChance;
                case "GEAR_JacketLeatherFlightA":
                    return Settings.settings.FlightJacketChance;
                case "GEAR_HatLeatherAviatorA":
                    return Settings.settings.AviatorCapChance;
                case "GEAR_Gauntlets":
                    return Settings.settings.GauntletsChance;
                case "GEAR_HeavyWoolSweater":
                    return Settings.settings.HeavyWoolSweaterChance;
                case "GEAR_FishermanSweater":
                    return Settings.settings.FishermanSweaterChance;
                case "GEAR_ClimbingSocks":
                    return Settings.settings.ClimbingSocksChance;
                case "GEAR_CombatPants":
                    return Settings.settings.CombatPantsChance;
                case "GEAR_WoolSocks":
                    return Settings.settings.WoolSocksChance;
                case "GEAR_WoolSweater":
                    return Settings.settings.ThinWoolSweaterChance;
                case "GEAR_Toque":
                    return Settings.settings.ToqueChance;
                case "GEAR_InsulatedBoots":
                    return Settings.settings.InsulatedBootsChance;
                case "GEAR_CargoPants":
                    return Settings.settings.CargoPantsChance;
                case "GEAR_InsulatedPants":
                    return Settings.settings.SnowPantsChance;
                case "GEAR_DownParka":
                    return Settings.settings.SimpleParkaChance;
                default:
                    return 10;
            }
        }
    }
}