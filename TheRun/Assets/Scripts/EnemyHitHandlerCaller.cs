using UnityEngine;
using Player;
using GameManager;
using Score;

namespace Enemy {
    public class EnemyHitHandlerCaller : MonoBehaviour, IPlayerHitHandlerCaller
    {
        public Transform player;
        public PlayerJumper playerJumper;
        internal IPlayerMissAnimator playerEnemyHitAnimator;
        public EnemyDestroyAnimator enemyDestroyAnimator;
        public GameModeManager gameModeManager;
        internal ILabelDisplayer gameOverDisplayer;
        public ScoreManager scoreManager;
        public int ENEMY_SCORE;
        public EnemySEPlayer enemySEPlayer;

        private void Start()
        {
            gameOverDisplayer = GameObject.Find("GameOverDisplayer").GetComponent<ILabelDisplayer>();
            playerEnemyHitAnimator = GameObject.Find("Player").GetComponent<PlayerEnemyHitAnimator>();
        }

        public void CallHandler()
        {
            if (player.position.y > transform.position.y + 0.4f)
            {
                playerJumper.Jump();
                enemyDestroyAnimator.Animate();
                scoreManager.AddScore(ENEMY_SCORE);
                enemySEPlayer.Play(GameEnum.ENEMY_SE.DEFEAT);
            }
            else
            {
                gameOverDisplayer.Show();
                gameModeManager.SetGameMode(GameEnum.GAME_MODE.GAMEOVER);
                playerEnemyHitAnimator.Animate();
                enemySEPlayer.Play(GameEnum.ENEMY_SE.MISS);
            }
        }
    }
}