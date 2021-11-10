using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    [SerializeField] private Image _image;

    // Корутины
    private void Start()
    {
        var fadeInJob = StartCoroutine(FadeIn(0.01f)); // запустить корутину (через каждую 0.01 сек меняет прозрачность на единицу)

        if (Time.timeScale == 0) // если игру поставили на паузу
        {
            StopCoroutine(fadeInJob); // остановить корутину
        }
        
    }
    private IEnumerator FadeIn(float duration) // Возвращает интерфейс IEnumerator
    {
        var color = _image.color;
        var waitForSeconds = new WaitForSeconds(duration);

        for (int i = 0; i < 256; i++)
        {
            color.a = 1f - (1f / 255f * i);
            _image.color = color;

            yield return waitForSeconds; // WaitForEndOfFrame после каждой итерации мы возвращаемся из этой функции, ждем кадр и возвращаемся в эту же точку в следующий раз
            // Time.timeScale = 0; - Можно использовать для остановки времени игры для паузы или создания эффекта Slow Motion
        }
    }
}
