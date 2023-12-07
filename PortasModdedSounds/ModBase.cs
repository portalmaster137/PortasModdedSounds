using System;
using System.Linq;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace PortasModdedSounds
{
    public interface ISoundPatch
    {
        void RegisterPatch();
    }
    [BepInPlugin(GUID, NAME, VERSION)]
    public class ModBase : BaseUnityPlugin
    {
        private const string GUID = "com.porta137.portamoddedsounds";
        private const string NAME = "PortaModdedSounds";
        private const string VERSION = "1.0.0";
        public Harmony harmony = new Harmony(GUID);
        public static ModBase Instance;
        internal ManualLogSource MLS;
        public string AssetBundlePath;
        public AssetBundle assetBundle;
        public AudioAssets assets;

        private void Awake()
        {
            if (!Instance) Instance = this;
            MLS = BepInEx.Logging.Logger.CreateLogSource(GUID);
            MLS.LogInfo("Loading Portas Modded Sounds");
            
            AssetBundlePath = Instance.Info.Location.TrimEnd("PortasModdedSounds.dll".ToCharArray()) + "bundle";
            MLS.LogInfo("Using AssetBundlePath: " + AssetBundlePath);
            assetBundle = AssetBundle.LoadFromFile(AssetBundlePath);
            if (assetBundle == null)
            {
                MLS.LogError("Failed to load AssetBundle, mod loading aborted.");
                return;
            }
            MLS.LogInfo("Loading AudioAssets");
            assets = AssetLoader.Load();
            
            MLS.LogInfo("Bundle loaded, patching...");
            harmony.PatchAll();
            
            MLS.LogInfo("Mod loading Complete!");

        }
    }
}