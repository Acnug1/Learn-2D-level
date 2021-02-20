using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] private float _speed;

    private readonly RaycastHit2D[] _results = new RaycastHit2D[1];
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var collisionCount = _rigidbody2D.Cast(transform.right, _filter, _results, 3);

        if (collisionCount == 0)
        {
            _rigidbody2D.velocity = transform.right * _speed;
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
    }
}
