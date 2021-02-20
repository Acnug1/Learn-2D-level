using System;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Extensions
{
    static class EventSystemExtensions // добавляем в данный тип дополнительный метод (расширяем класс EventSystem)
    {
        // Создадим метод расширения
        public static T GetFirstComponentUnderPointer<T>(this EventSystem system, PointerEventData eventData) where T : class // Первым параметром через this мы передает элемент, который мы расширяем, т.е. EventSystem system в текущем объекте. А дальше указываем все, что хотим передавать методом
        // Атрибут "Т" (джинерик) позволяет нам потом вызывать метод и любой тип подставлять, вместо "T"
        {
            var result = new List<RaycastResult>(); // создаем пустой список для записи результата
            system.RaycastAll(eventData, result); // применяется для raycast в ui системе, для получения доступа к текущей системе обработки событий

            foreach (var raycast in result) // перебирем список рейкастов
                if (raycast.gameObject.TryGetComponent<T>(out T component))
                    return component;

            return null;
        }
    }
}
