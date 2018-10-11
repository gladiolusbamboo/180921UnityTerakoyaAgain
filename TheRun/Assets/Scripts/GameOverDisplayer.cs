using UnityEngine;

namespace GameLabel
{
    public class GameOverDisplayer : MonoBehaviour
    {
        public GameObject gameOver;

        internal void Show()
        {
            gameOver.SetActive(true);
        }
    }
}