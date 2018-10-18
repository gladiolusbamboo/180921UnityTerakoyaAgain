using System;
using UnityEngine;

namespace Score
{
    public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
    {
        public int MAX_SCORE = 999999;
        private int score = 0;

        public void Awake()
        {
            if (this != Instance)
            {
                Destroy(this);
                return;
            }
        }

        internal void AddScore(int point)
        {
            score += point;
            score = Mathf.Clamp(score, 0, MAX_SCORE);
        }

        internal int GetScore()
        {
            return score;
        }
    }
}