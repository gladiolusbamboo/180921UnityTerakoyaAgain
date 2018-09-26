using UnityEngine;

namespace Orb
{
    public class OrbDeleter : MonoBehaviour
    {
        internal void Delete()
        {
            Destroy(this.gameObject);
        }
    }
}