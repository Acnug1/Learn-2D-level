using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void Start()
    {
        Debug.Log("[" + Time.time + "] Start - " + gameObject.name);
    }

    private void Update()
    {
        Debug.Log("[" + Time.time + "] Update - " + gameObject.name);
    }
}
