using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MoveButtonStart : MonoBehaviour
{
    private void Start()
    {
        Tween tween = transform.DOLocalMoveY(350, 6);
        tween.SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
