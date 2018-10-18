using Player;
using Score;
using UnityEngine;

namespace Orb
{
    public class OrbHitHandler : MonoBehaviour, IHitEventHandler
    {
        public OrbDestroyer orbDestroyer;
        public OrbManager orbManager;
        public ScoreManager scoreManager;
        public void DoEvent()
        {
            var point = orbManager.GetOrbPoint();
            scoreManager.AddScore(point);
            orbDestroyer.Destroy();
        }
    }
}