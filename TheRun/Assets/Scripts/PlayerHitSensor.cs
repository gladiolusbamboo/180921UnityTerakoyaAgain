using UnityEngine;
using GameLabel;
using UI;
using GameManager;

namespace Player
{
    public class PlayerHitSensor : MonoBehaviour
    {
        public GameOverDisplayer gameOverDisplayer;
        public GameClearDisplayer gameClearDisplayer;
        public GameModeManager gameModeManager;
        public ButtonsActivator buttonsActivator;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (gameModeManager.GetGameMode() == GameEnum.GAME_MODE.CLEAR)
                return;
            if (collision.gameObject.tag == "Trap")
            {
                gameOverDisplayer.Show();
                Destroy(this.gameObject);
            }
            if (collision.gameObject.tag == "Goal")
            {
                gameClearDisplayer.Show();
                gameModeManager.SetGameMode(GameEnum.GAME_MODE.CLEAR);
                buttonsActivator.SetActive(false);
            }
        }
    }
}