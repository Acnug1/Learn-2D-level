using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _reachedColor;

    public void ChangeColor()
    {
        _renderer.color = _reachedColor;
    }
}
