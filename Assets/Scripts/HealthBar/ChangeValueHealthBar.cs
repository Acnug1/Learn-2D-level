using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeValueHealthBar : MonoBehaviour
{
    private Slider _slider;
    [SerializeField] private int _animationTime;
    [SerializeField] private HealthBird _healthBird;

    private float _lastHealthValue;
    private Tweener _tween;

    private void Start()
    {
        _slider = GetComponent<Slider>();

        _tween = _slider.DOValue(_healthBird.Health, _animationTime).SetEase(Ease.Linear).SetAutoKill(false);
        _lastHealthValue = _healthBird.Health;
    }

    private void Update()
    {
        if (_lastHealthValue != _healthBird.Health)
        {
            _tween.ChangeEndValue(_healthBird.Health, true).Restart();
            _lastHealthValue = _healthBird.Health;
        }
    }
}
