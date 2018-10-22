using DG.Tweening;
using UnityEngine;

namespace Player {
    public class PlayerEnemyHitAnimator : MonoBehaviour, IPlayerMissAnimator {
        public CircleCollider2D circleCollider2D;
        public BoxCollider2D boxCollider2D;
        public PlayerDestroyer playerDestroyer;

        public void Animate()
        {
            Destroy(circleCollider2D);
            Destroy(boxCollider2D);
            Sequence animSet = DOTween.Sequence();
            animSet.Append(transform.DOLocalMove(new Vector3(0f, 1.0f), 0.2f).SetRelative())
                   .Append(transform.DOLocalMove(new Vector3(0f, -10.0f), 1.0f).SetRelative()
                   .OnComplete(() => { playerDestroyer.Destroy(); }));
        }
    }
}