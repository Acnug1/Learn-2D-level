using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

   private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.red, 2).SetLoops(-1, LoopType.Yoyo); // OColor(Color.red, 2) - изменение цвета
        _spriteRenderer.DOFade(0, 1).SetLoops(-1, LoopType.Yoyo); // DOFade(0, 1) - изменение прозрачности цвета
    }
}
