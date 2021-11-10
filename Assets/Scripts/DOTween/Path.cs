using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;

    private void Start()
    {
        Tween tween = transform.DOPath(_waypoints, 5, PathType.CatmullRom).SetOptions(true).SetLookAt(0.01f);
        // PathType.CubicBezier - настройки типа пути (линейной или плавной ломаной линией). 
        // SetOptions(true) - закрывает путь. Соединяет конечную точку с начальной (но не перезапускает анимацию)
        // SetLookAt(0.01f) - определяет, как быстро объект будет разворачиваться в сторону точки (0.01f - быстро, 1 - медленно)

        tween.SetEase(Ease.Linear).SetLoops(-1);
        // SetEase(Ease.Linear) - Создание линейной, непрерывной анимации (таймлайна)
        // SetLoops(-1) - бесконечно зацикленная анимация (другое значение - количество воспроизведений анимации)
    }
}
