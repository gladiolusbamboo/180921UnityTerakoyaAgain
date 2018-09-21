using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bonz
{
    public class BonzMover : MonoBehaviour
    {
        private Vector3 startPosition;
        private readonly float moveRange = 2.0f;

        // Use this for initialization
        void Start()
        {
            Transform transform = GetComponent<Transform>();

            startPosition = this.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 position = new Vector3(
                    Random.Range(-moveRange, moveRange),
                    Random.Range(-moveRange, moveRange)
                );
            transform.position = startPosition + position;
        }
    }
}
