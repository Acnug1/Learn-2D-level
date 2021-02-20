using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldToText : MonoBehaviour
{
    [SerializeField] TMP_Text _text;

    public void ToText(string str) // с помощью события на элементе TMP_InputField возвращает введенную пользователем строку в данный метод
    {
        _text.text = str;
    }

}
