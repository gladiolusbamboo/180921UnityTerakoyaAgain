using Player;
using UnityEngine;

namespace UI
{
    public class LeftButtonHandlerCaller : MonoBehaviour, IUIButtonHandlerCaller
    {
        public IUIButtonHandler playerLeftMover;

        void Start()
        {
            playerLeftMover = GameObject.Find("Player").GetComponent<PlayerLeftMover>();
        }

        public void CallTapHandler()
        {
            playerLeftMover.TapAction();
        }

        public void CallReleaseHandler()
        {
            playerLeftMover.ReleaseAction();
        }
    }
}