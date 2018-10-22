using Player;
using UnityEngine;

namespace UI
{
    public class RightButtonHandlerCaller : MonoBehaviour, IUIButtonHandlerCaller
    {
        public IUIButtonHandler playerRightMover;

        void Start()
        {
            playerRightMover = GameObject.Find("Player").GetComponent<PlayerRightMover>();
        }


        public void CallTapHandler()
        {
            playerRightMover.TapAction();// SetMoveDirection(GameEnum.MOVE_DIR.RIGHT);
        }

        public void CallReleaseHandler()
        {
            playerRightMover.ReleaseAction();
        }
    }
}