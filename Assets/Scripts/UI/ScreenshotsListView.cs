using System; // необходим для работы атрибута DateTime.Now
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotsListView : MonoBehaviour
{
    [SerializeField] private ScreenshotView _template;
    [SerializeField] private Transform _container;

    [SerializeField] private Sprite _defaultSprite; // служебное поле, в котором мы указываем дефолтный спрайт для отрисовки
    [SerializeField] private Transform _dragingParent; // Transform по которому будет происходить drag (определяем его для всего листа)

    private void Awake()
    {
        Render(new List<Screenshot>()
        {
            new Screenshot(_defaultSprite, DateTime.Now),
            new Screenshot(_defaultSprite, DateTime.Now),
            new Screenshot(_defaultSprite, DateTime.Now)
        });
    }

    private void Render(IEnumerable<Screenshot> screenshots) // храним перечислитель (IEnumerable) / список (list) скриншотов
    {
        foreach (var screenshot in screenshots) // перебираем список скриншотов
        {
            var view = Instantiate(_template, _container) as ScreenshotView; // приводим тип к ScreenshotView
            view.Init(_dragingParent); // используем метод Init вместо конструктора в Unity
            view.Render(screenshot); // отрисовываем скриншот
        }
    }
}
