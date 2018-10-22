using UnityEngine;
using GameManager;

namespace Player
{
    public class PlayerHitSensor : MonoBehaviour
    {
        public GameModeManager gameModeManager;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (gameModeManager.GetGameMode() == GameEnum.GAME_MODE.CLEAR)
                return;
            var hitObject = collision.gameObject;
            var handlercaller = hitObject.GetComponent<IPlayerHitHandlerCaller>();
            if (handlercaller != null)
                handlercaller.CallHandler();
        }
    }
}