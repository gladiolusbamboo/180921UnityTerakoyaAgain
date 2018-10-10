using Player;
using UnityEngine;

namespace UI
{
    public class LeftButtonHandler : MonoBehaviour, IButtonHandler
    {
        public IPlayerButtonAction playerLeftMover;

        void Start()
        {
            playerLeftMover = GameObject.Find("Player").GetComponent<PlayerLeftMover>();
        }

        public void Tap()
        {
            playerLeftMover.TapAction();
        }

        public void Release()
        {
            playerLeftMover.ReleaseAction();
        }
    }
}