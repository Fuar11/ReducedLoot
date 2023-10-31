using ReducedLoot.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2Cpp;
using System.Collections;

namespace ReducedLoot.Patches
{
    internal class MainPatches : MonoBehaviour
    {
        [HarmonyPatch(typeof(QualitySettingsManager), nameof(QualitySettingsManager.ApplyCurrentQualitySettings))]

        public class SaveScene
        {

            private static void Prefix()
            {
                MelonCoroutines.Start(CheckAndSaveSceneData());
            }

            private static IEnumerator CheckAndSaveSceneData()
            {
                SaveDataManager sdm = Main.sdm;

                if (sdm.LoadSceneData(GameManager.m_ActiveScene) == null)
                {
                    float waitSeconds = 1f;
                    for (float t = 0f; t < waitSeconds; t += Time.deltaTime) yield return null;
                    sdm.Save(GameManager.m_ActiveScene, GameManager.m_ActiveScene);
                }

            }
        }

        [HarmonyPatch(typeof(GearItem), nameof(GearItem.ManualStart))]

        public class ItemRemover
        {
            private static void Prefix(GearItem __instance)
            {
                
                if(__instance.m_HasBeenOwnedByPlayer || __instance.m_HasBeenEquippedAndUsed || __instance.m_BeenInPlayerInventory || __instance.m_InPlayerInventory || __instance.m_ItemLooted)
                {
                    return;
                }

                SaveDataManager sdm = Main.sdm;

                if (sdm.LoadSceneData(GameManager.m_ActiveScene) != null)
                {
                    return;
                }


                float chance = Utils.GetDespawnChance(__instance.name);
                if (Il2Cpp.Utils.RollChance(chance))
                {
                    Destroy(__instance.gameObject);
                }
            }

        }

    }
}
