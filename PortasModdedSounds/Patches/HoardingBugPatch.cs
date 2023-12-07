using HarmonyLib;
using UnityEngine;

namespace PortasModdedSounds.Patches
{
    [HarmonyPatch(typeof(HoarderBugAI))]
    public class HoardingBugPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPrefix]
        public static void Prefix(ref AudioClip[] ___chitterSFX, ref AudioClip ___angryVoiceSFX)
        {
            AudioClip[] newList = new AudioClip[3];
            newList[0] = ModBase.Instance.assets.bug1;
            newList[1] = ModBase.Instance.assets.bug2;
            newList[2] = ModBase.Instance.assets.bug3;
            ___chitterSFX = newList; 
            ___angryVoiceSFX = ModBase.Instance.assets.bugFly;
        }
    }
}