using System;
using UnityEngine;

namespace Player
{
    public class PlayerJumpSEPlayer : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip se;
        public PlayerJumpableJudger playerJumpableJudger;


        internal void Play()
        {
            if (playerJumpableJudger.CanJump())
            {
                audioSource.PlayOneShot(se);
            }
        }
    }
}