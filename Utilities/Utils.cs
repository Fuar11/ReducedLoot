namespace ReducedLoot
{
    internal class Utils
    {
       public static float GetDespawnChance(string itemName)
        {
            switch (itemName)
            {
                case "GEAR_Hatchet":
                    return 75;
                case "GEAR_Knife":
                    return 75;
                case "GEAR_KeroseneLampB":
                    return 75;
                case "GEAR_Prybar":
                    return 40;
                case "GEAR_SimpleTools":
                    return 35;
                case "GEAR_HighQualityTools":
                    return 45;
                case "GEAR_RifleCleaningKit":
                    return 60;
                case "GEAR_SharpeningStone":
                    return 55;
                case "GEAR_SewingKit":
                    return 20;
                case "GEAR_LampFuel":
                    return 40;
                case "GEAR_LampFuelFull":
                    return 50;
                //case "GEAR_FlareGunAmmoSingle":
              //   return 65;
                case "GEAR_Revolver":
                    return 65;
                case "GEAR_RevolverAmmoBox":
                    return 75;
                case "GEAR_RevolverAmmoSingle":
                    return 11; //personal touch
                case "GEAR_Rifle":
                    return 50;
                case "GEAR_RifleAmmoBox":
                    return 45;
                case "GEAR_RifleAmmoSingle":
                    return 15;
                case "GEAR_FlareGun":
                    return 75;
                case "GEAR_FlareA":
                    return 55;
                case "GEAR_PackMatches":
                    return 40;
                case "GEAR_WoodMatches":
                    return 30;
                case "GEAR_MRE":
                    return 80;
                case "GEAR_EnergyBar":
                    return 30;
                case "GEAR_EmergencyStim":
                    return 40;
                case "GEAR_BottlePainKillers":
                    return 75;
                case "GEAR_BottleAntibiotics":
                    return 60;
                case "GEAR_BottleHydrogenPeroxide":
                    return 40;
                case "GEAR_Accelerant":
                    return 30;
                case "GEAR_CoffeeTin":
                    return 45;
                case "GEAR_CoffeeCup":
                    return 30;
                case "GEAR_GreenTeaPackage":
                    return 10;
                case "GEAR_OatsTin":
                    return 50;
                case "GEAR_SprayPaintCan":
                    return 50;
                default:
                    return 0;
            }
        }
    }
}