using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _animator.SetBool("isEnter", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _animator.SetBool("isEnter", false);
    }

    public void OnButtonClick()
    {
        _animator.SetBool("isEnter", false);
        _animator.SetTrigger("isClick");
    }
}
