using UnityEngine;
using Player;

namespace Enemy {
    public class EnemyHitHandler : MonoBehaviour, IHitEventHandler{
        public Transform player;
        public PlayerJumper playerJumper;
        public PlayerDestroyer playerDestroyer;
        public EnemyDestroyer enemyDestroyer;
        internal ILabelDisplayer gameOverDisplayer;

        private void Start()
        {
            gameOverDisplayer = GameObject.Find("GameOverDisplayer").GetComponent<ILabelDisplayer>();
        }

        public void DoEvent()
        {
            if (player.position.y > transform.position.y + 0.4f)
            {
                playerJumper.Jump();
                enemyDestroyer.Destroy();
            }
            else
            {
                gameOverDisplayer.Show();
                playerDestroyer.Destroy();
            }
        }
    }
}