using GameManager;
using Player;
using UnityEngine;

namespace Needle
{
    public class NeedleHitHandlerCaller : MonoBehaviour, IPlayerHitHandlerCaller
    {
        internal ILabelDisplayer gameOverDisplayer;
        internal IPlayerMissAnimator playerEnemyHitAnimator;
        public GameModeManager gameModeManager;
        public NeedleSEPlayer needleSEPlayer;

        void Start()
        {
            gameOverDisplayer = GameObject.Find("GameOverDisplayer").GetComponent<ILabelDisplayer>();
            playerEnemyHitAnimator = GameObject.Find("Player").GetComponent<PlayerEnemyHitAnimator>();
        }

        public void CallHandler()
        {
            gameOverDisplayer.Show();
            gameModeManager.SetGameMode(GameEnum.GAME_MODE.GAMEOVER);
            playerEnemyHitAnimator.Animate();
            needleSEPlayer.Play();
        }
    }
}