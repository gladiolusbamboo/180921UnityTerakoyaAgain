using Score;
using Temple;
using UnityEngine;

namespace Orb
{
    public class OrbTouchHandler : MonoBehaviour
    {
        public ScoreManager scoreManager;
        public ScoreDisplayer scoreDisplayer;
        public OrbDeleter orbDeleter;
        public OrbsManager orbsManager;
        public TempleScaler templeScaler;
        public LevelUpChecker levelUpChecker;

        public void Touch()
        {
            var touchedOrb = GetComponent<OrbData>();
            scoreManager.AddScore(touchedOrb.GetScore());
            orbDeleter.Delete();
            orbsManager.DeleteOrb();
            levelUpChecker.Check();
            templeScaler.Scale();
            scoreDisplayer.RefreshScoreText();
        }

    }
}