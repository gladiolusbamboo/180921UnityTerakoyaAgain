using Player;
using UnityEngine;

namespace UI
{
    public class RightButtonHandler : MonoBehaviour, IButtonHandler
    {
        public IPlayerButtonAction playerRightMover;

        void Start()
        {
            playerRightMover = GameObject.Find("Player").GetComponent<PlayerRightMover>();
        }


        public void Tap()
        {
            playerRightMover.TapAction();// SetMoveDirection(GameEnum.MOVE_DIR.RIGHT);
        }

        public void Release()
        {
            playerRightMover.ReleaseAction();
        }
    }
}