using UnityEngine;

namespace Mokugyo
{
    public class MokugyoAnimator : MonoBehaviour
    {
        public Animator animator;

        internal void AnimateMokugyo()
        {
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
            if(stateInfo.fullPathHash == Animator.StringToHash("Base Layer.get@ImageMokugyo"))
            {
                animator.Play(stateInfo.fullPathHash, 0, 0.0f);
            }
            else
            {
                animator.SetTrigger("isGetScore");
            }
        }
    }
}