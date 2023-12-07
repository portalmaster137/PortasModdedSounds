using HarmonyLib;
using UnityEngine;

namespace PortasModdedSounds.Patches
{
    [HarmonyPatch(typeof(JesterAI))]
    public class JackintheboxPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPrefix]
        public static void Prefix(ref AudioClip ___popGoesTheWeaselTheme)
        {
            ___popGoesTheWeaselTheme = ModBase.Instance.assets.jackbox;
        }
    }
}