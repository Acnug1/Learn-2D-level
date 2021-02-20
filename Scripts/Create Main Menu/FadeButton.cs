using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeButton : MonoBehaviour
{
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.DOFade(0.8f, 6).SetLoops(-1, LoopType.Yoyo);
    }
}
