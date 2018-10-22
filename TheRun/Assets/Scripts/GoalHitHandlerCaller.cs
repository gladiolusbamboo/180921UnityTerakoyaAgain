using GameManager;
using Player;
using UI;
using UnityEngine;

namespace Goal
{
    public class GoalHitHandlerCaller : MonoBehaviour, IPlayerHitHandlerCaller
    {
        internal ILabelDisplayer gameClearDisplayer;
        public ButtonsActivator buttonsActivator;
        public GameModeManager gameModeManager;
        public GoalSEPlayer goalSEPlayer;

        void Start()
        {
            gameClearDisplayer = GameObject.Find("GameClearDisplayer").GetComponent<ILabelDisplayer>();
        }

        public void CallHandler()
        {
            gameClearDisplayer.Show();
            gameModeManager.SetGameMode(GameEnum.GAME_MODE.CLEAR);
            buttonsActivator.SetActive(false);
            goalSEPlayer.Play();
        }
    }
}
