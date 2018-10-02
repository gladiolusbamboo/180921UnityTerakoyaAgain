using UnityEngine;
using Orb;
using Score;
using SE;
using SaveData;

namespace Mokugyo {
    public class MokugyoTapHandler : MonoBehaviour {
        public OrbGenerator orbGenerator;
        public ScoreManager scoreManager;
        public OrbsManager orbsManager;
        public ScoreDisplayer scoreDisplayer;
        public SEPlayer sePlayer;
        public MokugyoAnimator mokugyoAnimator;
        public SaveDataManager saveDataManager;

        public void Tap()
        {
            var generatedOrb = orbGenerator.GenerateOrb();
            var generatedOrbData = generatedOrb.GetComponent<OrbData>();
            var orbFlyer = generatedOrb.GetComponent<OrbFlyer>();
            scoreManager.AddScore(generatedOrbData.GetScore());
            orbsManager.DeleteOrb();
            orbFlyer.Fly();
            scoreDisplayer.RefreshScoreText();
            sePlayer.SoundGetScoreSE();
            mokugyoAnimator.AnimateMokugyo();
            saveDataManager.Save();
        }
    }
}