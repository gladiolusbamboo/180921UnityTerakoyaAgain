using Effect;
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