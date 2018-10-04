using UnityEngine;
using Orb;
using Score;
using SE;
using SaveData;
using System;

namespace Mokugyo {
    public class MokugyoTapHandler : MonoBehaviour {
        public OrbGenerator orbGenerator;
        public ScoreManager scoreManager;
        public OrbsManager orbsManager;
        public ScoreDisplayer scoreDisplayer;
        public SEPlayer sePlayer;
        public MokugyoAnimator mokugyoAnimator;
        public SaveDataManager saveDataManager;
        public OrbGenerateTimeManager orbGenerateTimeManager;
        public LevelUpChecker levelUpChecker;

        public void Tap()
        {
            var generatedOrb = orbGenerator.GenerateOrb();
            var generatedOrbData = generatedOrb.GetComponent<OrbData>();
            var orbFlyer = generatedOrb.GetComponent<OrbFlyer>();
            scoreManager.AddScore(generatedOrbData.GetScore());
            levelUpChecker.Check();
            orbsManager.DeleteOrb();
            orbFlyer.Fly();
            scoreDisplayer.RefreshScoreText();
            sePlayer.SoundGetScoreSE();
            mokugyoAnimator.AnimateMokugyo();
            orbGenerateTimeManager.SetLastOrbGenerateTime(DateTime.UtcNow);
            saveDataManager.Save();
        }
    }
}