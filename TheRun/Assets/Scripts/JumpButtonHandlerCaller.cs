using UnityEngine;
using Player;

namespace UI
{
    public class JumpButtonHandlerCaller : MonoBehaviour, IUIButtonHandlerCaller
    {
        public IUIButtonHandler playerJumper;

        void Start()
        {
            playerJumper = GameObject.Find("Player").GetComponent<PlayerJumper>();
        }

        public void CallTapHandler()
        {
            playerJumper.TapAction();
        }

        public void CallReleaseHandler()
        {
            playerJumper.ReleaseAction();
        }
    }
}