using UnityEngine;

namespace GameLabel
{
    public class GameClearDisplayer : MonoBehaviour
    {
        public GameObject gameClear;

        internal void Show()
        {
            gameClear.SetActive(true);
        }
    }
}