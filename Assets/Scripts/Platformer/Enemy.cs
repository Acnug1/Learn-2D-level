using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AudioSource))]

public class Enemy : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _audio;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Platformer.Player player))
        {
            _animator.SetTrigger("Attack");
            _audio.Play();
        }
    }
}
