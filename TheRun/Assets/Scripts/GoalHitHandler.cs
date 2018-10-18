using GameManager;
using Player;
using UI;
using UnityEngine;

namespace Goal
{
    public class GoalHitHandler : MonoBehaviour, IHitEventHandler
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
