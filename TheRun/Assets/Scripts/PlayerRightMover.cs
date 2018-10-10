using UI;
using UnityEngine;

namespace Player
{
    public class PlayerRightMover : MonoBehaviour, IPlayerButtonAction
    {
        public ButtonUsingManager rightButtonUsingManager;
        public PlayerMover playerMover;

        public void TapAction()
        {
            playerMover.SetMoveDirection(GameEnum.MOVE_DIR.RIGHT);
            rightButtonUsingManager.SetIsUsing(true);
        }

        public void ReleaseAction()
        {
            playerMover.Stop();
            rightButtonUsingManager.SetIsUsing(false);
        }
    }
}