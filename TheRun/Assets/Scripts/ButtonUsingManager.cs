using UnityEngine;

namespace UI
{
    public class ButtonUsingManager : MonoBehaviour
    {
        private bool isUsing;

        private void Start()
        {
            isUsing = false;
        }

        internal void SetIsUsing(bool isUsing)
        {
            this.isUsing = isUsing;
        }

        internal bool GetIsUsing()
        {
            return isUsing;
        }
    }
}