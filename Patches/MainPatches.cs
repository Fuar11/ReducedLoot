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
                
                if(__instance.m_HasBeenEquippedAndUsed || __instance.m_BeenInPlayerInventory || __instance.m_InPlayerInventory || __instance.m_ItemLooted)
                {
                    return;
                }

                /**
                SaveDataManager sdm = Main.sdm;

                if (sdm.LoadSceneData(GameManager.m_ActiveScene) != null)
                {
                    return;
                }
                **/

                if(IsGameScene() && !GameManager.m_SceneWasRestored)
                {
                    float chance = Utils.GetDespawnChance(__instance.name);
                    if (Il2Cpp.Utils.RollChance(chance))
                    {
                        Destroy(__instance.gameObject);
                    }
                }
            }

            public static bool IsGameScene(string? sceneName = null)
            {
                sceneName = string.IsNullOrEmpty(sceneName) ? Name().ToLowerInvariant() : sceneName.ToLowerInvariant();
                if (
                    GameManager.BOOT.ToLowerInvariant() == sceneName
                    || GameManager.EMPTY.ToLowerInvariant() == sceneName
                    || GameManager.GetTargetMainMenuSceneName().ToLowerInvariant() == sceneName
                    || string.IsNullOrEmpty(sceneName)
                    )
                {
                    return false;
                }
                return true;
            }

            public static string Name()
            {
                return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            }
        }

        [HarmonyPatch(typeof(Container), nameof(Container.PopulateWithRandomGear))]

        public class ItemInContainerRemover
        {

            public static void Postfix(Container __instance)
            {

                for(int i = 0; i < __instance.m_GearToInstantiate.Count; i++)
                {
                    string name = __instance.m_GearToInstantiate[i].GetComponent<GearItem>().name;
                    float chance = Utils.GetDespawnChance(__instance.m_GearToInstantiate[i].GetComponent<GearItem>().name);
                    
                    if (Il2Cpp.Utils.RollChance(chance))
                    {
                        __instance.m_GearToInstantiate.RemoveAt(i);
                    } 
                }
            }

        }

    }
}
