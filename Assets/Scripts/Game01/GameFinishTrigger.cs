using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishTrigger : MonoBehaviour
{
    private EndPoint[] _points;

    private void OnEnable()
    {
        _points = gameObject.GetComponentsInChildren<EndPoint>();

        foreach (var point in _points)
        {
            point.Reached += OnEndPointReached; // подписаться на событие
        }
    }

    private void OnDisable()
    {
        foreach (var point in _points)
        {
            point.Reached -= OnEndPointReached; // отписаться от события
        }
    }

    private void OnEndPointReached()
    {
        foreach (var point in _points)
        {
            if (point.IsReached == false)
                return;
        }
        Debug.Log("Finish!"); 
    }
}
