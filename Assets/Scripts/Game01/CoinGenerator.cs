using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] private Game01.Coin _template;
    [SerializeField] private int _coinCount;
    [SerializeField] private Transform _parent;

    private void Awake()
    {
        for (int i = -1; i < _coinCount - 1; i++)
        {
            var createdCoin = Instantiate(_template, new Vector3(-11 * i, -8.2f, 0), Quaternion.identity, _parent);
         //   createdCoin.Init(_coinCount);
        }   
    }
}
