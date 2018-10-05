using UnityEngine;

namespace Player
{
    public class PlayerMover : MonoBehaviour
    {
        public Rigidbody2D rbody;

        private GameEnum.MOVE_DIR moveDirection = GameEnum.MOVE_DIR.STOP;
        private float moveSpeed;
        private const float MOVE_SPEED = 3f;

        internal void SetMoveDirection(GameEnum.MOVE_DIR dir)
        {
            moveDirection = dir;
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            switch (moveDirection)
            {
                case GameEnum.MOVE_DIR.STOP:
                    moveSpeed = 0;
                    break;
                case GameEnum.MOVE_DIR.LEFT:
                    moveSpeed = MOVE_SPEED * -1;
                    transform.localScale = new Vector2(-1, 1);
                    break;
                case GameEnum.MOVE_DIR.RIGHT:
                    moveSpeed = MOVE_SPEED;
                    transform.localScale = new Vector2(1, 1);
                    break;
            }

            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
        }
    }
}