using SaveData;
using System;
using UnityEngine;

namespace Orb {
    public class OrbGenerateTimeManager : MonoBehaviour {
        public OrbsManager orbsManager;
        public OrbGenerator orbGenerator;
        public SaveDataManager saveDataManager;

        private DateTime lastOrbGenerateTime;

        public int GENERATE_SPAN_SEC;

        void Start() {
            lastOrbGenerateTime = DateTime.UtcNow;
        }

        void Update() {
/*            var currentOrbMaxOrbDifference = orbsManager.GetCurrentOrbMaxOrbDifference();
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
            }/**/
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