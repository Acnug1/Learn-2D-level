using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // alt + enter - вызов подсказки
using System;
using Assets.Scripts.Extensions;

public class ScreenshotView : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _date;

    private Transform _dragingParent; // Определяем Canvas, по которому мы будем скользить
    private Transform _previousParent; // Запоминаем предыдущего родителя

    public void Init(Transform dragingParent)
    {
        _dragingParent = dragingParent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _previousParent = transform.parent; // запоминаем предыдущего родителя (объект Content)
        transform.parent = _dragingParent; // отцепляемся от нашего родителя Content и прицепляемся к новому родителю Canvas
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position; // принимаем текущую позицию мышки (объекта, который мы двигаем)
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.parent = _previousParent; // если перемещение не удалось снова прикрепляем объект к родителю Content
        var container = EventSystem.current.GetFirstComponentUnderPointer<DropContainer>(eventData); // проверяем в методе расширения GetFirstComponentUnderPointer<DropContainer>(eventData) коснулся ли наш курсор eventData объекта с компонентом DropContainer
        // если да, возвращаем этот объект (в данном случае Scroll View), иначе возвращаем нул

        if (container != null) // делаем проверку, что объект найден
        {
            transform.parent = container.Container; // подвязываем объект к новому контейнеру Content, на первом попавшемся объекте Scroll View
        }
        else
        {
            transform.parent = _previousParent; // иначе подвязываем к предыдущему родителю
        }
    }

    public void Render(Screenshot screenshot)
    {
        _image.sprite = screenshot.Image;
        _date.text = screenshot.CreationTime.ToString();
    }
}
