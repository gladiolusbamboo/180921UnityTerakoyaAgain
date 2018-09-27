using Score;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Temple
{
    public class TempleScaler : MonoBehaviour
    {
        public ScoreManager scoreManager;

        internal void Scale()
        {
            float scale = 0.5f + (((float)scoreManager.GetScore() / (float)scoreManager.GetNextScore()) / 2.0f);
            this.transform.localScale = new Vector3(scale, scale, 1.0f);
        }
    }
}