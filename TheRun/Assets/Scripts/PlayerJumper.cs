using UnityEngine;

namespace Player
{
    public class PlayerJumper : MonoBehaviour
    {
        public Rigidbody2D rbody;
        public float jumpPower;

        private bool goJump;
        public LayerMask blockLayer;
        private bool isUsingButton;

        private void FixedUpdate()
        {
            if (goJump)
            {
                rbody.AddForce(Vector2.up * jumpPower);
                goJump = false;
            }
        }

        internal void Jump(bool isButton)
        {
            if (isButton)
            {
                if (canJump())
                    goJump = true;
                isUsingButton = true;
            }
            else
            {
                if (!isUsingButton && canJump())
                    goJump = true;
            }
        }

        internal void Stop(bool isButton)
        {
            if (isButton)
            {
                isUsingButton = false;
            }
        }

        private bool canJump()
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