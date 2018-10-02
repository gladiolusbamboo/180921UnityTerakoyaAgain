/*
using Score;
using Temple;
using UnityEngine;
using SE;
using Mokugyo;
using SaveData;

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
        public SEPlayer sePlayer;
        public MokugyoAnimator mokugyoAnimator;
        public SaveDataManager saveDataManager;

        public void Touch()
        {
            var touchedOrb = GetComponent<OrbData>();
            scoreManager.AddScore(touchedOrb.GetScore());
            orbDeleter.Delete();
            orbsManager.DeleteOrb();
            levelUpChecker.Check();
            templeScaler.Scale();
            scoreDisplayer.RefreshScoreText();
            sePlayer.SoundGetScoreSE();
            mokugyoAnimator.AnimateMokugyo();
            saveDataManager.Save();
        }

    }
}
*/