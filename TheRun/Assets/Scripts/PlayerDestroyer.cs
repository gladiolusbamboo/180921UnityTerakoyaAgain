using DG.Tweening;
using UnityEngine;

namespace Player
{
    public class PlayerDestroyer : MonoBehaviour
    {
        public CircleCollider2D circleCollider2D;
        public BoxCollider2D boxCollider2D;

        internal void Destroy()
        {
            Destroy(circleCollider2D);
            Destroy(boxCollider2D);
            Sequence animSet = DOTween.Sequence();
            animSet.Append(transform.DOLocalMoveY(1.0f, 0.2f).SetRelative());
            animSet.Append(transform.DOLocalMoveY(-10.0f, 1.0f).SetRelative());

            Destroy(gameObject, 1.2f);
        }
    }
}
