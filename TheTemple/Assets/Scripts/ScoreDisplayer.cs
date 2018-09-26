using UnityEngine;
using UnityEngine.UI;

namespace Score
{
    public class ScoreDisplayer : MonoBehaviour
    {
        public GameObject scoreManager;

        // Use this for initialization
        void Start()
        {
            RefreshScoreText();
        }

        internal void RefreshScoreText()
        {
            var score = scoreManager.GetComponent<ScoreManager>().GetScore();
            var nextScore = scoreManager.GetComponent<ScoreManager>().GetNextScore();
            GetComponent<Text>().text = "徳 : " + score + " / " + nextScore;
        }
    }
}