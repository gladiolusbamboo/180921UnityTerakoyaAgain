using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Score
{
    public class ScoreDisplayer : MonoBehaviour
    {
        public GameObject textScore;
        public GameObject scoreManager;
        private int score;
        private int nextScore;

        // Use this for initialization
        void Start()
        {
            RefreshScoreText();
            score = scoreManager.GetComponent<ScoreManager>().GetScore();
            nextScore = scoreManager.GetComponent<ScoreManager>().GetNextScore();
        }

        private void RefreshScoreText()
        {
            textScore.GetComponent<Text>().text
                = "徳 : " + score + " / " + nextScore;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}