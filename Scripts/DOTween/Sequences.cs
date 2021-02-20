using UnityEngine;
using DG.Tweening;

public class Sequences : MonoBehaviour
{
    private void Start()
    {
        Sequence sequence = DOTween.Sequence(); // Создание последовательности

        sequence.Append(transform.DOMoveY(3, 4).SetRelative()); // Добавляем анимацию в конец последовательности (SetRelative() - движение от начального значения координат к конечному (конкатенация))
        sequence.Insert(0, transform.DORotate(new Vector3(60, 15, 0), 2)); // вставляем на той же нулевой секунде поворот (Вставляет данный Твин в заданную временную позицию, таким образом позволяя вам перекрывать твины вместо того, чтобы просто помещать их друг за другом.)

        sequence.Append(transform.DOMoveX(3, 4).SetRelative()); // SetRelative() - запускается, после завершения предыдущей анимации
        sequence.Insert(4, transform.DORotate(new Vector3(0, 40, 15), 2)); // вставляем на четвертой секунде поворот

        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
