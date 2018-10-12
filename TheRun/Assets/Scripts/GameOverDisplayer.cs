using UnityEngine;

namespace GameLabel
{
    public class GameOverDisplayer : MonoBehaviour, ILabelDisplayer
    {
        public GameObject gameOver;

        public void Show()
        {
            gameOver.SetActive(true);
        }
    }
}