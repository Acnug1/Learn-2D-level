using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldsExample : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private int _minRange;
    [SerializeField] private int _maxRange;

    private Vector3 _currentPosition;

    public Vector3 CurrentPosition => _currentPosition; // Свойство CurrentPosition { get; }

    public void OnValidate() // Вызывается, когда в инспекторе меняется значение полей
    {
        if (_minRange >= _maxRange)
            _minRange = _maxRange - 1;
    }
}
