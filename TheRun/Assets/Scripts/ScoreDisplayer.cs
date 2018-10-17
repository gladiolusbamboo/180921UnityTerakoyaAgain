using UnityEngine;
using UnityEngine.UI;

namespace Score {
    public class ScoreDisplayer : MonoBehaviour {
        public ScoreManager scoreManager;
        private int displayScore = 0;
        public Text textComponent;

        // Update is called once per frame
        void Update() {
            var score = scoreManager.GetScore();
            if (score > displayScore)
            {
                displayScore += 10;
                if (displayScore > score)
                    displayScore = score;
            }
            RefreshScore();
        }

        private void RefreshScore()
        {
            textComponent.text = displayScore.ToString();
        }
    }
}