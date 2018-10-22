using UnityEngine;

namespace Player
{
    public class PlayerOutZoneAnimator : MonoBehaviour, IPlayerMissAnimator
    {
        public CircleCollider2D circleCollider2D;
        public BoxCollider2D boxCollider2D;
        public PlayerDestroyer playerDestroyer;

        public void Animate()
        {
            Destroy(circleCollider2D);
            Destroy(boxCollider2D);
            playerDestroyer.Destroy();
        }
    }
}