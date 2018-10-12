using UnityEngine;
using GameManager;
using HitEventHandler;

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
            var eventHandler = hitObject.GetComponent<IHitEventHandler>();
            if (eventHandler != null)
                eventHandler.DoEvent();
        }
    }
}