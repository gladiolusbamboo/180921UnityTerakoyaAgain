﻿using UnityEngine;
using DG.Tweening;
using Score;
using Temple;

public class OrbFlyer : MonoBehaviour {
    public LevelUpChecker levelUpChecker;
    public TempleScaler templeScaler;

    // Use this for initialization
    void Start () {
//        Fly();
    }

    public void Fly()
    {
        RectTransform rect = GetComponent<RectTransform>();

        // オーブの軌跡設定
        Vector3[] path =
        {
            new Vector3(rect.localPosition.x*4.0f,300f,0f),
            new Vector3(0f,250f,0f)
        };

        rect.DOLocalPath(path, 0.5f, PathType.CatmullRom)
            .SetEase(Ease.OutQuad)
                .OnComplete(orbFlyerCallBack);
        rect.DOScale(new Vector3(0.5f,0.5f,0f),0.5f);
    }

    public void orbFlyerCallBack()
    {
        levelUpChecker.Check();
        Destroy(this.gameObject);
        templeScaler.Scale();
    }


}
