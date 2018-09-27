using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Score
{
    public class ScoreManager : MonoBehaviour
    {
        private int score = 0;
        private int level = 0;
        private int nextScore = 10;
        private int[] nextScores = new int[3] { 10, 20, 30 };
        private bool isClearFlag;

        internal int GetMaxLevel()
        {
            return nextScores.Length;
        }

        internal void AddScore(int addScore)
        {
            if (!isClearFlag)
            {
                score += addScore;
            }
            if (score > nextScore)
                score = nextScore;
        }

        internal int GetLevel()
        {
            return level;
        }

        internal bool IsClear()
        {
            return isClearFlag;
        }

        internal int GetScore()
        {
            return score;
        }

        internal bool NextLevel()
        {
            if (level == nextScores.Length)
                return false;
            if (level < nextScores.Length)
            {
                level++;
                if (level == nextScores.Length)
                    isClearFlag = true;
                else
                {
                    score = 0;
                    nextScore = nextScores[level];
                }
            }
            return true;
        }

        internal int GetNextScore()
        {
            return nextScore;
        }
    }
}