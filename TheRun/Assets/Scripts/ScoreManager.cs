using System;
using UnityEngine;

namespace Score
{
    public class ScoreManager : MonoBehaviour
    {
        public int MAX_SCORE = 999999;
        private int score = 0;

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