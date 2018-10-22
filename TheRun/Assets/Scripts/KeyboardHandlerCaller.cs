using UnityEngine;
using Player;
using UI;
using GameManager;

namespace KeyboardInput
{
    public class KeyboardHandlerCaller : MonoBehaviour
    {
        public PlayerMover playerMover;
        public PlayerJumper playerJumper;
        public ButtonUsingManager leftButtonUsingManager;
        public ButtonUsingManager rightButtonUsingManager;
        public ButtonUsingManager jumpButtonUsingManager;
        public GameModeManager gameModeManager;
        public PlayerMoveAnimator playerMoveAnimator;
        public PlayerJumpSEPlayer playerJumpSEPlayer;

        void Update()
        {
            if (gameModeManager.GetGameMode() == GameEnum.GAME_MODE.CLEAR ||
                gameModeManager.GetGameMode() == GameEnum.GAME_MODE.GAMEOVER )
                return;
            float x = Input.GetAxisRaw("Horizontal");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!jumpButtonUsingManager.GetIsUsing())
                {
                    playerJumper.ButtonJump();
                    playerMoveAnimator.Jump();
                    playerJumpSEPlayer.Play();
                }
            }
            else
            {
            }

            if (x == 0)
            {
                if (!leftButtonUsingManager.GetIsUsing() && !rightButtonUsingManager.GetIsUsing())
                {
                    playerMoveAnimator.Stop();
                    playerMover.Stop();
                }
            }
            else
            {
                if (x < 0)
                {
                    if (!leftButtonUsingManager.GetIsUsing() && !rightButtonUsingManager.GetIsUsing())
                    {
                        playerMover.SetMoveDirection(GameEnum.MOVE_DIR.LEFT);
                    }
                }
                else
                {
                    if (!leftButtonUsingManager.GetIsUsing() && !rightButtonUsingManager.GetIsUsing())
                    {
                        playerMoveAnimator.Move();
                        playerMover.SetMoveDirection(GameEnum.MOVE_DIR.RIGHT);
                    }
                }
            }
        }
    }
}