using UnityEngine;

namespace Player
{
    public class PlayerJumper : MonoBehaviour, IPlayerButtonAction
    {
        public Rigidbody2D rbody;
        public float jumpPower;
        private bool goJump;
        public LayerMask blockLayer;

        private void FixedUpdate()
        {
            if (goJump)
            {
                rbody.AddForce(Vector2.up * jumpPower);
                goJump = false;
            }
        }

        internal void Jump()
        {
            if (CanJump())
                goJump = true;
        }

        private bool CanJump()
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

        public void TapAction()
        {
            Jump();
        }

        public void ReleaseAction()
        {
            // 何もしない
        }
    }
}