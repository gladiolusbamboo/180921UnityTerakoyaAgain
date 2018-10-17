using UnityEngine;

namespace Orb
{
    public class OrbDestroyer : MonoBehaviour
    {
        internal void Destroy()
        {
            Destroy(this.gameObject);
        }
    }
}