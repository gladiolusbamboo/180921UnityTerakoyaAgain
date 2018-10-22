using UnityEngine;

public class GoalSEPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip se;

    internal void Play()
    {
        audioSource.PlayOneShot(se);
    }
}
