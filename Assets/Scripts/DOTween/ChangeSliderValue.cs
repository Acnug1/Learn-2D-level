using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeSliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider; // Можно изменять жизни по аналогии с преследованием 
    // (в скрипте Follow делаем замену DOMove(transform._target.position, 2) на _slider.DOValue(Health, 2) и изменяем position на value)

    private void Start()
    {
        _slider.DOValue(1, 2).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo); // SetEase(Ease.Linear) - изменение типа анимации (например, линейный тип)
    }
}
