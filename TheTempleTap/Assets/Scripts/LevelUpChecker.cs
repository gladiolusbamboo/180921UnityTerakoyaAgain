using Effect;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Temple;
using SE;

namespace Score
{
    public class LevelUpChecker : MonoBehaviour
    {
        public ScoreManager scoreManager;
        public EffectGenerator effectGenerator;
        public TempleSpriteChanger templeSpriteChanger;
        public SEPlayer sePlayer;

        internal void Check()
        {
            if(scoreManager.GetScore() >= scoreManager.GetNextScore())
            {
                if (scoreManager.NextLevel())
                {
                    effectGenerator.GenerateEffect();
                    if (scoreManager.IsClear())
                        sePlayer.SoundClearSE();
                    else
                    {
                        sePlayer.SoundLevelUpSE();
                        templeSpriteChanger.ChangeTempleSprite(scoreManager.GetLevel());
                    }
                }
            }
        }
    }
}