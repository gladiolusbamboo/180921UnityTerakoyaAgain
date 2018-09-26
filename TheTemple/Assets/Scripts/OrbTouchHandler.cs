using Score;
using UnityEngine;

namespace Orb
{
    public class OrbTouchHandler : MonoBehaviour
    {
        public ScoreManager scoreManager;
        public ScoreDisplayer scoreDisplayer;
        public OrbDeleter orbDeleter;
        public OrbsManager orbsManager;

        public void Touch()
        {
            scoreManager.AddScore(1);
            scoreDisplayer.RefreshScoreText();
            orbDeleter.Delete();
            orbsManager.DeleteOrb();
        }

    }
}