using GameLabel;
using GameManager;
using UI;
using UnityEngine;

namespace GameScene
{
    public class GameClearHandler : MonoBehaviour, IHitEventHandler
    {
        internal ILabelDisplayer gameClearDisplayer;
        public ButtonsActivator buttonsActivator;
        public GameModeManager gameModeManager;

        void Start()
        {
            gameClearDisplayer = GameObject.Find("GameClearDisplayer").GetComponent<ILabelDisplayer>();
        }

        public void DoEvent()
        {
            gameClearDisplayer.Show();
            gameModeManager.SetGameMode(GameEnum.GAME_MODE.CLEAR);
            buttonsActivator.SetActive(false);
        }
    }
}
