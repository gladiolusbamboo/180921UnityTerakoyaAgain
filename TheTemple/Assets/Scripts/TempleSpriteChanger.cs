using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Temple
{
    public class TempleSpriteChanger : MonoBehaviour
    {
        public Sprite[] sprites;
        public Image imageComponent;

        internal void ChangeTempleSprite(int level)
        {
            if (level < sprites.Length)
                imageComponent.sprite = sprites[level];
            else
                imageComponent.sprite = sprites[sprites.Length - 1];
        }
    }
}
