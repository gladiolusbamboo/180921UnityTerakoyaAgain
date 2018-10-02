using UnityEngine;
using DG.Tweening;

namespace Orb
{
    public class OrbDeleter : MonoBehaviour
    {
        public RectTransform rect;

        internal void Delete()
        {
            Vector3[] path =
            {
                new Vector3(rect.localPosition.x *1.5f,300f,0f),
                new Vector3(0f,150f,0f)
            };

            rect.DOLocalPath(path, 0.5f, PathType.CatmullRom)
                .SetEase(Ease.OutQuad)
                .OnComplete(() => Destroy(this.gameObject));
            rect.DOScale(
                new Vector3(0.5f, 0.5f, 0f),
                0.5f
                );
        }
    }
}