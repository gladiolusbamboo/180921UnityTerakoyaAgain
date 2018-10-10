using UnityEngine;
using Player;
using UI;

namespace KeyboardInput
{
    public class KeyboardHandler : MonoBehaviour
    {
        public PlayerMover playerMover;
        public PlayerJumper playerJumper;
        public ButtonUsingManager leftButtonUsingManager;
        public ButtonUsingManager rightButtonUsingManager;
        public ButtonUsingManager jumpButtonUsingManager;

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");

            if (x == 0)
            {
                if(!leftButtonUsingManager.GetIsUsing() && !rightButtonUsingManager.GetIsUsing())
                    playerMover.Stop();
            }
            else
            {
                if (x < 0)
                {
                    if (!leftButtonUsingManager.GetIsUsing() && !rightButtonUsingManager.GetIsUsing())
                        playerMover.SetMoveDirection(GameEnum.MOVE_DIR.LEFT);
                }
                else
                {
                    if (!leftButtonUsingManager.GetIsUsing() && !rightButtonUsingManager.GetIsUsing())
                        playerMover.SetMoveDirection(GameEnum.MOVE_DIR.RIGHT);
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(!jumpButtonUsingManager.GetIsUsing())
                    playerJumper.Jump();
            }
        }
    }
}