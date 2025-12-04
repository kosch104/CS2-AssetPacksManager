using System;
using System.IO;
using Game;
using Game.Modding;
using Colossal.Logging;
using Colossal.PSI.Environment;

namespace AssetPacksManager
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger("AssetPacksManager");

        public void OnLoad(UpdateSystem updateSystem)
        {
            try
            {
                var modsDataPath = Path.Combine(EnvPath.kUserDataPath, "ModsData", "AssetPacksManager");
                if (Directory.Exists(modsDataPath))
                {
                    log.Info("Loading Final Version of Asset Packs Manager Mod");
                    Directory.Delete(modsDataPath, true);
                    log.Info("Deleted Asset Packs Manager ModsData to prevent conflicts. It will no longer be used. Thank you everyone, it's been an honor. Asset Packs Manager signing off.");
                }
            }
            catch (Exception e)
            {
                log.Warn("Error while trying to delete Asset Packs Manager ModsData folder: " + e);
            }
        }

        public void OnDispose()
        {

        }

    }
}