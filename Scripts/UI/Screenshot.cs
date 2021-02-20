using System; // добавляем данную библиотеку, для того, чтобы заработал атрибут [Serializable]
using UnityEngine;

[Serializable] // атрибут, с помощью которого мы можем оперировать компонентом из инспектора (если данный компонент не привязан ни к одному объекту в Unity)
public class Screenshot // не является MonoBehaviour, потому что нет никакого смысла распологать данный класс на объекте
{
    private Sprite _image;
    private DateTime _creationTime;

    public Screenshot(Sprite image, DateTime creationTime)
    {
        _image = image;
        _creationTime = creationTime;
    }

    public Sprite Image => _image; // свойства на чтение
    public DateTime CreationTime => _creationTime;
}
