using UnityEngine;

namespace Needle
{
    public class NeedleSEPlayer : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip se;

        internal void Play()
        {
            audioSource.PlayOneShot(se);
        }
    }
}