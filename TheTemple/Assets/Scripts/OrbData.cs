using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Score;

namespace Orb
{
    public class OrbData : MonoBehaviour
    {
        private GameEnum.ORB_KIND orbKind;
        public ScoreManager scoreManager;

        internal int GetScore()
        {
            switch (orbKind)
            {
                case GameEnum.ORB_KIND.BLUE: return 1;
                case GameEnum.ORB_KIND.GREEN: return 5;
                case GameEnum.ORB_KIND.PURPLE: return 10;
                default: throw new Exception("不正なorbKindです");
            }
        }

        internal void SetOrbKind()
        {
            int kind = UnityEngine.Random.Range(0, scoreManager.GetLevel() + 1);
            switch (kind)
            {
                case 0: orbKind = GameEnum.ORB_KIND.BLUE; break;
                case 1: orbKind = GameEnum.ORB_KIND.GREEN; break;
                case 2: orbKind = GameEnum.ORB_KIND.PURPLE; break;
            }
        }

        internal GameEnum.ORB_KIND GetOrbKind()
        {
            return orbKind;
        }
    }
}