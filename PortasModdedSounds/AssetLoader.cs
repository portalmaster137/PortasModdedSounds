using UnityEngine;

namespace PortasModdedSounds
{
    public struct AudioAssets
    {
        public AudioClip jackbox;
        public AudioClip bug1;
        public AudioClip bug2;
        public AudioClip bug3;
        public AudioClip bugFly;

        public AudioAssets(AudioClip jackbox, AudioClip bug1, AudioClip bug2, AudioClip bug3, AudioClip bugFly)
        {
            this.jackbox = jackbox;
            this.bug1 = bug1;
            this.bug2 = bug2;
            this.bug3 = bug3;
            this.bugFly = bugFly;
        }
    }
    
    public static class AssetLoader
    {
        public static AudioAssets Load()
        {
            var Jackbox = ModBase.Instance.assetBundle.LoadAsset<AudioClip>("Assets/March.mp3");
            var Bug1 = ModBase.Instance.assetBundle.LoadAsset<AudioClip>("Assets/Bug1.mp3");
            var Bug2 = ModBase.Instance.assetBundle.LoadAsset<AudioClip>("Assets/Bug2.mp3");
            var Bug3 = ModBase.Instance.assetBundle.LoadAsset<AudioClip>("Assets/Bug3.mp3");
            var BugFly = ModBase.Instance.assetBundle.LoadAsset<AudioClip>("Assets/BugFly.mp3");
            return new AudioAssets(Jackbox, Bug1, Bug2, Bug3, BugFly);
        }
    }
}