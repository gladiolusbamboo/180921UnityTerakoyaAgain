using System;
using UnityEngine;

namespace Player
{
    public class PlayerJumpSEPlayer : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip se;

        // ジャンプできる状態かどうか判定のために使う
        public PlayerJumper playerJumper;

        internal void Play()
        {
            if (playerJumper.CanJump())
            {
                audioSource.PlayOneShot(se);
            }
        }
    }
}