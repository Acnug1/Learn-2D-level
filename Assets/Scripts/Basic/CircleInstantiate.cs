using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInstantiate : MonoBehaviour
{
    public GameObject Template;
    public int Count;
    public float Radius;

    private void Start()
    {
        int angleStep = 360 / Count;
        for (int i = 0; i < Count; i++)
        {
            GameObject newObject = Instantiate(Template, new Vector3(0, 1, 0), Quaternion.identity);

            Transform newObjectTransform = newObject.GetComponent<Transform>();

            newObjectTransform.position = new Vector3(Radius * Mathf.Cos(angleStep * i * Mathf.Deg2Rad), Radius * Mathf.Sin(angleStep * i * Mathf.Deg2Rad), 0);

            newObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
