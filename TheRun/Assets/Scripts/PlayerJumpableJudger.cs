using UnityEngine;

namespace Player
{
    public class PlayerJumpableJudger : MonoBehaviour
    {
        public LayerMask blockLayer;

        internal bool CanJump()
        {
            var canJump =
                (Physics2D.Linecast(
                    transform.position - (transform.right * 0.3f),
                    transform.position - (transform.up * 0.1f), blockLayer) ||
                Physics2D.Linecast(
                    transform.position + (transform.right * 0.3f),
                    transform.position - (transform.up * 0.1f), blockLayer));
            return canJump;
        }
    }
}