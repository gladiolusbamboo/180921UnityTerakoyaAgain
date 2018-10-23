using UnityEngine;

namespace Player
{
    public class PlayerMoveAnimator : MonoBehaviour
    {
        public Animator animator;
        // ジャンプできる状態かどうか判定のために使う
        public PlayerJumpableJudger playerJumpableJudger;

        internal void Jump()
        {
            if (playerJumpableJudger.CanJump())
                animator.SetTrigger("Jump");
        }

        internal void Stop()
        {
            animator.SetBool("isWalking", false);
        }

        internal void Move()
        {
            animator.SetBool("isWalking", true);
        }
    }
}