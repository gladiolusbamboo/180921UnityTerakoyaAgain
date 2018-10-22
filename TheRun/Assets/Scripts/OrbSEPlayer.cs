using System;
using UnityEngine;

namespace Orb
{
    public class OrbSEPlayer : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip se;

        internal void Play()
        {
            audioSource.PlayOneShot(se);
        }
    }
}