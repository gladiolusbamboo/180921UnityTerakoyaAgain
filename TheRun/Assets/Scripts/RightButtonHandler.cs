using Player;
using UnityEngine;

namespace UI
{
    public class RightButtonHandler : MonoBehaviour, IButtonHandler
    {
        public PlayerMover playerMover;

        public void Tap()
        {
            playerMover.Move(GameEnum.MOVE_DIR.RIGHT, true);
        }

        public void Release()
        {
            playerMover.Stop(true);
        }
    }
}