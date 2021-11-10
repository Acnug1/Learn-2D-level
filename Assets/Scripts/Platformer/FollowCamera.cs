using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Platformer.Player _player;
    private Vector3 _offset;

    private void Start()
    {
        _offset = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        transform.position = new Vector3(_player.transform.position.x, _offset.y, _offset.z);
    }
}
