using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SE
{
    public class SEPlayer : MonoBehaviour
    {
        public AudioClip getScoreSE;
        public AudioClip levelUpSE;
        public AudioClip clearSE;

        public AudioSource audioSource;

        internal void SoundGetScoreSE()
        {
            audioSource.PlayOneShot(getScoreSE);
        }

        internal void SoundLevelUpSE()
        {
            audioSource.PlayOneShot(levelUpSE);
        }

        internal void SoundClearSE()
        {
            audioSource.PlayOneShot(clearSE);
        }
    }
}