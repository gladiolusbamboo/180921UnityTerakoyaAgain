using Effect;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Temple;

namespace Score
{
    public class LevelUpChecker : MonoBehaviour
    {
        public ScoreManager scoreManager;
        public EffectGenerator effectGenerator;
        public TempleSpriteChanger templeSpriteChanger;

        internal void Check()
        {
            if(scoreManager.GetScore() >= scoreManager.GetNextScore())
            {
                if (scoreManager.NextLevel())
                {
                    effectGenerator.GenerateEffect();
                    if(!scoreManager.IsClear())
                        templeSpriteChanger.ChangeTempleSprite(scoreManager.GetLevel());
                }
            }
        }
    }
}