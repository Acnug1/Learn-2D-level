using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    private Coin[] _coins;
    private int _countCoin;

    private void Start()
    {
        _coins = gameObject.GetComponentsInChildren<Coin>();

        foreach (var coin in _coins)
        {
            coin.Reached += OnEndCoinReached;
        }
    }

    private void OnDisable()
    {
        foreach (var coin in _coins)
        {
            coin.Reached -= OnEndCoinReached;
        }
    }

    private void OnEndCoinReached()
    {
        foreach (var coin in _coins)
        {
            if (coin.IsReached == true)
                _countCoin++;
        }

        Debug.Log($"Собрано {_countCoin} монет из {_coins.Length}");
        _countCoin = 0;

        foreach (var coin in _coins)
        {
            if (coin.IsReached == false)
                return;
        }

        Debug.Log("Finish!");
    }
}
