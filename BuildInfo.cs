﻿namespace ReducedLoot
{
    public static class BuildInfo
    {
        /* NOTES
            These must all be constant types. So cant use string.Empty
        */
        #region Mandatory
        /// <summary>The machine readable name of the mod (no special characters or spaces)</summary>
        public const string Name                            = "ReducedLoot";
        /// <summary>Who made the mod</summary>
        public const string Author                          = "Fuar";
        /// <summary>Current version (Using Major.Minor.Build) </summary>
        public const string Version                         = "1.2.0";
        /// <summary>Name used on GUI's, like ModSettings</summary>
        public const string GUIName                         = "Reduced Loot";
        /// <summary>The minimum Melon Loader version that your mod requires</summary>
        public const string MelonLoaderVersion              = "0.6.1";
        #endregion

        #region Optional
        /// <summary>What the mod does</summary>
        public const string Description                     = null;
        /// <summary>Company that made it</summary>
        public const string Company                         = null;
        /// <summary>A valid download link</summary>
        public const string DownloadLink                    = null;
        /// <summary>Copyright info</summary>
        /// <remarks>When updating the year, use the StartYear-CurrentYear format eg(Copyright © 2020-2023)</remarks>
        public const string Copyright                       = "Copyright ©Fuar 2023";
        /// <summary>Trademark info</summary>
        public const string Trademark                       = null;
        /// <summary>Product Name (Generally use the Name)</summary>
        public const string Product                         = "Reduced Loot";
        /// <summary>Culture info</summary>
        public const string Culture                         = null;
        /// <summary>Priority of your mod. Most of the time you should not need to change this</summary>
        public const int Priority                           = 0;
        #endregion
    }
}
