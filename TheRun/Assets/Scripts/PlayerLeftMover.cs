using UI;
using UnityEngine;

namespace Player
{
    public class PlayerLeftMover : MonoBehaviour, IPlayerButtonAction
    {
        public ButtonUsingManager leftButtonUsingManager;
        public PlayerMover playerMover;

        public void TapAction()
        {
            playerMover.SetMoveDirection(GameEnum.MOVE_DIR.LEFT);
            leftButtonUsingManager.SetIsUsing(true);
        }

        public void ReleaseAction()
        {
            playerMover.Stop();
            leftButtonUsingManager.SetIsUsing(false);
        }
    }
}