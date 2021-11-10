using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    [SerializeField] private Coin _template;
    [SerializeField] private int _count;
    [SerializeField] private float _spawnDistance;
    [SerializeField] private Transform _parent;

    private void Awake()
    {
        for (int i = 0; i < _count; i++)
        {
            var createCoin = Instantiate(_template, Vector3.zero, Quaternion.identity, _parent);

            Transform newCoinTransform = createCoin.GetComponent<Transform>();

            newCoinTransform.position = new Vector3(_spawnDistance * i, -4.5f, 0);
        }
    }
}
