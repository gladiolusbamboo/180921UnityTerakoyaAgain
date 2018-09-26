using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Score
{
    public class ScoreManager : MonoBehaviour
    {
        private int score = 0;
        private readonly int nextScore = 100;

        internal void AddScore(int addScore)
        {
            score += addScore;
        }

        internal int GetScore()
        {
            return score;
        }

        internal int GetNextScore()
        {
            return nextScore;
        }
    }
}