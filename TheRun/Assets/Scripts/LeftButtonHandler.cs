using Player;
using UnityEngine;

namespace UI
{
    public class LeftButtonHandler : MonoBehaviour, IButtonHandler
    {
        public PlayerMover playerMover;

        public void Tap()
        {
            playerMover.SetMoveDirection(GameEnum.MOVE_DIR.LEFT);
        }

        public void Release()
        {
            playerMover.SetMoveDirection(GameEnum.MOVE_DIR.STOP);
        }
    }
}