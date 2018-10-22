using Player;
using Score;
using UnityEngine;

namespace Orb
{
    public class OrbHitHandlerCaller : MonoBehaviour, IPlayerHitHandlerCaller
    {
        public OrbDestroyAnimator orbDestroyAnimator;
        public OrbManager orbManager;
        public ScoreManager scoreManager;
        public OrbSEPlayer orbSEPlayer;
        private bool gotFlag = false;

        public void CallHandler()
        {
            // ２回衝突することがあるので回避する
            if (gotFlag)
                return;
            gotFlag = true;
            orbDestroyAnimator.Animate();
            var point = orbManager.GetOrbPoint();
            scoreManager.AddScore(point);
            orbSEPlayer.Play();
        }
    }
}