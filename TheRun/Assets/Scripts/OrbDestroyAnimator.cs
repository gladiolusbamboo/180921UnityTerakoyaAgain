using DG.Tweening;
using UnityEngine;

namespace Orb
{
    public class OrbDestroyAnimator : MonoBehaviour
    {
        public CircleCollider2D circleCollider2D;
        public OrbDestroyer orbDestroyer;
        public SpriteRenderer spriteRenderer;

        internal void Animate()
        {
            Destroy(circleCollider2D);
            Sequence animSet = DOTween.Sequence();
            animSet.Append(transform.DOScale(2.5f, 0.3f))
                   .Join(spriteRenderer.DOFade(0.0f, 0.3f))
                   .OnComplete(() => { orbDestroyer.Destroy(); });
        }
    }
}