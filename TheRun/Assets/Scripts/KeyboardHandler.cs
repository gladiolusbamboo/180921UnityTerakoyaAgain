using UnityEngine;
using Player;

namespace KeyboardInput
{
    public class KeyboardHandler : MonoBehaviour
    {
        public PlayerMover playerMover;
        public PlayerJumper playerJumper;

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");

            if (x == 0)
            {
                playerMover.Stop(false);
            }
            else
            {
                if (x < 0)
                    playerMover.Move(GameEnum.MOVE_DIR.LEFT, false);
                else
                    playerMover.Move(GameEnum.MOVE_DIR.RIGHT, false);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerJumper.Jump(false);
            }
            else
            {
                playerJumper.Stop(false);
            }
        }
    }
}