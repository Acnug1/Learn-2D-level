using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerClickHandler   
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;

    public void OnPointerClick(PointerEventData eventData)
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}