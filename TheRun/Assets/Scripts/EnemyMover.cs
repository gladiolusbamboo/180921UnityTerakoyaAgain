using UnityEngine;

namespace Enemy
{
    public class EnemyMover : MonoBehaviour
    {
        private GameEnum.MOVE_DIR moveDirection;
        public Rigidbody2D rbody;
        public float moveSpeed;
        public LayerMask blockLayer;

        // Use this for initialization
        void Start()
        {
            moveDirection = GameEnum.MOVE_DIR.LEFT;
        }

        private void FixedUpdate()
        {
            bool isBlock;
            int dirNum = 1;
            if (moveDirection == GameEnum.MOVE_DIR.RIGHT)
                dirNum = -1;
            rbody.velocity = new Vector2(-moveSpeed * dirNum, rbody.velocity.y);
            transform.localScale = new Vector2(dirNum, 1);
            isBlock = Physics2D.Linecast(
                new Vector2(transform.position.x, transform.position.y + 0.5f),
                new Vector2(transform.position.x - 0.3f * dirNum, transform.position.y + 0.5f),
                blockLayer);
            if (isBlock)
            {
                if (moveDirection == GameEnum.MOVE_DIR.LEFT) moveDirection = GameEnum.MOVE_DIR.RIGHT;
                else if (moveDirection == GameEnum.MOVE_DIR.RIGHT) moveDirection = GameEnum.MOVE_DIR.LEFT;
            }
        }
    }
}
