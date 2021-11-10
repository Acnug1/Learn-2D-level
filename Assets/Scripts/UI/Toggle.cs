using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour // Toggle можно использовать для отключения/включения музыки в игре или каких-либо игровых объектов
{
    [SerializeField] private Text _text;

    public void OnToggleChanged(bool state) // Возвращает true или false, при изменении значения пользователем на объекте Toggle. Вызывается из события 
    {
        _text.gameObject.SetActive(state);
    }
}
