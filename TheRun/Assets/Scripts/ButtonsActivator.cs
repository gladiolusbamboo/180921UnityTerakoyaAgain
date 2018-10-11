using UnityEngine;

namespace UI
{
    public class ButtonsActivator : MonoBehaviour
    {
        public GameObject buttons;

        public void SetActive(bool isActive)
        {
            buttons.SetActive(isActive);
        }
    }
}