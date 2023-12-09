using ReducedLoot.Utilities;

namespace ReducedLoot
{
    public class Main : MelonMod
    {
        internal static SaveDataManager sdm = new SaveDataManager();
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Reduced Loot is online!");
            Settings.OnLoad();
        }
    }
}
