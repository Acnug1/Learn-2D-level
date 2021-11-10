using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCountView : MonoBehaviour
{
    // [SerializeField] private Coin _coin;

    private Coin _coin;

    private void Awake()
    {
        _coin = FindObjectOfType<Coin>();
    }

    private void Init(Coin coin)
    {
       
    }

    private void OnTransformParentChanged()
    {
        
    }
    private void OnTransformChildrenChanged()
    {
        
    }
}
