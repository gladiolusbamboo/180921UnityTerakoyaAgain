using UnityEngine;
using HitEventHandler;
using Player;
using GameLabel;

namespace Enemy {
    public class EnemyHitHandler : MonoBehaviour, IHitEventHandler{
        public Transform player;
        public PlayerJumper playerJumper;
        public PlayerDestroyer playerDestroyer;
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
                Destroy(this.gameObject);
            }
            else
            {
                gameOverDisplayer.Show();
                playerDestroyer.Destroy();
            }
        }
    }
}