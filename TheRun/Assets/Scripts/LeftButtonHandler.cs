using Player;
using UnityEngine;

namespace UI
{
    public class LeftButtonHandler : MonoBehaviour, IButtonHandler
    {
        public PlayerMover playerMover;

        public void Tap()
        {
            playerMover.Move(GameEnum.MOVE_DIR.LEFT, true);
        }

        public void Release()
        {
            playerMover.Stop(true);
        }
    }
}