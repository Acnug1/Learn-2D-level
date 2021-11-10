using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeHealthBar : MonoBehaviour // изменение отображения количества жизней на slider
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _health;
    [SerializeField] private int _animationTime;

    private float _lastHealthValue;
    private Tweener _tween;

    private void Start()
    {
        _tween = _slider.DOValue(_health, _animationTime).SetEase(Ease.Linear).SetAutoKill(false); // Отключает автоуничтожение анимации
        _lastHealthValue = _health;
    }

    private void Update()
    {
        if (_lastHealthValue != _health)
        {
            _tween.ChangeEndValue(_health, true).Restart();
            // ChangeEndValue - назначает новую конечную точку для анимации, true - означает, что анимация запустится ни с самого начала,
            // а с конечной точки, где закончилась предыдущая анимация. Restart() - перезапуск анимации, которая хранится в объекте _tween
            _lastHealthValue = _health;
        }
    }
}
