using Score;
using UnityEngine;
using Orb;
using Temple;
using System;

namespace SaveData
{
    public class SaveDataManager : MonoBehaviour
    {
        private const string KEY_SCORE = "SCORE";
        private const string KEY_LEVEL = "LEVEL";
        private const string KEY_ORB = "ORB";
        private const string KEY_TIME = "TIME";

        public ScoreManager scoreManager;
        public OrbsManager orbsManager;
        public OrbGenerateTimeManager orbGenerateTimeManager;
        public TempleScaler templeScaler;
        public TempleSpriteChanger templeSpriteChanger;

        internal void Load()
        {
//            PlayerPrefs.DeleteAll();
//            Debug.Log("LOAD");
            scoreManager.SetScore(PlayerPrefs.GetInt(KEY_SCORE, 0));
            scoreManager.SetLevel(PlayerPrefs.GetInt(KEY_LEVEL, 0));
            scoreManager.SetNextScore();
            orbsManager.SetCurrentOrb(PlayerPrefs.GetInt(KEY_ORB, 10));
            string savedTime = PlayerPrefs.GetString(KEY_TIME, "");
            if (savedTime == "")
            {
                orbGenerateTimeManager.SetLastOrbGenerateTime(DateTime.UtcNow);
            }
            else
            {
                long temp = Convert.ToInt64(savedTime);
                orbGenerateTimeManager.SetLastOrbGenerateTime(DateTime.FromBinary(temp));
            }
            templeSpriteChanger.ChangeTempleSprite(scoreManager.GetLevel());
            templeScaler.Scale();
        }

        internal void Save()
        {
            PlayerPrefs.SetInt(KEY_SCORE, scoreManager.GetScore());
            PlayerPrefs.SetInt(KEY_LEVEL, scoreManager.GetLevel());
            PlayerPrefs.SetInt(KEY_ORB, orbsManager.GetCurrentOrb());
            PlayerPrefs.SetString(KEY_TIME, orbGenerateTimeManager.GetLastOrbGenerateTime().ToBinary().ToString());
            PlayerPrefs.Save();
        }
    }
}