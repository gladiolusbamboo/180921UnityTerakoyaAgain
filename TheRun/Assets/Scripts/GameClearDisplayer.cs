using UnityEngine;

namespace GameLabel
{
    public class GameClearDisplayer : MonoBehaviour, ILabelDisplayer
    {
        public GameObject gameClear;

        public void Show()
        {
            gameClear.SetActive(true);
        }
    }
}