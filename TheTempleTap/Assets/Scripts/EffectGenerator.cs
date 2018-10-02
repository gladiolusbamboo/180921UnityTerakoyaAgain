using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Score;

namespace Effect
{
    public class EffectGenerator : MonoBehaviour
    {
        public ScoreManager scoreManager;
        public GameObject smokePrefab;
        public GameObject kusudamaPrefab;
        public GameObject canvasGame;

        internal void GenerateEffect()
        {
            if (scoreManager.GetLevel() < scoreManager.GetMaxLevel())
            {
                GameObject smoke = Instantiate(smokePrefab);
                smoke.transform.SetParent(canvasGame.transform, false);
                smoke.transform.SetSiblingIndex(2);
                Destroy(smoke, 0.5f);
            }
            else
            {
                GameObject kusudama = Instantiate(kusudamaPrefab);
                kusudama.transform.SetParent(canvasGame.transform, false);
            }
        }
    }
}