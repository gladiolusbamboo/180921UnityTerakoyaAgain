using UI;
using UnityEngine;

namespace Player
{
    public class PlayerJumper : MonoBehaviour, IUIButtonHandler
    {
        public Rigidbody2D rbody;
        public float jumpPower;
        private bool goJump;
        public PlayerMoveAnimator playerMoveAnimator;
        public PlayerJumpSEPlayer playerJumpSEPlayer;
        public PlayerJumpableJudger playerJumpableJudger;

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
            if (playerJumpableJudger.CanJump())
                Jump();
        }

        internal void Jump()
        {
            goJump = true;
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