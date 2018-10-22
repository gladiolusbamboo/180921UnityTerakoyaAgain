using UI;
using UnityEngine;

namespace Player
{
    public class PlayerLeftMover : MonoBehaviour, IUIButtonHandler
    {
        public PlayerMover playerMover;
        public ButtonUsingManager leftButtonUsingManager;
        public PlayerMoveAnimator playerMoveAnimator;

        public void TapAction()
        {
            playerMover.SetMoveDirection(GameEnum.MOVE_DIR.LEFT);
            leftButtonUsingManager.SetIsUsing(true);
            playerMoveAnimator.Move();
        }

        public void ReleaseAction()
        {
            playerMover.Stop();
            leftButtonUsingManager.SetIsUsing(false);
            playerMoveAnimator.Stop();
        }
    }
}