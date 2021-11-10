using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(new Vector3(0, 5, 0), 3).From().SetDelay(2).SetLoops(-1, LoopType.Yoyo);
        // From() - инверсия движения анимации
        // SetDelay(2) - задержка при запуске анимации
        // LoopType.Yoyo - тип повтора анимации
    }
}
