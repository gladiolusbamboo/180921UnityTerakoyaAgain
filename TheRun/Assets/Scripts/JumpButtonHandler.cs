using UnityEngine;
using Player;

namespace UI
{
    public class JumpButtonHandler : MonoBehaviour, IButtonHandler
    {
        public IPlayerButtonAction playerJumper;

        void Start()
        {
            playerJumper = GameObject.Find("Player").GetComponent<PlayerJumper>();
        }

        public void Tap()
        {
            playerJumper.TapAction();
        }

        public void Release()
        {
            playerJumper.ReleaseAction();
        }
    }
}