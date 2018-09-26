using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orb
{
    public class OrbGenerator : MonoBehaviour
    {
        public OrbsManager orbsManager;
        public GameObject orbPrefab;
        public OrbPositionRandomSetter orbPositionRandomSetter;

        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < orbsManager.GetMaxOrb(); i++)
            {
                GenerateOrb();
            }
        }

        internal void GenerateOrb()
        {
            GameObject orb = Instantiate(orbPrefab);
            orbPositionRandomSetter.SetRandomPosition(orb);
        }
    }
}