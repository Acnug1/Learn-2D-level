using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndPoint : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached = new UnityEvent();

    public event UnityAction Reached // Имитирует поле [SerializeField] private UnityEvent _reached для удобной работы из скриптов
    {
        add => _reached.AddListener(value);
        remove => _reached.RemoveListener(value);
    }

    public bool IsReached { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsReached)
            return;

        if (collision.TryGetComponent<Player>(out Player player))
        {
            IsReached = true;
            _reached.Invoke();
        }
    }
}
