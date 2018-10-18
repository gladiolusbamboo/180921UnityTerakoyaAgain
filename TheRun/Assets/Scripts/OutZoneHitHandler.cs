using Player;
using UnityEngine;

namespace OutZone
{
    public class OutZoneHitHandler : MonoBehaviour, IHitEventHandler
    {
        internal ILabelDisplayer gameOverDisplayer;
        public PlayerDestroyer playerDestroyer;

        void Start()
        {
            gameOverDisplayer = GameObject.Find("GameOverDisplayer").GetComponent<ILabelDisplayer>();
        }

        public void DoEvent()
        {
            gameOverDisplayer.Show();
            playerDestroyer.Destroy();
        }
    }
}