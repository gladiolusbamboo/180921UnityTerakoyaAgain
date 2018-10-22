using UnityEngine;

public class OutZoneSEPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip se;

    public void Play()
    {
        audioSource.PlayOneShot(se);
    }
}
