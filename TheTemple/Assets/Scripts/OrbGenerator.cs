using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orb
{
    public class OrbGenerator : MonoBehaviour
    {
        private const int MAX_ORB = 10;

        public GameObject orbPrefab;
        public GameObject canvasGame;

        private Vector3 minViewPosition = new Vector3(-300.0f, -500.0f);
        private Vector3 maxViewPosition = new Vector3(300.0f, -140.0f);

        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < MAX_ORB; i++)
            {
                GenerateOrb();
            }
        }

        private void GenerateOrb()
        {
            GameObject orb = Instantiate(orbPrefab);
            orb.transform.SetParent(canvasGame.transform, false);
            orb.transform.localPosition = new Vector3(
                UnityEngine.Random.Range(minViewPosition.x, maxViewPosition.x),
                UnityEngine.Random.Range(minViewPosition.y, maxViewPosition.y),
                0f);
        }
    }
}