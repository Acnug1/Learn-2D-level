using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private TMP_Dropdown _dropdown;

    public void DropdownToText(int num) // с помощью события на элементе TMP_Dropdown возвращает номер выбранного пользователем элемента из списка в данный метод и возвращает его текст
    {
        _text.text = _dropdown.options[num].text;
    }
}
