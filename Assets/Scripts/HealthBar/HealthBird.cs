using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBird : MonoBehaviour
{
    private Animator _animator;

    private float _health = 100;

    public float Health => _health;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ChangeHealthCount(float value)
    {
        _health += value;

        if ((_health > 0) && (_health <= 100))
            _animator.SetTrigger("isAction");

        if (_health > 100)
            _health = 100;

        if (_health <= 0)
            _animator.SetBool("isDeath", true);
    }
}
