using UI;
using UnityEngine;

namespace Player
{
    public class PlayerJumper : MonoBehaviour, IUIButtonHandler
    {
        public Rigidbody2D rbody;
        public float jumpPower;
        private bool goJump;
        public LayerMask blockLayer;
        public PlayerMoveAnimator playerMoveAnimator;
        public PlayerJumpSEPlayer playerJumpSEPlayer;

        private void FixedUpdate()
        {
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

        public void TapAction()
        {
            ButtonJump();
            playerMoveAnimator.Jump();
            playerJumpSEPlayer.Play();
        }

        public void ReleaseAction()
        {
            // 何もしない
        }
    }
}