using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private ConstantForce2D newForce;

    private void Start()
    {
        newForce = GetComponent<ConstantForce2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //   transform.Translate(_speed * Time.deltaTime, 0, 0);
            newForce.relativeForce = new Vector2(_speed * Time.deltaTime, 0);
        }
        else
        if (Input.GetKey(KeyCode.A))
        {
            //   transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            newForce.relativeForce = new Vector2(-_speed * Time.deltaTime, 0);
        }
        else
        {
            newForce.relativeForce = new Vector2(0, 0);
        }   
    }
}
