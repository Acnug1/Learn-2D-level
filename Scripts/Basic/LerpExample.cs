using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExample : MonoBehaviour
{
    [SerializeField] private Transform _a;
    [SerializeField] private Transform _b;
    [SerializeField] private Transform _target;

  //  [SerializeField] private float _pathTime;
  //  [SerializeField] private float _pathRunningTime;

    private void Update()
    {
        //    _pathRunningTime += Time.deltaTime;
        //    _target.position = Vector3.Lerp(_a.position, _b.position, _pathRunningTime / _pathTime);
        _target.position = Vector3.Lerp(_target.position, _b.position, 0.01f); // Движение от текущей позиции к итоговой и итог становится нашей текущей
        // (Начинаем двигаться быстро и потом плавно замедляемся)
    }

    public void SetNormalizedPosition(float position)
    {
        _target.position = Vector3.Lerp(_a.position, _b.position, position);
    }
}
