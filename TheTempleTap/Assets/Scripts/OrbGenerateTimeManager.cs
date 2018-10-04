using Mokugyo;
using SaveData;
using Score;
using SE;
using System;
using UnityEngine;

namespace Orb {
    public class OrbGenerateTimeManager : MonoBehaviour {
        public OrbsManager orbsManager;
        public OrbGenerator orbGenerator;
        public SaveDataManager saveDataManager;
        public ScoreManager scoreManager;
        public ScoreDisplayer scoreDisplayer;
        public SEPlayer sePlayer;
        public MokugyoAnimator mokugyoAnimator;
        public LevelUpChecker levelUpChecker;

        private DateTime lastOrbGenerateTime;
        private int numOfOrb;

        public int GENERATE_SPAN_SEC;

        void Start() {
            lastOrbGenerateTime = DateTime.UtcNow;
        }

        /*        void Update() {
                    var currentOrbMaxOrbDifference = orbsManager.GetCurrentOrbMaxOrbDifference();
                    if (currentOrbMaxOrbDifference == 0)
                    {
                        lastOrbGenerateTime = DateTime.UtcNow;
                        return;
                    }

                    for (int i = 0; i < currentOrbMaxOrbDifference; i++)
                    {
                        if (DateTime.UtcNow >= lastOrbGenerateTime + TimeSpan.FromSeconds(GENERATE_SPAN_SEC))
                        {
                            orbGenerator.GenerateOrb();
                            orbsManager.GenerateOrb();
                            lastOrbGenerateTime += TimeSpan.FromSeconds(GENERATE_SPAN_SEC);
                            saveDataManager.Save();
                        }
                    }
                }*/

        private void Update()
        {
            while (numOfOrb > 0)
            {
                Invoke("CreateNewOrb", 0.1f * numOfOrb);
                numOfOrb--;
            }
        }

        internal void OnApplicationPause(bool pause)
        {
            saveDataManager.Load();
            if (!pause)
            {
                var now = DateTime.UtcNow;
                if (lastOrbGenerateTime == DateTime.MinValue)
                {
                    lastOrbGenerateTime = now;
                }
                //                Debug.Log("TIMESPAN : " + (now - lastOrbGenerateTime));

                numOfOrb = 0;

                var timeSpan = now - lastOrbGenerateTime;
                numOfOrb = (int)timeSpan.TotalSeconds / GENERATE_SPAN_SEC;
                if (numOfOrb > orbsManager.GetMaxOrb())
                    numOfOrb = orbsManager.GetMaxOrb();
            }
        }

        private void CreateNewOrb()
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
            SetLastOrbGenerateTime(DateTime.UtcNow);
            saveDataManager.Save();
        }

        internal DateTime GetLastOrbGenerateTime()
        {
            return lastOrbGenerateTime;
        }

        internal void SetLastOrbGenerateTime(DateTime savedTime)
        {
            lastOrbGenerateTime = savedTime;
        }
    }
}