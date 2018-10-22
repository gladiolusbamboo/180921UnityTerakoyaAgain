using System;
using UnityEngine;

public class EnemySEPlayer : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip seDefeat;
    public AudioClip seMiss;

    internal void Play(GameEnum.ENEMY_SE se)
    {
        switch (se)
        {
            case GameEnum.ENEMY_SE.DEFEAT:
                audioSource.PlayOneShot(seDefeat);
                break;
            case GameEnum.ENEMY_SE.MISS:
                audioSource.PlayOneShot(seMiss);
                break;
        }
    }
}
