using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game01
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private int _amount;

        //   private int _coinCount;

        public int Amount => _amount;

        //   public void Init(int coinCount)
        //   {
        //       _coinCount = coinCount;
        //       Debug.Log(_coinCount * _amount);
        //   }
    }
}
