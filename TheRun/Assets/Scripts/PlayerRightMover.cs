using UI;
using UnityEngine;

namespace Player
{
    public class PlayerRightMover : MonoBehaviour, IUIButtonHandler
    {
        public PlayerMover playerMover;
        public ButtonUsingManager rightButtonUsingManager;
        public PlayerMoveAnimator playerMoveAnimator;

        public void TapAction()
        {
            playerMover.SetMoveDirection(GameEnum.MOVE_DIR.RIGHT);
            rightButtonUsingManager.SetIsUsing(true);
            playerMoveAnimator.Move();
        }

        public void ReleaseAction()
        {
            playerMover.Stop();
            rightButtonUsingManager.SetIsUsing(false);
            playerMoveAnimator.Stop();
        }
    }
}