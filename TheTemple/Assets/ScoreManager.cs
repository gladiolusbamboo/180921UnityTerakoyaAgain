using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Score
{
    public class ScoreManager : MonoBehaviour
    {
        private readonly int score = 0;
        private readonly int nextScore = 100;

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