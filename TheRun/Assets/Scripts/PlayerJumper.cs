using UI;
using UnityEngine;

namespace Player
{
    public class PlayerJumper : MonoBehaviour, IPlayerButtonAction
    {
        public Rigidbody2D rbody;
        public float jumpPower;
        private bool goJump;
        public LayerMask blockLayer;
        public Animator animator;
        
        private void FixedUpdate()
        {
            animator.SetBool("onGround", CanJump());
            if (goJump)
            {
                rbody.AddForce(Vector2.up * jumpPower);
                goJump = false;
            }
        }

        internal void ButtonJump()
        {
            if (CanJump())
                Jump();
        }

        internal void Jump()
        {
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
            ButtonJump();
        }

        public void ReleaseAction()
        {
            // 何もしない
        }
    }
}