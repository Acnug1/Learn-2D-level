using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private HealthBird _healthBird;
    [SerializeField] private float _healthCountChange;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnButtonClick()
    {
        _animator.SetTrigger("isClick");

        if ((_healthBird.Health > 0) && (_healthBird.Health <= 100))
        {
            _healthBird.ChangeHealthCount(_healthCountChange);
        }
    }
}
