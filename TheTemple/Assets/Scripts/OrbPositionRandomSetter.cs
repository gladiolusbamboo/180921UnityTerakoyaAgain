using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orb
{
    public class OrbPositionRandomSetter : MonoBehaviour
    {
        public GameObject canvasGame;

        private Vector3 minViewPosition = new Vector3(-300.0f, -500.0f);
        private Vector3 maxViewPosition = new Vector3(300.0f, -140.0f);

        internal void SetRandomPosition(GameObject orb)
        {
            orb.transform.SetParent(canvasGame.transform, false);
            orb.transform.localPosition = new Vector3(
                UnityEngine.Random.Range(minViewPosition.x, maxViewPosition.x),
                UnityEngine.Random.Range(minViewPosition.y, maxViewPosition.y),
                0f);
        }
    }
}