using UnityEngine;

namespace Player
{
    public class PlayerDestroyer : MonoBehaviour
    {
        internal void Destroy()
        {
            Destroy(gameObject);
        }
    }
}
