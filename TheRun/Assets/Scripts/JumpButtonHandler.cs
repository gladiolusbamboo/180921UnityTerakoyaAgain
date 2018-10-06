using UnityEngine;
using Player;

namespace UI
{
    public class JumpButtonHandler : MonoBehaviour, IButtonHandler
    {
        public PlayerJumper playerJumper;

        public void Tap()
        {
            playerJumper.Jump(true);
        }

        public void Release()
        {
            playerJumper.Stop(true);
        }
    }
}