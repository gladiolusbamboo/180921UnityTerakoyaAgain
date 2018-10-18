using UnityEngine;

namespace Enemy
{
    public class EnemyDestroyer : MonoBehaviour
    {
        internal void Destroy()
        {
            Destroy(this.gameObject);
        }
    }
}