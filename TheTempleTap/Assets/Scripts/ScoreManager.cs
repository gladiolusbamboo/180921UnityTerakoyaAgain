using UnityEngine;

namespace Score
{
    public class ScoreManager : MonoBehaviour
    {
        private int score = 0;
        private int level = 0;
        private int nextScore = 10;
        private int[] nextScores = new int[3] { 10, 20, 30 };

        internal int GetMaxLevel()
        {
            return nextScores.Length;
        }

        internal void AddScore(int addScore)
        {
            if (!IsClear())
            {
                score += addScore;
            }
            if (score > nextScore)
                score = nextScore;
        }

        internal int GetScore()
        {
            return score;
        }

        internal int GetLevel()
        {
            return level;
        }

        internal int GetNextScore()
        {
            return nextScore;
        }

        internal void SetScore(int val)
        {
            score = val;
        }

        internal void SetLevel(int val)
        {
            level = val;
        }

        internal void SetNextScore()
        {
            if (!IsClear())
                nextScore = nextScores[level];
            else
                nextScore = nextScores[nextScores.Length - 1];
        }

        internal bool IsClear()
        {
            return level >= nextScores.Length;        
        }

        internal bool NextLevel()
        {
            if (level == nextScores.Length)
                return false;
            if (level < nextScores.Length)
            {
                level++;
                if (!IsClear())
                {
                    score = 0;
                    SetNextScore();
                }
            }
            return true;
        }
    }
}