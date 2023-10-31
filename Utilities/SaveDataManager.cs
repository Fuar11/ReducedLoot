﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedLoot.Utilities
{
    internal class SaveDataManager
    {

        ModDataManager dm = new ModDataManager("Reduced Loot", false);

        public void Save(string data, string suffix)
        {
            dm.Save(data, suffix);
        }

        public string LoadSceneData(string suffix)
        {
            string? sceneName = dm.Load(suffix);

            return sceneName;
        }

    }
}
