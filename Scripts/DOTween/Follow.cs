using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; // подключение библиотеки DOTween

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _targetLastPosition;
    private Tweener _tween;

    private void Start()
    {
        _tween = transform.DOMove(_target.position, 2).SetAutoKill(false); // Отключает автоуничтожение анимации
        _targetLastPosition = _target.position;
    }

    private void Update()
    {
        if (_targetLastPosition != _target.position)
        {
            _tween.ChangeEndValue(_target.position, true).Restart();
            // ChangeEndValue - назначает новую конечную точку для анимации, true - означает, что анимация запустится ни с самого начала,
            // а с конечной точки, где закончилась предыдущая анимация. Restart() - перезапуск анимации, которая хранится в объекте _tween
            _targetLastPosition = _target.position;
        }
    }
}
