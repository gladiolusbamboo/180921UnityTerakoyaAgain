using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orb
{
    public class OrbsManager : MonoBehaviour
    {
        public const int MAX_ORB = 10;

        private int currentOrb;

        // Use this for initialization
        void Start()
        {
            currentOrb = MAX_ORB;
        }

        internal int GetMaxOrb()
        {
            return MAX_ORB;
        }

        internal int GetCurrentOrbMaxOrbDifference()
        {
            return MAX_ORB - currentOrb;
        }

        internal void DeleteOrb()
        {
            currentOrb--;
        }

        internal void GenerateOrb()
        {
            currentOrb++;
        }
    }
}