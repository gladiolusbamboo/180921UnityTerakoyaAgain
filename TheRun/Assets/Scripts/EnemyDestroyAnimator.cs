using DG.Tweening;
using UnityEngine;

namespace Enemy
{
    public class EnemyDestroyAnimator : MonoBehaviour
    {
        public CircleCollider2D circleCollider2D;
        public BoxCollider2D boxCollider2D;
        public EnemyDestroyer enemyDestroyer;

        internal void Animate()
        {
            Destroy(circleCollider2D);
            Destroy(boxCollider2D);
            Sequence animSet = DOTween.Sequence();
            animSet.Append(transform.DOLocalMoveY(0.5f,0.2f).SetRelative())
                   .Append(transform.DOLocalMoveY(-10.0f,1.0f).SetRelative()
                   .OnComplete(() => { enemyDestroyer.Destroy(); }));
        }
    }
}